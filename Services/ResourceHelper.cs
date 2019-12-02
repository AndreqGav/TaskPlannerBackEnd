using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskPlanner.Services
{
    public class ValidationErrors
    {
        public const string Required = "RequiredAttribute_ValidationError";
        public const string MaxLength = "MaxLengthAttribute_ValidationError";
        public const string MinLength = "MinLengthAttribute_ValidationError";
        public const string Range = "RangeAttribute_ValidationError";
        public const string Regex = "RegexAttribute_ValidationError";
        public const string StringLength = "StringLengthAttribute_ValidationError";
        public const string StringLengthIncludingMinimum = "StringLengthAttribute_ValidationErrorIncludingMinimum";

    }

    public class Names
    {
        /// <summary>
        /// Наименование.
        /// </summary>
        public const string Name = "Name";

        /// <summary>
        /// Заголовок.
        /// </summary>
        public const string Header = "Header";

        /// <summary>
        /// Дата выполнения.
        /// </summary>
        public const string ExecutionDate = "ExecutionDate";

        /// <summary>
        /// Описание.
        /// </summary>
        public const string Description = "Description";

        /// <summary>
        /// Состояние.
        /// </summary>
        public const string State = "State";

        /// <summary>
        /// Приоритет.
        /// </summary>
        public const string Priority = "Priority";
    }
}
