using CompositePattern.Data;

namespace CompositePattern.ToDo
{
    public class CommunicationItem : ToDoItem
    {
        public CommunicationItem(string name, string description, double hours)
            : base(name, description, hours, (decimal)hours * SampleItems.CallRate)
        {

        }
    }
}
