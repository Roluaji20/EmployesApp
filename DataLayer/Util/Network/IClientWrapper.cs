using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Util.Network
{
    public interface IClientWrapper
    {
        Task<string> SendRequest(string Uri,  HttpMethod method, Dictionary<string, object>? headers=null, string? parameter=null);
    }
}
