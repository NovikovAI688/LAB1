using System;

namespace Model
{
    /// <summary>
    /// Метод для списка персон
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Метод для добавления списка
        /// </summary>
        public List<PersonBase> ListPerson { get; } = new List<PersonBase>();   

        /// <summary>
        /// Метод для добавления элемента
        /// </summary>
        public void Add(PersonBase person)
        {
            ListPerson.Add(person);
        }

        /// <summary>
        /// Метод для удаления элемента
        /// </summary>
        /// <returns> Вовращает, без этого элемента</returns>
        public bool Remove(PersonBase person)
        {
            return ListPerson.Remove(person);
        }

        /// <summary>
        /// Метод для удаления элемента по индексу
        /// </summary>
        /// <returns> Вовращает false, если индекс вне диапазона
        ///           true, если успешно удален</returns>
        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= ListPerson.Count)
            {
                return false; 
            }

            ListPerson.RemoveAt(index);
            return true; 
        }

        /// <summary>
        /// Метод для поиска элемента по индексу
        /// </summary>
        /// <returns> Вовращает false, если индекс вне диапазона
        ///           true, если найден индекс персоны</returns>
        public PersonBase Get(int index)
        {
            if (index < 0 || index >= ListPerson.Count)
            {
               throw new ArgumentOutOfRangeException("Индекс вне диапазона");
            }

            return ListPerson[index];
        }

        /// <summary>
        /// Метод для получения индекса элемента
        /// </summary>
        /// <returns> Вовращает индекс </returns>
        public int IndexOf(PersonBase person)
        {
            return ListPerson.IndexOf(person);
        }

        /// <summary>
        /// Метод для очистки списка
        /// </summary>
        /// <returns> Вовращает очищенный список </returns>
        public void Clear()
        {
            ListPerson.Clear();
        }

        /// <summary>
        /// Метод для получения количества элементов
        /// </summary>
        /// <returns> Вовращает количесвто персон </returns>
        public int Count()
        {
            return ListPerson.Count;
        }

        /// <summary>
        /// Метод для получения количества элементов
        /// </summary>
        public void Print()
        {
            foreach (PersonBase onePerson in ListPerson)
            {
                Console.WriteLine(onePerson.ToString());
            }
        }
    }
}