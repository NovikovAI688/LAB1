using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Класс ElementBaseUserControl.
    /// </summary>
    public abstract partial class ElementBaseUserControl : UserControl
    {
        /// <summary>
        /// Абстрактный метод для получения элемента.
        /// </summary>
        /// <returns>Элемент.</returns>
        public abstract PassiveElementBase GetElement();

        //TODO: encapsulation +
        /// <summary>
        /// Параметры для ввода.
        /// </summary>
        /// <param name="actions">Список действий.</param>
        protected void InputParameters(List<Action> actions)
        {
            foreach (var action in actions)
            {
                action.Invoke();
            }
        }
    }
}
