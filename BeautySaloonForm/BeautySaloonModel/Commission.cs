using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonModel
{
    public class Commission
    {
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public decimal Value { get; set; }

        [ForeignKey("CommissionId")]
        public virtual List<Master> Masters { get; set; }
    }
}
