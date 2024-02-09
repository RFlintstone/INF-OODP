// Learning goals:
// - create instances (object) of the built-in class (List)
// - 'Add' an element to a List
// - 'Remove' an element from a List
//
// In the Main, create a List of type string. Then do the following:
// - print an overview of the List
// - Add the tasks "Mow lawn" and "Pay taxes"
// - print an overview of the List
// - Remove "Mow lawn" and Add "Shopping"
// - print an overview of the List
//
// An example of an overview of the List:
// - Amount of tasks: 2
// - Do dishes
// - Call dad

List<string> goals = new List<string>();
Overview(goals);
goals.Add("Mow lawn");
goals.Add("Pay taxes");
Overview(goals);
goals.Remove("Mow lawn");
goals.Add("Shopping");
Overview(goals);

static void Overview(List<string> goals)
{
    Console.WriteLine($"Amount of tasks: {goals.Count}");
    foreach (var goal in goals)
    {
        Console.WriteLine(goal);
    }
}