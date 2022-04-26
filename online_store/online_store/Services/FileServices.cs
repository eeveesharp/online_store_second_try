using Newtonsoft.Json;
using online_store.Interfaces;
using online_store.Models;
using online_store.Storage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace online_store.Services
{
    static class FileServices<T> //: IFileServices
    {
        public static List<T> ReadFile(List<T> items, string fileName)
        {            
            items = JsonConvert.DeserializeObject<List<T>>(ReadTextFromFile(fileName));

            return items;
        }

        public static void WriteFile(IEnumerable<object> items, string fileName)
        {
            using (FileStream fstream = new FileStream(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName +
               $"\\jsonFiles\\{fileName}.json",
               FileMode.Create))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(JsonConvert.SerializeObject(items));

                fstream.Write(array, 0, array.Length);
            }             
        }

        public static string ReadTextFromFile(string filename)
        {
            string fileContent = string.Empty;

            try
            {
                using (FileStream fstream = System.IO.File.OpenRead(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName +
                    $"\\jsonFiles\\{filename}.json"))
                {
                    byte[] array = new byte[fstream.Length];

                    fstream.Read(array, 0, array.Length);

                    fileContent = System.Text.Encoding.Default.GetString(array);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            return fileContent;
        }
    }
}
