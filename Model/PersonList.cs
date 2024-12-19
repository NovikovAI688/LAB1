using Model;

namespace Model
{
    //TODO: rewrite
    public class PersonList
    {
        //TODO: RSDN
        private List<Person> people;

        public PersonList()
        {
            people = new List<Person>();
        }

        // Метод для добавления элемента
        public void Add(Person person)
        {
            people.Add(person);
        }

        // Метод для удаления элемента
        public bool Remove(Person person)
        {
            return people.Remove(person);
        }

        // Метод для удаления элемента по индексу
        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= people.Count)
            {
                return false; // Возвращаем false, если индекс вне диапазона
            }

            people.RemoveAt(index);
            return true; // Успешно удален
        }

        // Метод для поиска элемента по индексу
        public Person Get(int index)
        {
            if (index < 0 || index >= people.Count)
            {
               throw new ArgumentOutOfRangeException("Индекс вне диапазона");
            }

            return people[index];
        }

        // Метод для получения индекса элемента
        public int IndexOf(Person person)
        {
            return people.IndexOf(person);
        }

        // Метод для очистки списка
        public void Clear()
        {
            people.Clear();
        }

        // Метод для получения количества элементов
        public int Count()
        {
            return people.Count;
        }
        public void Print()
        {
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}