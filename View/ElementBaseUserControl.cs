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
    /// Class ElementBaseUserControl.
    /// </summary>
    public abstract partial class ElementBaseUserControl : UserControl
    {
        /// <summary>
        /// Абстрактный метод для получения элемента.
        /// </summary>
        /// <returns>Элемент.</returns>
        public abstract PassiveElementBase GetElement();

        /// <summary>
        /// Параметры для ввода.
        /// </summary>
        /// <param name="actions">Список действий.</param>
        public void InputParameters(List<Action> actions)
        {
            foreach (var action in actions)
            {
                action.Invoke();
            }
        }
    }
}
