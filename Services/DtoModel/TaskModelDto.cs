using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskPlanner.Services.DtoModel
{
    /// <summary>
    /// Задача.
    /// </summary>
    public class TaskModelDto
    {
        /// <summary>
        /// Идентификатор задачи.
        /// </summary>
        [Required(ErrorMessage = ValidationErrors.Required)]
        public Guid Id { get; set; }

        /// <summary>
        /// Заголовок задачи.
        /// </summary>
        [Required(ErrorMessage = ValidationErrors.Required)]
        [StringLength(128, ErrorMessage = ValidationErrors.StringLength)]
        [Display(Name = Names.Header)]
        public string Header { get; set; }

        /// <summary>
        /// Дата до которой должна быть выполнена задачи.
        /// </summary>
        [Display(Name = Names.ExecutionDate)]
        public DateTime? ExecutionDate { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        [Required(ErrorMessage = ValidationErrors.Required)]
        [StringLength(1024, ErrorMessage = ValidationErrors.StringLength)]
        [Display(Name = Names.Description)]
        public string Description { get; set; }

        /// <summary>
        /// Состояние задачи.
        /// Перечисление:
        /// "NotAssigned" - Не назначена
        /// "InWork" - В работе
        /// "Completed" - Завершена
        /// "Cancelled" - Отменена
        /// </summary>
        [Required(ErrorMessage = ValidationErrors.Required)]
        [Display(Name = Names.State)]
        public string State { get; set; }

        /// <summary>
        /// Приоритет задачи.
        /// Перечисление:
        /// "Important" - Важная
        /// "Average" - Средняя
        /// "Unimportant" - Неважная
        /// </summary>
        [Required(ErrorMessage = ValidationErrors.Required)]
        [Display(Name = Names.Priority)]
        public string Priority { get; set; }
    }
}
