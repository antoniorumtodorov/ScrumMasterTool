using System;
using System.Collections.Generic;

namespace ObjectConverterJson
{
    public class Member
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
    class ConvertObject
    {
        static void Main(string[] args)
        {

            var list = new List<Member>()
            {
                new Member{Name = "Pesho", Email="pesho@gmail.com"},
                new Member{Name="Antonio", Email="antonio@gmail.com"}
            };

            string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(list);
            Console.WriteLine(jsonString);
        }
    }
}
