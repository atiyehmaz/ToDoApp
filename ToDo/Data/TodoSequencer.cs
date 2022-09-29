
namespace ToDoApp.Data
{
   public class TodoSequencer
    {
        private static int _toDoId;

        public static int NextTodoId()
        {
            return _toDoId; 
        }

        public static void Reset()
        {
            _toDoId = 0;
        }
    }
}
