namespace Model
{
    /// <summary>
    /// ����� ��� ������ ������
    /// </summary>
    public class PersonList
    {
        //TODO: RSDN +
        /// <summary>
        /// ������ ������
        /// </summary>
        private List<Person> people;

        /// <summary>
        /// ����� ��� ���������� ������
        /// </summary>
        public PersonList()
        {
            people = new List<Person>();
        }

        /// <summary>
        /// ����� ��� ���������� ��������
        /// </summary>
        public void Add(Person person)
        {
            people.Add(person);
        }

        /// <summary>
        /// ����� ��� �������� ��������
        /// </summary>
        /// <returns> ���������, ��� ����� ��������</returns>
        public bool Remove(Person person)
        {
            return people.Remove(person);
        }

        /// <summary>
        /// ����� ��� �������� �������� �� �������
        /// </summary>
        /// <returns> ��������� false, ���� ������ ��� ���������
        ///           true, ���� ������� ������</returns>
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
        /// ����� ��� ������ �������� �� �������
        /// </summary>
        /// <returns> ��������� false, ���� ������ ��� ���������
        ///           true, ���� ������ ������ �������</returns>
        public Person Get(int index)
        {
            if (index < 0 || index >= people.Count)
            {
               throw new ArgumentOutOfRangeException("������ ��� ���������");
            }

            return people[index];
        }

        /// <summary>
        /// ����� ��� ��������� ������� ��������
        /// </summary>
        /// <returns> ��������� ������ </returns>
        public int IndexOf(Person person)
        {
            return people.IndexOf(person);
        }

        /// <summary>
        /// ����� ��� ������� ������
        /// </summary>
        /// <returns> ��������� ��������� ������ </returns>
        public void Clear()
        {
            people.Clear();
        }

        /// <summary>
        /// ����� ��� ��������� ���������� ���������
        /// </summary>
        /// <returns> ��������� ���������� ������ </returns>
        public int Count()
        {
            return people.Count;
        }

        /// <summary>
        /// ����� ��� ��������� ���������� ���������
        /// </summary>
        public void Print()
        {
            Console.WriteLine ($"���: {Name}, �������: {Surname}, �������: {Age}, ���: {Sex}");
        }
    }
}