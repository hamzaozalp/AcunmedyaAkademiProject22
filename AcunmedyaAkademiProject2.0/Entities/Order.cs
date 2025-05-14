using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AcunmedyaAkademiProject2._0.Entities;

namespace AcunmedyaAkademiProject2._0.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}