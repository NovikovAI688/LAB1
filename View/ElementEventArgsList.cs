using Model;
using System.ComponentModel;

namespace View
{
    /// <summary>
    /// Класс ElementEventArgsList.
    /// </summary>
    public class ElementEventArgsList : EventArgs
    {
        /// <summary>
        /// Список отфильтрованных элементов.
        /// </summary>
        public BindingList<PassiveElementBase> ElementListFiltered
               { get; private set; }

        /// <summary>
        /// Конструктор события.
        /// </summary>
        /// <param name="elementListFiltered">Список отфильтрованых элементов.</param>
        public ElementEventArgsList
               (BindingList<PassiveElementBase> elementListFiltered)
        {
            ElementListFiltered = elementListFiltered;
        }
    }
}
