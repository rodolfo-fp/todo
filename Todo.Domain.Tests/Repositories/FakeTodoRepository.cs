using System;
using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Domain.Tests.Repositories
{
    public class FakeTodoRepository : ITodoRepository
    {
        public void Create(TodoItem todo)
        {

        }

        public TodoItem GetById(Guid id, string user)
        {
            return new TodoItem("Tarefa", "Rodolfo Francisco Pinto", DateTime.Now);
        }

        public void Update(TodoItem todo)
        {

        }
    }
}