using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TaskPlanner.Data.Enums;

namespace TaskPlanner.Data.Models
{
    /// <summary>
    /// Задача.
    /// </summary>
    public class TaskModel
    {
        /// <summary>
        /// Идентификатор задачи.
        /// </summary>
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Заголовок задачи.
        /// </summary>
        [Required]
        [StringLength(128)]
        public string Header { get; set; }

        /// <summary>
        /// Дата до которой должна быть выполнена задачи.
        /// </summary>
        public DateTime? ExecutionDate { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        [Required]
        [StringLength(1024)]
        public string Description { get; set; }

        /// <summary>
        /// Состояние задачи.
        /// </summary>
        [Required]
        public TaskState State { get; set; } 

        /// <summary>
        /// Приоритет задачи.
        /// </summary>
        [Required]
        public TaskPriority Priority { get; set; }

    }
}
