using System.Globalization;

namespace ClassesAndObjectsTask
{
    public class Employee
    {
        private string surname;
        private int age;

        public Employee()
        {
        }

        public Employee(string surname, int age)
        {
            this.surname = surname;
            this.age = age;
        }

        public void SetSurname(string surname)
        {
            this.surname = surname;
        }

        public string GetEmployeeInfo()
        {
            return $"Surname: {this.surname}, Age: {this.age}";
        }

        private string GetAge()
        {
            return this.age.ToString(CultureInfo.InvariantCulture);
        }
    }
}
