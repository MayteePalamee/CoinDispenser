using System;
using System.IO.Ports;
using System.Threading;

namespace CoinDispenser
{
    /// <summary>
    /// <para>Coin Dispenser class</para>
    /// </summary>
    public class Coindispenser : SerialPortHelper
    {
        /*Initial = "12", 
          Ready = "00",
          Empty = "",
          ProblemsRecovered = "3E",
          ProblemsOccurred = "5E",
          MortorProblem = "01",
          InsufficientCoin = "02",
          DedectsCoin = "03",
          Reserved = "04",
          PrismSersorFailure = "05",
          ShaftSersorFailure = "06"
          Initial1 = "70",
          Initial2 = "73",
          State = "72",
          Reset = "80",*/
        private String _invoke = "";
        private InitialPort initPort;
        private SerialPort _serialPort = new SerialPort();

        /// <summary>
        /// dispense coin
        ///  8140 coin dispense 1
        ///  8141 coin dispense 2
        ///  8142 coin dispense 3
        ///  8143 coin dispense 4
        ///  8144 coin dispense 5
        ///  8145 coin dispense 6
        ///  8146 coin dispense 7
        ///  8147 coin dispense 8
        ///  8148 coin dispense 9
        ///  8149 coin dispense 10
        ///  814A coin dispense 11
        ///  814B coin dispense 12
        ///  814C coin dispense 13
        ///  814D coin dispense 14
        ///  814E coin dispense 15
        ///  814F coin dispense 16
        /// </summary>
        /// <param name="coin">int coin type</param>
        /// <returns>boolean</returns>
        public Boolean Dispense(int coin)
        {
            byte[] data = { };
            bool state = false;
            int count = 0;
            try
            {
                if (!_serialPort.IsOpen){
                    _serialPort.Open();
                }
                    if (_serialPort.IsOpen)
                    {
                    for (int index = 0; index < coin; index++)
                    {
                        data = ConvertHexToByte("80");
                        _serialPort.Write(data, 0, data.Length);
                        Thread.Sleep(1);

                        data = ConvertHexToByte("8140");
                        _serialPort.Write(data, 0, data.Length);
                        Thread.Sleep(1);

                        data = ConvertHexToByte("10");
                        _serialPort.Write(data, 0, data.Length);
                        Thread.Sleep(1);
                        count++;
                    }
                    if(coin == count)
                    {
                        state = true;
                    }
                }
               }
            catch (Exception exception)
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                }
                _invoke = Status.Unavailable.ToString();
                Console.WriteLine("exception : " + exception);
            }
            return state;
        }
        /// <summary>
        /// current status
        /// </summary>
        /// <returns>status</returns>
        public String CurrentStatus()
        {
            byte[] data = { };
            bool state = false;
            try
            {
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                }
                if (Enable())
                {
                    if (_serialPort.IsOpen)
                    {
                       do
                        {
                            data = ConvertHexToByte("72");
                            _serialPort.Write(data, 0, data.Length);
                            Thread.Sleep(10);
                            state = CallState(_serialPort);
                        } while (state);
                    }
                }
            }
            catch (Exception exception)
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                }
                _invoke = Status.Unavailable.ToString();
                Console.WriteLine("exception : " + exception);
            }
            return _invoke;
        }
        /// <summary>
        /// Reset Device
        /// </summary>
        /// <returns>Status</returns>
        public String Reset()
        {
            byte[] data = { };
            try
            {
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                }
                if (Enable())
                {
                    if (_serialPort.IsOpen)
                    {
                        data = ConvertHexToByte("73");
                        _serialPort.Write(data, 0, data.Length);

                        CallState(_serialPort);
                    }
                }
            }
            catch (Exception exception)
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                }
                _invoke = Status.Unavailable.ToString();
                Console.WriteLine("exception : " + exception);
            }
            return _invoke;
        }

        /// <summary>
        /// Setter Serial NamePort.
        /// </summary>
        /// <param name="port">String NamePort</param>
        public void SetPort(String port)
        {
                initPort = new InitialPort();
                initPort.Comport = port;
                initPort.BaudRate = 9600;
                initPort.DataBits = 8;
                initPort.DtrEnable = true;

                _serialPort = Initial(initPort);
        }
        /// <summary>
        /// Getter Serial NamePort
        /// </summary>
        /// <returns>String NamePort</returns>
        public String GetPort()
        {
            return _serialPort.PortName == null ? "" : _serialPort.PortName;
        }

        private delegate void getStatus(string data);
        private void StateInfo(string data)
        {
            switch (data.ToUpper())
            {
                case "12":
                    _invoke = data.ToUpper();
                    break;
                case "00":
                    _invoke = Status.Ready.ToString();
                    break;
                case "3E":
                    _invoke = Status.Enable_BA_if_hopper_problems_recovered.ToString();
                    break;
                case "5E":
                    _invoke = Status.Inhibit_BA_if_hopper_problems_occurred.ToString();
                    break;
                case "01":
                    _invoke = Status.Motor_Problems.ToString();
                    break;
                case "02":
                    _invoke = Status.Insufficient_Coin.ToString();
                    break;
                case "03":
                    _invoke = Status.Dedects_coin_dispensing_activity_after_suspending_the_dispene_signal.ToString();
                    break;
                case "04":
                    _invoke = Status.Reserved.ToString();
                    break;
                case "05":
                    _invoke = Status.Prism_Sensor_Failure.ToString();
                    break;
                case "06":
                    _invoke = Status.Shaft_Sensor_Failure.ToString();
                    break;
                default:
                    _invoke = "";
                    break;
            }
        }
        private bool CallState(SerialPort serialPort)
        {
            byte[] rxBytes = { };
            bool readstate = false;
            if (serialPort.IsOpen)
            {
                serialPort.ReadTimeout = 1000;
                int count = serialPort.BytesToRead;
                if (count > 2) { readstate = true; }
                int totBytesRead = 0;
                rxBytes = new byte[count];
                while (totBytesRead < count)
                {
                    int bytesRead = serialPort.Read(rxBytes, 0, count - totBytesRead);
                    totBytesRead += bytesRead;
                }
                getStatus get = new getStatus(StateInfo);
                get(ConvertByteToString(rxBytes));
            }
            return readstate;
        }

        private bool Enable()
        {
            byte[] data = { };
            bool state = false;
            try
            {
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                }
                if (_serialPort.IsOpen)
                {
                    do
                    {
                      data = ConvertHexToByte("70");
                      _serialPort.Write(data, 0, data.Length);
                      Thread.Sleep(10);
                      state = CallState(_serialPort);
                    } while (state);

                    if (_invoke.Equals("12"))
                    {
                        state = true;
                    }
                }
            }
            catch(Exception exception)
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                }
                _invoke = Status.Unavailable.ToString();
                Console.WriteLine("exception : " + exception);
            }
            return state;
        }
    }
}
