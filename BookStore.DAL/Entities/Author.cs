using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookStore.DAL.Entities
{
    public class Author:BaseEntity
    {
        public string Name { get; set; }
        [NotMapped]
        public virtual ICollection<PrintingEdition> PrintingEditions { get; set; }
    }
}