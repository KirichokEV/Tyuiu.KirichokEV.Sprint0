using Tyuiu.KirichokEV.Sprint0.Task6.V0.Lib;

namespace Tyuiu.KirichokEV.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            //Пример циклической структуры находится в библиотеки классов методе AdditioarrayArray
            Console.WriteLine(" Сумма элементо массива = " + DataService.AdditionArray(numsArray));

            //Пример циклической структуры находится в библиотеки классов методе SubtractionArray
            Console.WriteLine(" Разность элементо массива = " + DataService.SubtractionArray(numsArray));

            //Пример циклической структуры находится в библиотеки классов методе MultiplicationArray
            Console.WriteLine(" Произведение элементо массива = " + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}
