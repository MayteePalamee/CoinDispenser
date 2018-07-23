using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinDispenser
{
    /// <summary>
    /// 
    /// </summary>
    public class DeviceInfo
    {
        private String singlePayout;
        private String multiplePayout;
        private String payOutsuccess;
        private String payOutfails;
        private String ready;
        private String emptyNote;
        private String stockLess;
        private String noteJam;
        private String overLength;
        private String noteNotexit;
        private String sensorError;
        private String doubleNoteError;
        private String motorError;
        private String dispensingBusy;
        private String sensorAdjusting;
        private String initial;
        private String empty;
        /// <summary>
        /// 
        /// </summary>
        public String Empty
        {
            get { return empty; }
            set { empty = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String Initial
        {
            get { return initial; }
            set { initial = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String SinglePayout
        {
            get { return singlePayout; }
            set { singlePayout = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String MultiplePayout
        {
            get { return multiplePayout; }
            set { multiplePayout = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String PayOutsuccess
        {
            get { return payOutsuccess; }
            set { payOutsuccess = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String PayOutfails
        {
            get { return payOutfails; }
            set { payOutfails = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String Ready
        {
            get { return ready; }
            set { ready = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String EmptyNote
        {
            get { return emptyNote; }
            set { emptyNote = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String StockLess
        {
            get { return stockLess; }
            set { stockLess = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String NoteJam
        {
            get { return noteJam; }
            set { noteJam = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String OverLength
        {
            get { return overLength; }
            set { overLength = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String NoteNotexit
        {
            get { return noteNotexit; }
            set { noteNotexit = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String SensorError
        {
            get { return sensorError; }
            set { sensorError = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String DoubleNoteError
        {
            get { return doubleNoteError; }
            set { doubleNoteError = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String MotorError
        {
            get { return motorError; }
            set { motorError = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String DispensingBusy
        {
            get { return dispensingBusy; }
            set { dispensingBusy = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String SensorAdjusting
        {
            get { return sensorAdjusting; }
            set { sensorAdjusting = value; }
        }
    }
}
