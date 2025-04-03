using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Adult: PersonBase
    {
        public string PassportData { get; set; }
        public string FamilyStatus { get; set; }
        public Adult Partner { get; set; }
        public string WorkPlace { get; set;}
        public Adult(string Name, string Surname, int Age, Sex sex,
            string PassportData, string FamilyStatus,
            Adult Partner, string WorkPlace)
            : base(Name, Surname, Age, sex)
        {
            PassportData = passportData;
            FamilyStatus = familyStatus;
            Partner = partner;
            WorkPlace = workplace;
        }

        public override string GetPersonInfo()
        {
            string partnerInfo = Partner != null 
                ? $"Married to: {Partner.Name}" 
                : "Not married";
            string workplaceInfo = !string.IsNullOrEmpty(WorkPlace)
                ? WorkPlace 
                : "Unemployed";
            return $"{base.Name}, Age: {base.Age}, Passport Data: {PassportData}, " +
                   $"{partnerInfo}, Workplace: {workplaceInfo}";
        }
    }

}
