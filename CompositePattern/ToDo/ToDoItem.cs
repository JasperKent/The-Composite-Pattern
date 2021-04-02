namespace CompositePattern.ToDo
{
    public abstract class ToDoItem
    {
        public ToDoItem(string name, string description, double hours, decimal cost)
        {
            Name = name;
            Description = description;
            Hours = hours;
            Cost = cost;
        }

        public string Name { get; }
        public string Description { get;  }
        public virtual double Hours { get;  }
        public virtual decimal Cost { get; }

        public virtual string ToString(int indent = 0) => $"{Name} will take {Hours} hours and cost {Cost:C}.";

        public virtual ToDoItem Find(string name) => name == Name ? this : null;
    }
}
