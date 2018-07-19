using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinDispenser
{
    /// <summary>
    /// Data Response
    /// </summary>
    public class Stated
    {
        private Boolean state;
        private String description;

        public Boolean State {
            get { return state; }
            set { state = value; }
        }
        public String Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
