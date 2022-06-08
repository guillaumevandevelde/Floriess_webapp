using Floriess_WebApp.SharedKernel;

namespace Floriess_WebApp.Core.ProjectAggregate.Events
{
    public class NewItemAddedEvent : DomainEventBase
    {
        public ToDoItem NewItem { get; set; }
        public Project Project { get; set; }

        public NewItemAddedEvent(Project project,
            ToDoItem newItem)
        {
            Project = project;
            NewItem = newItem;
        }
    }
}