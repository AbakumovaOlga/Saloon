using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonModel
{
    public class Master
    {
        public int Id { get; set; }

        [Required]
        public string FIO { get; set; }

        public int ContractId { get; set; }

        public virtual Contract Contract { get; set; }

        public int CommissionId { get; set; }

        public virtual Commission Commission { get; set; }
    }
}
