using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTier
{
    public static class Assist
    {
        public static Out Convert<In, Out>(In Object)
        {
            string output = JsonConvert.SerializeObject(Object);
            return JsonConvert.DeserializeObject<Out>(output);
        }
    }
}
