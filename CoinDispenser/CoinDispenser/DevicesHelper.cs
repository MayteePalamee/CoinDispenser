using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinDispenser
{
    public interface DevicesHelper
    {
        Status Connect();
        Status Transmitte(String command);
        Status Disconnect();
        Status Enabled();
        Status Disabled();
        Status Received();
    }
}
