
namespace ToDoApp.Models
{
    public class ToDo
    {
        private readonly int _id;
        private string _description;
        private bool _done;
        private Person _assignee;

        public ToDo(int id, string description)
        {
            _id = id;
            _description = description;
        }

        public int Id { get { return _id; } }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public bool Done
        {
            get { return _done; }
            set { _done = value; }
        }
        public Person Assignee
        {
            get { return _assignee; }
            set { _assignee = value; }
        }
    }
}
