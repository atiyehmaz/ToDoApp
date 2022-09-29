

namespace ToDoApp.Models
{
    public class Person
    {
        private readonly int _id;
        private string _firstName;
        private string _lastName;
        //private object v;

        public Person(int id, string firstName, string lastName)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
        }

        public int Id { get { return _id; } }

        public string FirstName
        {
            get { return _firstName; } //getters
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Noooo you can not leave me empty i need first name (:");
                }
                else
                {
                    _firstName = value;
                }
            }
        }

        public string LastName
        {

            get { return _lastName; } //getters
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last Name can not be null or empty");
                }
                else
                {
                    _lastName = value;
                }

            }
        }  // setters


    }
}
