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
        private String initital;
        private String empty;
        private String ready;
        private String problemsRecovered;
        private String problemsOccurred;
        private String mortorProblem;
        private String insufficientCoin;
        private String dedectsCoin;
        private String reserved;
        private String prismSersorFailure;
        private String shaftSersorFailure;
        /// <summary>
        /// 
        /// </summary>
        public String Initial
        {
            get { return initital; }
            set { initital = value; }
        }
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
        public String Ready
        {
            get { return ready; }
            set { ready = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String ProblemsRecovered
        {
            get { return problemsRecovered; }
            set { problemsRecovered = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String ProblemsOccurred
        {
            get { return problemsOccurred; }
            set { problemsOccurred = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String MortorProblem
        {
            get { return mortorProblem; }
            set { mortorProblem = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String InsufficientCoin
        {
            get { return insufficientCoin; }
            set { insufficientCoin = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String DedectsCoin
        {
            get { return dedectsCoin; }
            set { dedectsCoin = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String Reserved
        {
            get { return reserved; }
            set { reserved = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String PrismSersorFailure
        {
            get { return prismSersorFailure; }
            set { prismSersorFailure = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String ShaftSersorFailure
        {
            get { return shaftSersorFailure; }
            set { shaftSersorFailure = value; }
        }
    }
}
