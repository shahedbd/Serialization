using System;

namespace SerializationAndDeserialization.Model
{
    [Serializable]
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
        public int MonthlySalary { get; set; }
        public string Capital { get; set; }
        public string Country { get; set; }

        [NonSerialized]
        public string AdditionalInfo;
    }
}
