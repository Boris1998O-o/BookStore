using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookStore.DAL.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public bool IsRemoved { get; set; }
        public DateTime CreationData { get; set; }
    }
}
