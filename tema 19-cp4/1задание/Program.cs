using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задание 1.

            //2. Создать коллекцию объектов класса «Туристическая фирма», содержащую информацию о туристических фирмах города.

            List<TourOperator> tourOperators = new List<TourOperator>();
            tourOperators.Add(new TourOperator("Фирма 1", 2008, "A1", 35000));
            tourOperators.Add(new TourOperator("Фирма 2", 2020, "А1В2", 20999));
            tourOperators.Add(new TourOperator("Фирма 3", 2023, "В231", 21599));
            //tourOperators.Add(new TourOperator("Фирма 4", 2011, "АВ34С", 40500));

            //3. Для заданной фирмы найти ИНН и прибыль за текущий год.

            Console.WriteLine("Введите название фирмы: ");
            string name = Console.ReadLine();
            bool not_find = false;//для проверки. Если ничего не найдено, то выводится что фирмы нет, а если найдена, то ничего не происходит
            for (int i = 0; i < tourOperators.Count; i++)
            {
                if (tourOperators[i].Name == name)
                {

                    Console.WriteLine($"ИНН: {tourOperators[i].Inn}; Прибыль: {tourOperators[i].Profit}");
                    not_find = true;

                }
                if (not_find == false)
                {
                    Console.WriteLine("Фирма не найдена");
                }
            }

            //4. Найти суммарную прибыль всех фирм.
            double totalProfit = 0;
            foreach (var tourOperator in tourOperators)
            {
                totalProfit += tourOperator.Profit;
            }
            Console.WriteLine($"Суммарная прибыль всех фирм: {totalProfit}");

            //5. Выяснить, какая из фирм получила наибольшую прибыль и каков размер этой прибыли.

            double maxProfit = 0; // Переменная для хранения максимальной прибыли
            TourOperator maxProfitFirm = null; // Переменная для хранения информации о фирме с максимальной прибылью

            // Проходимся по каждой фирме в списке
            foreach (var tourOperator in tourOperators)
            {
                // Если прибыль текущей фирмы больше максимальной прибыли
                if (tourOperator.Profit > maxProfit)
                {
                    // Обновляем максимальную прибыль и информацию о фирме
                    maxProfit = tourOperator.Profit;
                    maxProfitFirm = tourOperator;
                }
            }

            // Выводим информацию о фирме с максимальной прибылью
            if (maxProfitFirm != null)
            {
                Console.WriteLine($"Фирма с наибольшей прибылью: {maxProfitFirm.Name}, Прибыль: {maxProfitFirm.Profit}");
            }


            //6. Удалить из коллекции информацию об обанкротившейся фирме
            Console.WriteLine("Введите название обанкротившейся фирмы для удаления: ");
            string bankruptName = Console.ReadLine();

            bool isRemoved = false; // Флаг для отслеживания успешного удаления

            // Проходимся по каждой фирме в списке
            for (int i = 0; i < tourOperators.Count; i++)
            {
                if (tourOperators[i].Name == bankruptName)
                {
                    tourOperators.RemoveAt(i); // Удаляем фирму из списка
                    Console.WriteLine($"Фирма {bankruptName} успешно удалена из списка.");
                    isRemoved = true;
                    break; // Завершаем цикл после удаления
                }
            }

            // Если фирма не найдена
            if (!isRemoved)
            {
                Console.WriteLine($"Фирма {bankruptName} не найдена.");
            }

            //7. Добавить в коллекцию информацию о новой фирме.
            Console.WriteLine("Введите информацию о новой фирме (Название, Год создания, ИНН, Прибыль): ");
            string[] newFirmInfo = Console.ReadLine().Split(',');
            tourOperators.Add(new TourOperator(newFirmInfo[0].Trim(), int.Parse(newFirmInfo[1].Trim()), newFirmInfo[2].Trim(), double.Parse(newFirmInfo[3].Trim())));


            //8. Отсортировать коллекцию по размеру прибыли за текущий год.
            tourOperators = tourOperators.OrderByDescending(t => t.Profit).ToList();

            // Выводим отсортированный список
            Console.WriteLine("Отсортированный список фирм по прибыли:");
            foreach (var tourOperator in tourOperators)
            {
                tourOperator.Show();
            }


            Console.ReadKey();





        }
    }
}
