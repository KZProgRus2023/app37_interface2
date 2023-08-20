/* Created by SharpDevelop.
* User: user
* Date: 07.12.2012
* Time: 15:55
*
* To change this template use Tools | Options | Coding |
* Edit Standard Headers. */
using System;
namespace app37_interface2
{
    public interface IPrice
    {
        double Price();
    }
    public interface ICar
    {
        int Speed { get; set; }
        void GetInfo();
    }
    public class Ferrari : ICar, IPrice
    {
        private int spd; // скорость (поле)
        public int Speed // скорость (свойство)
        {
            get { return spd; }
208 Часть II. Объектно-ориентированное программирование
        set { spd = value; }
        }
        // Конкретная реализация интерфейса в классе:
        public void GetInfo()
        {
            Speed = 250;
            Console.WriteLine("Это суперкар Ferrari " +
            "с макс. скоростью {0}", Speed);
        }
        // Конкретная реализация интерфейса в классе:
        public double Price()
        {
            return 20000;
        }
    }
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Подключение к классу более " +
            "одного интерфейса");
            Ferrari fr = new Ferrari();
            fr.GetInfo();
            Console.WriteLine("Цена автомобиля — {0}",
            fr.Price());
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
