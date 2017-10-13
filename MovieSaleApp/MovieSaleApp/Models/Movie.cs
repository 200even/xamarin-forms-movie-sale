using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MovieSaleApp.Models
{
    [Table("Movies")]
    public class Movie
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [MaxLength(250)]
        public string Title { get; set; }
        public enum Condition
        {
            Excellent,
            Good,
            Fair,
            Poor
        }
        public bool IsSold { get; set; }
        public DateTime InventoryDate { get; set; }
        public string SaleDate { get; set; }
        public double ListPrice { get; set; }
        public double SalePrice { get; set; }
        public string Category { get; set; }
        // public Seller Seller { get; set; }
    }
}
