using Newtonsoft.Json;
using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var result = JsonConvert.SerializeObject(new { Id = 1, Name = "小明" });
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
