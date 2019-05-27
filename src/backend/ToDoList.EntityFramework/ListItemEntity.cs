using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.EntityFramework
{
    public class ListItemEntity
    {
        public Guid Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public bool IsSelected { get; set;}
    }
}