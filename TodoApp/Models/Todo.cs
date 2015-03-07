using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Web.Mvc;


namespace TodoApp.Models
{
    public class Todo
    {
        public int id { get; set; }

        [Display(Name = "Task Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Priority")]
        public string Priority { get; set; }
        public IEnumerable<SelectListItem> Priorities { set; get; }

        [Display(Name = "Complete By")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:d}", ApplyFormatInEditMode = true)]
        public DateTime CompletionDate { get; set; }
    }

    public class TodoContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
    }
}