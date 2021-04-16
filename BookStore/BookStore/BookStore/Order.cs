using System;
/// <summary>
/// Ana Maghradze
/// red ID: 82335646
/// </summary>
namespace BookStore
{
    class Order
    {
        public string CustomerID { get; set; }
        public int OrderID { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public decimal Tax { get; set; }
        public DateTime OrderDate { get; set; }

        // Order explicit value constructor
        public Order(string customerId, decimal subTotal, decimal total, decimal tax, DateTime orderDate)
        {
            CustomerID = customerId;
            OrderDate = orderDate; 
            SubTotal = subTotal;
            Total = total;
            Tax = tax;     
        }
        
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
