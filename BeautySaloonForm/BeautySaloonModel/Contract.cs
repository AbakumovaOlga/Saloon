using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonModel
{
    public class Contract
    {
        public int Id { get; set; }

        [Required]
        public decimal Summa { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [ForeignKey("ContractId")]
        public virtual List<Master> Masters { get; set; }

        [ForeignKey("ContractId")]
        public virtual List<User> Users { get; set; }

        [ForeignKey("ContractId")]
        public virtual List<Client> Clients { get; set; }

        [ForeignKey("ContractId")]
        public virtual List<Directory> Directories { get; set; }

        [ForeignKey("ContractId")]
        public virtual List<Procedure> Procedures { get; set; }
    }
}
