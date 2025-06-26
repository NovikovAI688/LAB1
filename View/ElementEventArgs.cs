using Model;

namespace View
{
    /// <summary>
    /// Класс ElementEventArgs.
    /// </summary>
    public class ElementEventArgs : EventArgs
    {
        /// <summary>
        /// Элемент.
        /// </summary>
        public PassiveElementBase PassiveElement { get; private set; }

        /// <summary>
        /// Конструктор события.
        /// </summary>
        /// <param name="passiveElement">Элемент.</param>
        public ElementEventArgs(PassiveElementBase passiveElement)
        {
            PassiveElement = passiveElement;
        }
    }
}
