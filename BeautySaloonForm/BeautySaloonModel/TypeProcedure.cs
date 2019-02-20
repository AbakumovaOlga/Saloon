using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonModel
{
    public class TypeProcedure
    {
        public int Id { get; set; }

        [Required]
        public string NameType { get; set; }

        public int ProcedureId { get; set; }

        public virtual Procedure Procedure { get; set; }
    }
}
