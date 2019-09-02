using BookStore.DAL.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookStore.DAL.Entities.Other
{
    public class Order:BaseEntity
    {
        public string Description { get; set; }
        public Status Status { get; set; }
        public Payment Payment { get; set; }
        public PrintingEdition PrintingEdition { get; set; }
    }
}
