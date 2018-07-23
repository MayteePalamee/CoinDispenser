using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace CoinDispenser
{
    /// <summary>
    /// <para>Coin Dispenser class</para>
    /// </summary>
    public class Coindispenser : SerialPortHelper
    {
        /// <summary>
        /// Initial DeviceInfo data
        /// </summary>
        public Coindispenser()
        {
            new DeviceInfo
            {
                /*Ready = "00",
                Enable = "3E",
                Inhibit = "5E",
                MotorProblem = "01",
                Insufficient = "02",
                DedectsCoin = "03",
                Reserved = "04",
                PrismSersorFailure = "05",
                ShaftSersorFailure = "06"*/
               Initial = "12", 
               Ready = "00",
               Empty = "",

            };

            new Request
            {

            };
        }
        /// <summary>
        /// <para>Declare the event for message events</para>
        /// </summary>
        public event EventHandler<Events> MessageEvent;
       
        /// <summary>
        /// <para>Declare the event for serial port events</para>
        /// </summary>
        public event EventHandler<Events> CoinDispenserEvent;
        
        /// <summary>
        /// delegate method handle raise event
        /// </summary>
        /// <param name="e">message on events</param>
        protected virtual void OnMessage(Events e)
        {
            MessageEvent?.Invoke(this, e);
        }

        /// <summary>
        /// delegate method handle raise event
        /// </summary>
        /// <param name="e">message on events</param>
        protected virtual void OnCoinDispenser(Events e)
        {
            CoinDispenserEvent?.Invoke(this, e);
        }

        private SerialPort _serialPort = new SerialPort();
        Stated status;

        /// <summary>
        /// Connect to Devices.
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean Connect()
        {
            bool result = false;
            try
            {
                _serialPort = Initial();

                if (_serialPort.IsOpen){

                }
                OnMessage(new Events("Connect"));
            }
            catch (Exception ex)
            {
                OnMessage(new Events(ex.Message));
            }
            return result;
        }
        /// <summary>
        /// Disabled Devices.
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean Disabled()
        {
            bool result = false;
            try
            {

            }
            catch (Exception ex)
            {
                OnMessage(new Events(ex.Message));
            }
            return result;
        }

        /// <summary>
        /// Enabled Devices.
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean Enabled()
        {
            bool result = false;
            try
            {
                
            }
            catch (Exception ex)
            {
                OnMessage(new Events(ex.Message));
            }
            return result;
        }
        /// <summary>
        /// Disconect Devices.
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean Disconnect()
        {
            bool result = false;
            try
            {

            }
            catch (Exception ex)
            {
                OnMessage(new Events(ex.Message));
            }
            return result;
        }
        /// <summary>
        /// Send command to Devices.
        /// </summary>
        /// <returns>Boolean</returns>
        public Stated Transmitter(string command)
        {
            status = new Stated();
            try
            {

            }
            catch (Exception ex)
            {
                OnMessage(new Events(ex.Message));
            }
            return status;
        }
    }
}
