using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinDispenser
{
    public class DeviceInfo
    {
        private String ready;
        private String enable;
        private String inhibit;
        private String motorProblem;
        private String insufficient;
        private String dedectsCoin;
        private String reserved;
        private String prismSersorFailure;
        private String shaftSersorFailure;
        /// <summary>
        /// 
        /// </summary>
        public String Enable
        {
            get { return enable; }
            set { enable = value; }
        }
        public String Inhibit
        {
            get { return inhibit; }
            set { inhibit = value; }
        }
        public String MotorProblem
        {
            get { return motorProblem; }
            set { motorProblem = value; }
        }
        public String Insufficient
        {
            get { return insufficient; }
            set { insufficient = value; }
        }
        public String DedectsCoin
        {
            get { return dedectsCoin; }
            set { dedectsCoin = value; }
        }
        public String Reserved
        {
            get { return reserved; }
            set { reserved = value; }
        }
        public String PrismSersorFailure
        {
            get { return prismSersorFailure; }
            set { prismSersorFailure = value; }
        }
        public String ShaftSersorFailure
        {
            get { return shaftSersorFailure; }
            set { shaftSersorFailure = value; }
        }
        public String Ready
        {
            get { return ready; }
            set { ready = value; }
        }
    }
}
