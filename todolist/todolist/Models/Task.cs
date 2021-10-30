using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace todolist.Models
{
    [Table("Task")]
    public partial class Task
    {
        [Key]
        [Column("Task_Id")]
        public int TaskId { get; set; }
        [Column("User_Id")]
        public int UserId { get; set; }
        [Column("Task_Name")]
        [StringLength(50)]
        public string TaskName { get; set; }
        [Column("Task_Description")]
        [StringLength(250)]
        public string TaskDescription { get; set; }
        [Column("Status_Id")]
        public int StatusId { get; set; }
    }
}
