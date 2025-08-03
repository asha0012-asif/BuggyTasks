using System.Collections.ObjectModel;

namespace BuggyTasks.Models
{
    public static class TaskCollection
    {
        public static ObservableCollection<TaskItem> Tasks { get; } = new ObservableCollection<TaskItem> { };
    }
}