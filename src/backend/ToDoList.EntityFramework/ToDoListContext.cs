using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToDoList.EntityFramework
{
    public class ToDoListContext : DbContext
    {
        public DbSet<ListItemEntity> ListItems { get; set; }
        
        public ToDoListContext(DbContextOptions<ToDoListContext> options)
            : base(options)
        {
            
        }
    }
}