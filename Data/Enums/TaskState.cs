using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskPlanner.Data.Enums
{
    /// <summary>
    /// Перечисление состояний задачи.
    /// </summary>
    public enum TaskState
    {
        /// <summary>
        /// Не назначена.
        /// </summary>
        NotAssigned,
        /// <summary>
        /// В работе.
        /// </summary>
        InWork,
        /// <summary>
        /// Завершена.
        /// </summary>
        Completed,
        /// <summary>
        /// Отменена.
        /// </summary>
        Cancelled
    }
}
