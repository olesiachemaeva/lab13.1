using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Введите адрес здания: ");
            string a = Console.ReadLine();
            //Console.WriteLine("Введите длина здания: ");
            double l = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("Введите ширина здания: ");
            double h = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите высота здания: ");
            double w = Convert.ToInt32(Console.ReadLine());

            Building building = new Building(a, l, h, w);
        }

    }
    class Building
    {
        //public struct Building

        public string BuildingAddressBuilding { get; set; }
        public double lengthBuilding { get; set; }
        public double Width { get; set; }
        public double BuildingHeight { get; set; }
        public Building(string a, double l, double h, double w)
        {
            BuildingAddressBuilding = a;
            lengthBuilding = l;
            Width = w;
            BuildingHeight = h;
        }
        public void Print()
        {
            Console.WriteLine("Значение элементов = {0} {1} {2} {3}", BuildingAddressBuilding, lengthBuilding, Width, BuildingHeight);
        }

        
    }

    sealed class MultiBuilding : Building
    {
       
        public int Floor { get; set; }
        public MultiBuilding(string a, double l, double h, double w, int f)
            
           :base(a, l,h, w)
        {
                        Floor = f;
        }
               
               // 6. Виртуальный метод, который выводит значение полей класса
        public  void Print()
        {
            base.Print();
            Console.WriteLine("Этажи = {f} ", Floor);
        }
    }
}



       
    

    


