using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TourPackage
    {

        /// <summary>
        /// Название тура
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Страна или город назначения
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Продолжительность в днях
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Цена тура
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Туроператор, предлагающий данный тур
        /// </summary>
        public TourOperator Operator { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public TourPackage(string title, string destination, int duration, double price, TourOperator op)
        {
            Title = title;
            Destination = destination;
            Duration = duration;
            Price = price;
            Operator = op;
        }

        /// <summary>
        /// Метод для отображения информации о туре
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"Тур: {Title}\nНаправление: {Destination}\nПродолжительность: {Duration} дней\nЦена: {Price} руб.\nОрганизатор: {Operator.Name}\n");
        }
        


    }
}
