using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace todolist.Models
{
    [Table("User")]
    public partial class User
    {
        [Key]
        [Column("User_Id")]
        public int UserId { get; set; }
        [Required]
        [Column("User_Name")]
        [StringLength(50)]
        public string UserName { get; set; }
        [Column("User_Password")]
        [StringLength(150)]
        public string UserPassword { get; set; }
    }
}
