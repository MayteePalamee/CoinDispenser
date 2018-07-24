using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinDispenser
{
    /// <summary>
    /// Command to device
    /// </summary>
    public class Request
    {
        private String state;
        private String reset;
        private String initial1;
        private String initial2;
        /// <summary>
        /// 
        /// </summary>
        public String Initial1
        {
            get { return initial1; }
            set { initial1 = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String Initial2
        {
            get { return initial2; }
            set { initial2 = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String State
        {
            get { return state; }
            set { state = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String Reset
        {
            get { return reset; }
            set { reset = value; }
        }
    }
}
