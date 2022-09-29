
using ToDoApp.Data;

var peopleService = new PeopleService();
peopleService.AddPerson("sara", "ahadi");
peopleService.AddPerson("sara2", "ahadi2");

var t = peopleService.FindById(2);
//peopleService.Clear();


var todo = new TodoService();
todo.AddToDo("des1");
todo.AddToDo("des2");
var x = todo.FindByDoneStatus(true);

var x2 = todo.FindByAssignee(1);

Console.WriteLine(t);
Console.ReadLine();
