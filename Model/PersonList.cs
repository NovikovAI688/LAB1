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

        // ����� ��� ���������� ��������
        public void Add(Person person)
        {
            people.Add(person);
        }

        // ����� ��� �������� ��������
        public bool Remove(Person person)
        {
            return people.Remove(person);
        }

        // ����� ��� �������� �������� �� �������
        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= people.Count)
            {
                return false; // ���������� false, ���� ������ ��� ���������
            }

            people.RemoveAt(index);
            return true; // ������� ������
        }

        // ����� ��� ������ �������� �� �������
        public Person Get(int index)
        {
            if (index < 0 || index >= people.Count)
            {
               throw new ArgumentOutOfRangeException("������ ��� ���������");
            }

            return people[index];
        }

        // ����� ��� ��������� ������� ��������
        public int IndexOf(Person person)
        {
            return people.IndexOf(person);
        }

        // ����� ��� ������� ������
        public void Clear()
        {
            people.Clear();
        }

        // ����� ��� ��������� ���������� ���������
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