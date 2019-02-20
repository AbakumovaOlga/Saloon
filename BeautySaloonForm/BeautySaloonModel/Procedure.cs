using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonModel
{
    public class Procedure
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Cost { get; set; }

        public int Count { get; set; }

        public int ContractId { get; set; }

        public virtual Contract Contract { get; set; }

        [ForeignKey("ProcedureId")]
        public virtual List<TypeProcedure> Types { get; set; }
    }
}
