using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Класс Туристическая фирма
    class TourOperator
    {

        //Задание 1

        //1. Описать класс «Туристическая фирма».
        //Поля класса: название, год создания, ИНН, прибыль за текущий год.
        //Методы класса: инициализация полей, получение информации о фирме.

        /// <summary>
        /// поле название
        /// </summary>
        private string name;

        /// <summary>
        /// поле год создания
        /// </summary>
        private int year;

        /// <summary>
        /// поле ИНН
        /// </summary>
        private string inn;

        /// <summary>
        /// поле прибыль за текущий год
        /// </summary>
        private double profit;

        /// <summary>
        /// св-ва название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///  св-ва год создания
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// св-ва ИНН
        /// </summary>
        public string Inn { get; set; }

        /// <summary>
        ///  св-ва прибыль за текущий год
        /// </summary>
        public double Profit { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public TourOperator() { }

        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="year"></param>
        /// <param name="inn"></param>
        /// <param name="profit"></param>
        public TourOperator(string name, int year, string inn, double profit)
        {
            this.Name = name;
            this.Year = year;
            this.Inn = inn;
            this.Profit = profit;
        }

        /// <summary>
        /// Метод для вывода информации
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"Название: {Name}\nГод создания: {Year}\nИНН: {Inn}\nПрибыль за текущий год: {Profit}");
        }

        
        
                                        




    }
}
