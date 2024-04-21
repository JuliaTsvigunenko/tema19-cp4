using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Базовый класс для пропусков
    public abstract class Passes
    {

        /// <summary>
        /// Св-ва Фамилия
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Св-ва Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Св-ва Отчество
        /// </summary>
        public string Patronymic { get; set; }
        /// <summary>
        ///  Св-ва Факультет
        /// </summary>
        public string Faculty { get; set; }

        /// <summary>
        /// Абстрактный метод для обновления пропуска или его аннулирования
        /// </summary>
        public abstract void APasses();






    }
}
