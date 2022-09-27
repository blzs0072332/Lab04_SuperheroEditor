using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroEditor.Helpers
{
    public class JsonConverter
    {
        public JsonConverter()
        {
            if (File.Exists("save.json"))
            {

            }
        }

        public void ReadAll()
        {
            var data = JsonConvert.DeserializeObject("save.json");
            
        }
        public void WriteAll()
        {

        }
    }
}