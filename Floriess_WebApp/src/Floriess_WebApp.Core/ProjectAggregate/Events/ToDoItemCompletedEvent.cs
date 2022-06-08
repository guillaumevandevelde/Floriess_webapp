using Floriess_WebApp.SharedKernel;

namespace Floriess_WebApp.Core.ProjectAggregate.Events
{
    public class ToDoItemCompletedEvent : DomainEventBase
    {
        public ToDoItem CompletedItem { get; set; }

        public ToDoItemCompletedEvent(ToDoItem completedItem)
        {
            CompletedItem = completedItem;
        }
    }
}