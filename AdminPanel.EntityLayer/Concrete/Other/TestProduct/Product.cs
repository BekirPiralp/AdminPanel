using AdminPanel.EntityLayer.Concrete.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanel.EntityLayer.Concrete.Other.Product
{
    public class Product : ProductBase
    {
        public string Name { get; set; }
        public string TelefonKodu { get; set; }
        public Int16 TrafikKodu { get; set; }
    }
}
