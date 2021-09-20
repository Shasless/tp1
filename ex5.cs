using System;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApplication1
{
    public class ex5
    {
        public static void ex5_1()
        {
            using (StreamReader r = new StreamReader("DOGE_AllDataPoints_3Days.json"))
            {
                string json = r.ReadToEnd();
                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(json); 
                Console.WriteLine("On recupere par exemple le prix dans les datas {0}",myDeserializedClass.data[0].price);
               


            }
        }
    }
}