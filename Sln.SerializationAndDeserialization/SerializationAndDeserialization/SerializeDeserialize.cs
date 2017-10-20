using SerializationAndDeserialization.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationAndDeserialization
{
    public static class SerializeDeserialize
    {
        public static void DoSerialization()
        {
            Employee _Employee = new Employee
            {
                FirstName = "R M Shahidul Islam",
                LastName = "Shahed",
                PhoneNo = "123456789",
                DateOfBirth = DateTime.Today,
                Department = "ICT",
                MonthlySalary = Convert.ToInt32(505),
                Capital = "Dahak",
                Country = "Bangladesh",
                AdditionalInfo = "Restrict from serialize"
            };


            BinaryFormatter _BinaryFormatter = new BinaryFormatter();
            FileStream _FileStream = new FileStream("Employee.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (_FileStream)
                {
                    _BinaryFormatter.Serialize(_FileStream, _Employee);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


        public static void DoDeSerialization()
        {
            Employee _Employee = new Employee();
            List<string> list = new List<string>();

            BinaryFormatter _BinaryFormatter = new BinaryFormatter();
            FileStream _FileStream = new FileStream("Employee.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (_FileStream)
                {
                    _Employee = (Employee)_BinaryFormatter.Deserialize(_FileStream);

                    list.Add(_Employee.FirstName);
                    list.Add(_Employee.LastName);
                    list.Add(_Employee.PhoneNo);
                    list.Add(_Employee.DateOfBirth.ToString());
                    list.Add(_Employee.Department);
                    list.Add(_Employee.MonthlySalary.ToString());
                    list.Add(_Employee.Capital);
                    list.Add(_Employee.Country);
                    list.Add(_Employee.AdditionalInfo);
                }

                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }
}
