using System.IO;

namespace DirectoryTask
{
    internal class Program
    {
        static string path = @"C:\Users\HP\Desktop\c# files\DirectoryTask\DirectoryTask";
      
        static void Main(string[] args) 
        {
            List<string> list = new List<string>();
            list.Add("Shahnaz");
            list.Add("Ulviyya");
            Helper.SaveAsJson(list, Path.Combine(path, "name.json"));
            Add("Ehtiram");
            Search("Ulviyya");
            Update(1, "Fateh");
            Delete(0);
            
        }
        static void Add(string name)
        {
            List<string> namessFromJson = Helper.JsonToObject<List<string>>(Path.Combine(path,"name.json"));
            if (!namessFromJson.Contains(name))
            {
                namessFromJson.Add(name);
            Helper.SaveAsJson(namessFromJson, Path.Combine(path,"name.json"));
            }
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
            Helper.SaveAsJson(namessFromJson, Path.Combine(path, "name.json"));
            }
            else
            {
                Console.WriteLine("Indexi duzgun daxil edin");
            }
        }
        static void Delete(int index)
        {
            List<string> namessFromJson = Helper.JsonToObject<List<string>>(Path.Combine(path, "name.json"));
            if (namessFromJson.Count > index && index >= 0)
            {
                namessFromJson.Remove(namessFromJson[index]);
            Helper.SaveAsJson(namessFromJson, Path.Combine(path, "name.json"));
            }
            else
            {
                Console.WriteLine("Indexi duzgun daxil edin");
            }
        }
    }
}