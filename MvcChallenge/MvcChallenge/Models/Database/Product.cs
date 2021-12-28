namespace MvcChallenge.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        /// <summary>
        /// 0 is the first parameter. C=currency 2=two decimal places
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        

        [Required]
        [StringLength(50)]
        public string Size { get; set; }

        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
