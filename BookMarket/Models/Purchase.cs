using System;
using System.Windows;

namespace BookMarket.Models {
  public class Purchase {
    public int PurchaseId { get; set; }
    public DateTime DateTime { get; set; }
    public string CustomerEmail { get; set; }
    public string CustomerSurname { get; set; }
    public string CustomerAddress { get; set; }
    public Purchase() {
      MessageBox.Show("FICK");
    }
  }
}