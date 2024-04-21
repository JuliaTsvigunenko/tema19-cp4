using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class BuilderP : Passes
    {

        /// <summary>
        /// Св-ва начала работ
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Св-ва конец работ
        /// </summary>
        public DateTime EndDate { get; set; }       

        // Реализация метода для аннулирования пропуска строителя
        public override void APasses()
        {
            Console.WriteLine($"Пропуск строителя {Surname}\n{ Name}\n{Patronymic} аннулирован.");
        }


        





    }
}
