using ToDoApp.Models;

namespace ToDoApp.Data
{
    public class TodoService
    {
        private static ToDo[] _toDoArray = new ToDo[0];

        public int Size()
        {
            return _toDoArray.Length;
        }

        public ToDo[] FindAll()
        {
            return _toDoArray;
        }

        public ToDo FindById(int toDoId)
        {
            if (toDoId == null)
            {
                return null;
            }

            var toDo = _toDoArray.FirstOrDefault(x => x.Id == toDoId);

            return toDo;
        }

        public void AddToDo(string Description)
        {
            ToDo newToDo = new ToDo(TodoSequencer.NextTodoId(), Description);

            _toDoArray = _toDoArray.Append(newToDo).ToArray();
        }

        public void Clear()
        {
            _toDoArray = new ToDo[0];
        }

        public ToDo[] FindByDoneStatus(bool doneStatus)
        {
            ToDo[] newToDoArray = new ToDo[0];

            for (int i = 0; i < _toDoArray.Length; i++)
            {
                if (_toDoArray[i].Done == doneStatus)
                {
                    newToDoArray.Append(newToDoArray[i]);
                }
            }

            return newToDoArray.ToArray();
        }

        public ToDo[] FindByAssignee(int personId)
        {
            ToDo[] newToDoArray = new ToDo[0];

            for (int i = 0; i < _toDoArray.Length; i++)
            {
                if (_toDoArray[i].Assignee != null && _toDoArray[i].Assignee.Id == personId)
                {
                    newToDoArray.Append(newToDoArray[i]);
                }
            }

            return newToDoArray.ToArray();
        }

        public ToDo[] FindByAssignee(Person assignee)
        {
            ToDo[] toDoList = new ToDo[0];

            for (int i = 0; i < toDoList.Length; i++)
            {
                if (toDoList[i].Assignee == assignee)
                {
                    toDoList.Append(toDoList[i]);
                }
            }
            return (ToDo[])toDoList.ToArray();
        }

        public ToDo[] FindUnassignedTodoItems()
        {
            ToDo[] toDoList = new ToDo[0];

            for (int i = 0; i < toDoList.Length; i++)
            {
                if (toDoList[i].Assignee == null)
                {
                    toDoList.Append(toDoList[i]);
                }
            }
            return (ToDo[])toDoList.ToArray();
        }

        public void removeObjectFromArray() { }
    }

}
