﻿using Tyuiu.KirichokEV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KirichokEV.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataService и метода GetMessage
            //из библиотеки Tyuiu.KirichokEV.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Елизавета"));
            Console.ReadKey();
            
        }
    }
}
