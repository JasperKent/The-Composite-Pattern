namespace CompositePattern.ToDo
{
    public class PurchaseItem : ToDoItem
    {
        public PurchaseItem(string name, string description, decimal cost)
            : base(name, description, 0, cost)
        {

        }
    }
}
