using System;
using System.Collections.Generic;
using LojaVirtualHx.Entities;
using LojaVirtualHx.Helpers;

namespace LojaVirtualHx
{
    class Program
    {
        static void Main(string[] args)
        {
            Dashboard.Inicio();
        }


        public static void Initialize()
        {
            Console.Clear();
            Console.Title = "Loja virtual";
        }
    }
}
