using Tyuiu.KirichokEV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KirichokEV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            //Область создания методов тесрирования, методов из библиотеки 
            var name = "Елизавета";
            var res = DataService.GetMessage(name);

            //Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Елизавета", res);
        }
    }
}