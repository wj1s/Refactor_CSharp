namespace refactor7
{
    public class Person
    {
        private readonly string name;
        private readonly string officeAreaCode;
        private readonly string officeNumber;
        private readonly Department department;

        public Person(string name, string officeAreaCode, string officeNumber)
        {
            this.name = name;
            this.officeAreaCode = officeAreaCode;
            this.officeNumber = officeNumber;
        }

        public Person(string name, string officeAreaCode, string officeNumber, Department department)
        {
            this.name = name;
            this.officeAreaCode = officeAreaCode;
            this.officeNumber = officeNumber;
            this.department = department;
        }

        public Department GetDepartment()
        {
            return department;
        }

        private string GetTelephoneNumber()
        {
            return "(" + officeAreaCode + ") " + officeNumber;
        }

        public override string ToString()
        {
            return name + GetTelephoneNumber();
        }
    }
}