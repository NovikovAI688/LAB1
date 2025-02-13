using System;

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
        private List<Person> _people;

        /// <summary>
        /// ����� ��� ���������� ������
        /// </summary>
        public List<Person> ListPerson { get; } = new List<Person>();   

        /// <summary>
        /// ����� ��� ���������� ��������
        /// </summary>
        public void Add(Person person)
        {
            ListPerson.Add(person);
        }

        /// <summary>
        /// ����� ��� �������� ��������
        /// </summary>
        /// <returns> ���������, ��� ����� ��������</returns>
        public bool Remove(Person person)
        {
            return ListPerson.Remove(person);
        }

        /// <summary>
        /// ����� ��� �������� �������� �� �������
        /// </summary>
        /// <returns> ��������� false, ���� ������ ��� ���������
        ///           true, ���� ������� ������</returns>
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
        /// ����� ��� ������ �������� �� �������
        /// </summary>
        /// <returns> ��������� false, ���� ������ ��� ���������
        ///           true, ���� ������ ������ �������</returns>
        public Person Get(int index)
        {
            if (index < 0 || index >= ListPerson.Count)
            {
               throw new ArgumentOutOfRangeException("������ ��� ���������");
            }

            return ListPerson[index];
        }

        /// <summary>
        /// ����� ��� ��������� ������� ��������
        /// </summary>
        /// <returns> ��������� ������ </returns>
        public int IndexOf(Person person)
        {
            return ListPerson.IndexOf(person);
        }

        /// <summary>
        /// ����� ��� ������� ������
        /// </summary>
        /// <returns> ��������� ��������� ������ </returns>
        public void Clear()
        {
            ListPerson.Clear();
        }

        /// <summary>
        /// ����� ��� ��������� ���������� ���������
        /// </summary>
        /// <returns> ��������� ���������� ������ </returns>
        public int Count()
        {
            return ListPerson.Count;
        }

        /// <summary>
        /// ����� ��� ��������� ���������� ���������
        /// </summary>
        public void Print()
        {
            foreach (Person onePerson in ListPerson)
            {
                Console.WriteLine(onePerson.ToString());
            }
        }
    }
}