using System;

namespace ConsoleApplication1
{
    // Создадим структуру     
    struct CarInfo
    {
        public string Brand;         
        public string Model;
        public CarInfo(string Brand, string Model)
        {
            this.Brand = Brand;             
            this.Model = Model;         
        }         
        public void GetCarInfo() {
            Console.WriteLine("Бренд: {0}, Модель: {1}",Brand, Model);
        }
    }
    class Program
    {
        static void Main()
        {
            CarInfo a = new CarInfo("Audi", "A6");
            CarInfo car2 = new CarInfo("BMW", "X5");
            Console.Write("car 1: ");            
            a.GetCarInfo();
            Console.Write("car 2: ");            
            car2.GetCarInfo();             
            a = car2;             
            car2.Brand = "Toyota";
            car2.Model = "Camry";            
            Console.Write("car1: ");             
            a.GetCarInfo();
            Console.Write("car2: ");             
            car2.GetCarInfo();
            Console.ReadLine();
        }
    }
}