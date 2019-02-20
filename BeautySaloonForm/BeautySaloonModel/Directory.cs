using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonModel
{
    public class Directory
    {
        public int Id { get; set; }

        [Required]
        public decimal ExpensesSumma { get; set; }

        [Required]
        public string ServiceType { get; set; }

        public int ContractId { get; set; }

        public virtual Contract Contract { get; set; }
    }
}
