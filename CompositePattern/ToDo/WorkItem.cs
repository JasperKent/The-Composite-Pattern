using CompositePattern.Data;

namespace CompositePattern.ToDo
{
    public class WorkItem : ToDoItem
    {
        public WorkItem(string name, string description, double hours)
            : base(name, description, hours, (decimal)hours * SampleItems.PayRate)
        {

        }
    }
}
