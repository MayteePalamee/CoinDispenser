using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinDispenser
{
    public interface IDevicesHelper
    {
        Response Connect();
        Response Transmitte(String command);
        Response Disconnect();
        Response Enabled();
        Response Disabled();
        Response Received();
        Response Parallel(String command);
    }
}
