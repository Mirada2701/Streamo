using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streamo.Application.Common.Interfaces {
    public interface IHttpClientFactory {
        HttpClient CreateClient(string name = "");
    }
}
