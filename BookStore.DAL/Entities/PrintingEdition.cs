using BookStore.DAL.Entities.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.DAL.Entities
{
    public class PrintingEdition:BaseEntity
    {
        public string Name { get; set; }
        [NotMapped]
        public virtual ICollection<Author> Authors { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Currency Currency { get; set; }
        public EditionType Type { get; set; }
    }
}