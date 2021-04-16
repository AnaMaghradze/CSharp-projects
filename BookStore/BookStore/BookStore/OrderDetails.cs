using System;
/// <summary>
/// Ana Maghradze
/// red ID: 82335646
/// </summary>
namespace BookStore
{
    class OrderDetails
    {
        public string BookID { get; set; }
        public int Quantity { get; set; }
        public decimal LinesTotal { get; set; }

        public OrderDetails(string bookId, int quantity, decimal linesTotal)
        {
            BookID = bookId;
            Quantity = quantity;
            LinesTotal = linesTotal;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
