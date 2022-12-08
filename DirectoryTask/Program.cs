using System.IO;

namespace DirectoryTask
{
    internal class Program
    {
        static string path = @"C:\Users\HP\Desktop\c# files\DirectoryTask\DirectoryTask\DirectoryTask.csproj";
      
        static void Main(string[] args) 
        {
            List<string> list = new List<string>();
            list.Add("Shahnaz");
            list.Add("Ulviyya");
            Search("Ulviyya");
        }
        static void Add(string name)
        {
            List<string> namessFromJson = Helper.JsonToObject<List<string>>(Path.Combine(path,"name.json"));
            if (!namessFromJson.Contains(name))
            {
                namessFromJson.Add(name);
            }
            Helper.SaveAsJson(namessFromJson, Path.Combine(path,"name.json"));
        }
        static bool Search(string name)
        {
            List<string> namessFromJson = Helper.JsonToObject<List<string>>(Path.Combine(path, "name.json"));
            if(namessFromJson.Contains(name))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        static void Update(int index, string name)
        {
            List<string> namessFromJson = Helper.JsonToObject<List<string>>(Path.Combine(path, "name.json"));
            if (namessFromJson.Count > index && index>=0)
            {
                namessFromJson[index] = name;
            }
            else
            {
                Console.WriteLine("Indexi duzgun daxil edin");
            }
            Helper.SaveAsJson(namessFromJson, Path.Combine(path, "name.json"));
        }
        static void Delete(int index)
        {
            List<string> namessFromJson = Helper.JsonToObject<List<string>>(Path.Combine(path, "name.json"));
            if (namessFromJson.Count > index && index >= 0)
            {
                namessFromJson.Remove(namessFromJson[index]);
            }
            else
            {
                Console.WriteLine("Indexi duzgun daxil edin");
            }
            Helper.SaveAsJson(namessFromJson, Path.Combine(path, "name.json"));
        }
    }
}