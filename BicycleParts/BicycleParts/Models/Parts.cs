using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BicycleParts.Models
{
    public class Parts
    {
        [ScaffoldColumn(false)]
        public int PartID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string PartBrand { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string PartModel { get; set; }

        [Required, StringLength(1000), Display(Name = "Part Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Price")]
        public double? PartPrice { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}