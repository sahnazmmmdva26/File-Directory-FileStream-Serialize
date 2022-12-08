using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryTask
{
    internal class Helper
    {
        public static void SaveAsJson(object? obj, string path)
        {
            if (obj == null) return;
            string json = JsonConvert.SerializeObject(obj);
            if (!File.Exists(path)) File.Create(path);
            WriteToJson(json, path);
        }
        static void WriteToJson(string str, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(str);
            }
        }
        public static T? JsonToObject<T>(string path) where T : class
        {
            if (String.IsNullOrEmpty(path)) return null;
            using (StreamReader sr = new StreamReader(path))
            {
                T newT = JsonConvert.DeserializeObject<T>(sr.ReadToEnd());
                return newT;
            }
        }
      
    }
}
