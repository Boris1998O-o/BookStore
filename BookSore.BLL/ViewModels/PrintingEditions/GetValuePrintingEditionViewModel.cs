using BookStore.DAL.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.BLL.ViewModels.PrintingEditions
{
    public class GetValuePrintingEditionViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public string Type { get; set; }
    }
}
