using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StorageNET20.Models.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public int Price { get; set; }

        public int Count { get; set; }

        [Display(Name = "Inventory Value")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public int InventoryValue { get; set; }
    }
}
