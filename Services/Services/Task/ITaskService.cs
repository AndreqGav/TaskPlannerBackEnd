using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskPlanner.Data.Models;
using TaskPlanner.Services.DtoModel;

namespace TaskPlanner.Services.Services.Task
{
    /// <summary>
    /// Интерфейс сервиса управления задачами.
    /// </summary>
    public interface ITaskService : IBaseService<TaskModel>
    {
        /// <summary>
        /// Добавление задачи.
        /// </summary>
        Task<Guid> AddAsync(TaskModelDto item);

        /// <summary>
        /// Обновление задачи.
        /// </summary>
        ValueTask UpdateAsync(TaskModelDto item);

        /// <summary>
        /// Получение задачи по Id.
        /// </summary>
        /// <param name="id">Идентификатор задачи.</param>
        /// <returns>Данные задачи.</returns>
        Task<TaskModelDto> FindByID(Guid id);

        /// <summary>
        /// Получение всех задач.
        /// </summary>
        /// <returns></returns>
        Task<List<TaskModelDto>> FindAll();

        /// <summary>
        /// Удаление задачи по id.
        /// </summary>
        /// <param name="id">Идентификатор задачи.</param>
        /// <returns><see cref="ValueTask"/>, представляющая асинхрнное выполнение операции.</returns>
        ValueTask DeleteAsync(Guid id);
    }
}
