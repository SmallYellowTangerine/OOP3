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
    abstract class Genre
    {
        [DataMember]
        public string bookExample { get; set; }

       
        public virtual void SetProperties(Dictionary<string, string> properties)
        {
            //bookExample = properties["bookExample"];
        }
 
        public virtual Dictionary<string, string> GetProperties()
        {
            var properties = new Dictionary<string, string>();

            //properties["bookExample"] = bookExample;

            return properties;
        }

        /*public abstract string bookExample
        {
            
            get;
            set;
        }*/

    }




}
