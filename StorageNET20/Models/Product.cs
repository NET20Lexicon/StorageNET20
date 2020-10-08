using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StorageNET20.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Range(0, int.MaxValue)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public int Price { get; set; }

        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy:MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }


        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]
        public string Category { get; set; }


        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]
        public string Shelf { get; set; }


        [Range(0, int.MaxValue)]
        public int Count { get; set; }


        [Range(0, int.MaxValue)]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]
        public string Description { get; set; }
    }
}
