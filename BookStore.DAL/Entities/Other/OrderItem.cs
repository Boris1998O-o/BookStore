using BookStore.DAL.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.DAL.Entities.Other
{
    public class OrderItem:BaseEntity//обертка для order, а в самом ордере статус и остальное
    {
        public int Amount { get; set; }//amount editions in order
        public Currency Currency { get; set; }
        public int Count { get; set; }// total cost order
        public PrintingEdition PrintingEdition { get; set; }// ordered list editions
    }
}