using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace OOPLab3
{
    [DataContract]
    class Fiction : Genre
    {
        public  override void SetProperties(Dictionary<string, string> properties)
        {
            bookExample = properties["Fiction"];
        }

    }
}
