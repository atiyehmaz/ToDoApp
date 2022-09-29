
namespace ToDoApp.Data
{
    public class PersonSequencer
    {
        private static int _personId;

        public static int NextPersonId()
        {
            return _personId++;
        }
        public static void Reset()
        {
            _personId = 0;
        }
    }
}
