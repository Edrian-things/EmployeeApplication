//Edrian Badoy
namespace EmployeeNamespace
{
    public class Employee
    {
        private string employeeID;
        private string firstName;
        private string lastName;
        private string position;

        public Employee() { }


        public Employee(String id, String firstName, String lastName, String position)
        {
            this.employeeID = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }

        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }
    }
}

