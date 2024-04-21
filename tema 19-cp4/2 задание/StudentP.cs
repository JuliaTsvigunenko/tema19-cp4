using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Класс для пропуска студента
    class StudentP : Passes
    {
        /// <summary>
        /// Св-ва Год поступления студенста
        /// </summary>
        public int StudentAdmissions { get; set; }

        /// <summary>
        /// Реализация метода для аннулирования пропуска студента
        /// </summary>
        public override void APasses()
        {
            Console.WriteLine($"Пропуск студента {Surname}\n{Name}\n{Patronymic} аннулирован.");
        }
    }





}
}
