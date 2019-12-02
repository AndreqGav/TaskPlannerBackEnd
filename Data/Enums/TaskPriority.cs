using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskPlanner.Data.Enums
{
    /// <summary>
    /// Переичсление приоритетов задачи.
    /// </summary>
    public enum TaskPriority
    {
        /// <summary>
        /// Важная.
        /// </summary>
        Important,
        /// <summary>
        /// Средняя.
        /// </summary>
        Average,
        /// <summary>
        /// Неважная.
        /// </summary>
        Unimportant
    }
}
