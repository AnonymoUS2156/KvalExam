using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    //Грибков Никита 31 ИС
    public class Apartment
    {
        public int Number { get; set; } //поле Номер
        public string Owner { get; set; } //поле Владелец

        private List<Room> Rooms = new List<Room>(); // список Комнат

        public void AddApps(Room rooms) // метод добавления комнат 
        {
            Rooms.Add(rooms);// добавление комнат
        }
        public void ShowAll()// показать все
        {
            Rooms.Sort(); //сортировка по первым значениям
            foreach (Room room in Rooms)//для каждой комнате в списке...
                room.Show();//вывести значение и площадь
        }
    }
    public class Room : IComparable<Room> //Класс комнаты вместе с интерфейсом сравнения CompareTo() (интерфейс сделан внутри класса для уменьшения затрат времени)
    {
        public string Name { get; set; } //поле Название
        public int Area { get; set; }// поле Площадь
        public int CompareTo(Room other) //метод сравнения 
        {
            if (Name.CompareTo(other.Name) != 0) //Если буква в названии 
                return Name.CompareTo(other.Name);//вывести первое попавшееся
            else //или
                return Area.CompareTo(other.Area);//вернуть значения сравнения с площадью
        }
        public void Show()//вывести
        {
            Console.WriteLine("Назначение: {0}, Площадь: {1}", Name, Area);//выводится это
        }


    }
}
