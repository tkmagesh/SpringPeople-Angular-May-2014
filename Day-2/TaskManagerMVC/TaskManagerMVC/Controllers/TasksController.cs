using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaskManagerMVC.Infrastructure;
using TaskManagerMVC.Models;

namespace TaskManagerMVC.Controllers
{
    public class TasksController : ApiController
    {
        // GET api/tasks
        public IEnumerable<Task> Get()
        {
            return TaskRepository.GetAll();
        }

        // GET api/tasks/5
        public Task Get(string id)
        {
            return TaskRepository.Get(id);
        }

        // POST api/tasks
        public void Post(Task task)
        {
            TaskRepository.AddNew(task);
        }

        // PUT api/tasks/5
        public void Put(string id, Task task)
        {
            TaskRepository.Update(task);
        }

        // DELETE api/tasks/5
        public void Delete(string id)
        {
            TaskRepository.Remove(id);
        }

        
    }
}
