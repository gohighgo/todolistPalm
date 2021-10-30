using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace todolist.Models
{
    [Table("Status")]
    public partial class Status
    {
        [Key]
        [Column("Status_Id")]
        public int StatusId { get; set; }
        [Column("Status_Name")]
        [StringLength(50)]
        public string StatusName { get; set; }
    }
}
