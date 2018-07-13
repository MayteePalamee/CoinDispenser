using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinDispenser
{
    public class Response
    {
        /**
         * Default status 
         **/
        private String connect;
        private String disconnect;
        private String fault;
        private String unavailable;
        private String success;
        private String ready;

        private String enable;
        private String inhibit;
        private String motorProblem;
        private String insufficient;
        private String dedectsCoin;
        private String reserved;
        private String prismSersorFailure;
        private String shaftSersorFailure;

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
        public String Connect
        {
            get { return connect; }
            set { connect = value; }
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
        public String Disconnect
        {
            get { return disconnect; }
            set { disconnect = value; }
        }
        public String Fault
        {
            get { return fault; }
            set { fault = value; }
        }
        public String Unavailable
        {
            get { return unavailable; }
            set { unavailable = value; }
        }
        public String Success
        {
            get { return success; }
            set { success = value; }
        }
        public String Ready
        {
            get { return ready; }
            set { ready = value; }
        }
    }
}
