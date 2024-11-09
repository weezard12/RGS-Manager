using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RGS_Manager_2.Main
{
    internal class Program
    {
        public const string AppName = "RGS Manager v2";
        static void Main(string[] args)
        {
            SetupApp();

            Console.ReadKey();
        }
        private static void SetupApp()
        {
            Console.Title = AppName;
            Console.Clear();
            Console.WriteLine("Welcome to RGS v2.");
            Console.WriteLine("Starting...");


        }
    }
}