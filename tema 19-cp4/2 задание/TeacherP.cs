using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Класс для пропуска преподавателя
    class TeacherP : Passes
    {

        /// <summary>
        /// Св-ва Кафедра
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// Реализация метода для обновления пропуска преподавателя
        /// </summary>
        public override void APasses()
        {
            Console.WriteLine($"Пропуск преподавателя {Surname}\n{ Name}\n{Patronymic} обновлен.");
        }





    }
}
