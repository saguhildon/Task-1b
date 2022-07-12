using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Task.Models
{
    public class TaskModelContext : DbContext
    {
        public TaskModelContext(DbContextOptions<TaskModelContext> options)
           : base(options)
        {
        }

        public DbSet<TaskModel> TaskItems { get; set; } = null!;
    }
}
