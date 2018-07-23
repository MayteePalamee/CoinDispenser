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
