using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary3;

namespace KvalExamGribkov
{
    //Грибков Никита 31 ИС
    internal class Program
    { 
        static void Main(string[] args)
        {
            Apartment apartment = new Apartment();//реализация класса
            apartment.Number = 28; //кол-во номеров в апартаментах
            apartment.Owner = "ОАО МосГорСтрой"; //владелеца апартаментов

            


            Room[] rooms = new Room[] //списов имеющихся комнат с характеристиками
            {
                new Room { Name = "4х комнатная", Area = 54}, //характеристики комнат
                new Room { Name = "3х комнатная", Area = 36 },
                new Room { Name = "1 комнатная", Area = 24 },
                new Room { Name = "2х комнатная", Area = 32 },
            };

            foreach (Room room in rooms)
                apartment.AddApps(room);//"переборка и вывод списка в консоль"

            Console.WriteLine("Владелец: {0}, кол-во комнат: {1}",apartment.Owner , apartment.Number); //Вывод 
            apartment.ShowAll();//вывод всех характеристик
            Console.ReadKey();//ожидать нажатия кнопки
        }
    }
}
