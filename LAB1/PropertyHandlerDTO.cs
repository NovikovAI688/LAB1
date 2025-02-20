﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class PropertyHandlerDTO
    {
        /// <summary>
        /// Делегат для выполнения ввода атрибутов
        /// </summary>
        public Action PropertyHandlingAction { get; }

        /// <summary>
        /// Список исключений атрибутов
        /// </summary>
        public List<Type> ExceptionTypes { get; }

        /// <summary>
        /// Значение атрибута
        /// </summary>
        public string PropertyName { get; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="properyName">Значение атрибута</param>
        /// <param name="exceptionTypes">Список исключений атрибутов</param>
        /// <param name="propertyHandlingAction"> Делегат для выполнения ввода атрибутов</param>
        public PropertyHandlerDTO(string properyName, List<Type> exceptionTypes, Action propertyHandlingAction)
        {
            PropertyName = properyName;
            PropertyHandlingAction = propertyHandlingAction;
            ExceptionTypes = exceptionTypes;
        }
    }
}

