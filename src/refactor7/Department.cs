namespace refactor7
{
    public class Department
    {
        private readonly Person manager;

        public Department(Person manager)
        {
            this.manager = manager;
        }

        public Person GetManager()
        {
            return manager;
        }
    }
}