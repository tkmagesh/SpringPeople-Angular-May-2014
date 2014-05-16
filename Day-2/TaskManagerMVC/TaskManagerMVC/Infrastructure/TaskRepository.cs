using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskManagerMVC.Models;

namespace TaskManagerMVC.Infrastructure
{
    public static class TaskRepository
    {
        private static Dictionary<string, Task> _list = new Dictionary<string, Task>();

        public static Task AddNew(Task task)
        {
            task.id = Guid.NewGuid().ToString();
            _list.Add(task.id, task);
            return task;
        }

        public static void Update(Task task)
        {
            _list[task.id] = task;
        }

        public static void Remove(string taskId) {
            _list.Remove(taskId);
        }

        public static Task[] GetAll()
        {
            return _list.Values.ToArray<Task>();
        }

        public static Task Get(string id) {
            return _list[id];
        }

    }
}