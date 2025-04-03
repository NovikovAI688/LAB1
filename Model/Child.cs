using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Child : PersonBase
    {
        public List<Adult> Parents { get; set; }
        public string School { get; set; }

        public Child(string Name, string Surname, int Age, Sex sex, List<Adult> parents, string school)
           : base(Name, Surname, Age, sex)
        {
            Parents = parents;
            School = school;
        }
        public override string GetPersonInfo()
        {
            string parentInfo;

            if (Parents.Count == 0)
            {
                parentInfo = "No parents listed";
            }
            else
            {
                parentInfo = "Parents: " +
                    string.Join(", ", Parents.ConvertAll(parent => parent.Name));
            }
            return $"{base.Name} {base.Age}, {base.Age}, {base.Sex}," +
                   $" Parents: {parentInfo}, School: {School}";
        }
    }

}
