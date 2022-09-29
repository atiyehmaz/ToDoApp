using ToDoApp.Models;

namespace ToDoApp.Data
{
    public class PeopleService
    {
        private static Person[] _personArray = new Person[0];

        public int Size()
        {
            return _personArray.Length;
        }

        public Person[] FindAll()
        {
            return _personArray;
        }

        public Person FindById(int personId)
        {
            if (_personArray == null)
            {
                return null;
            }

            var person= _personArray.FirstOrDefault(x => x.Id == personId);

            return person;
        }

        public void AddPerson(string firstName, string lastName)
        {
            Person newPerson = new Person(PersonSequencer.NextPersonId(), firstName, lastName);

            _personArray = _personArray.Append(newPerson).ToArray();
        }

        public void Clear()
        {
            _personArray = new Person[0];
        }

    }
}
