using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscribere_Data.models
{
    [Table("CardTable")]
    public class CardTable
    {
        [Key]
        public int Id { get;}
        [ForeignKey(nameof(Id))]
        public Subscriber Sid { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public double BMI { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

    }
}
