namespace Model
{
    /// <summary>
    /// Метод для списка персон
    /// </summary>
    public class PersonList
    {
        //TODO: RSDN +
        /// <summary>
        /// Список персон
        /// </summary>
        private List<Person> people;

        /// <summary>
        /// Метод для добавления списка
        /// </summary>
        public PersonList()
        {
            people = new List<Person>();
        }

        /// <summary>
        /// Метод для добавления элемента
        /// </summary>
        public void Add(Person person)
        {
            people.Add(person);
        }

        /// <summary>
        /// Метод для удаления элемента
        /// </summary>
        /// <returns> Вовращает, без этого элемента</returns>
        public bool Remove(Person person)
        {
            return people.Remove(person);
        }

        /// <summary>
        /// Метод для удаления элемента по индексу
        /// </summary>
        /// <returns> Вовращает false, если индекс вне диапазона
        ///           true, если успешно удален</returns>
        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= people.Count)
            {
                return false; 
            }

            people.RemoveAt(index);
            return true; 
        }

        /// <summary>
        /// Метод для поиска элемента по индексу
        /// </summary>
        /// <returns> Вовращает false, если индекс вне диапазона
        ///           true, если найден индекс персоны</returns>
        public Person Get(int index)
        {
            if (index < 0 || index >= people.Count)
            {
               throw new ArgumentOutOfRangeException("Индекс вне диапазона");
            }

            return people[index];
        }

        /// <summary>
        /// Метод для получения индекса элемента
        /// </summary>
        /// <returns> Вовращает индекс </returns>
        public int IndexOf(Person person)
        {
            return people.IndexOf(person);
        }

        /// <summary>
        /// Метод для очистки списка
        /// </summary>
        /// <returns> Вовращает очищенный список </returns>
        public void Clear()
        {
            people.Clear();
        }

        /// <summary>
        /// Метод для получения количества элементов
        /// </summary>
        /// <returns> Вовращает количесвто персон </returns>
        public int Count()
        {
            return people.Count;
        }

        /// <summary>
        /// Метод для получения количества элементов
        /// </summary>
        public void Print()
        {
            Console.WriteLine ($"Имя: {Name}, Фамилия: {Surname}, Возраст: {Age}, Пол: {Sex}");
        }
    }
}