using BeautySaloonModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonService
{
        [Table("BeautyDatabase")]
        public class BeautyDbContext : DbContext
        {
            public BeautyDbContext()
            {
                //настройки конфигурации для entity
                Configuration.ProxyCreationEnabled = false;
                Configuration.LazyLoadingEnabled = false;
                var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            }

            public virtual DbSet<User> Users { get; set; }

            public virtual DbSet<Client> Clients { get; set; }

            public virtual DbSet<Contract> Contracts { get; set; }

            public virtual DbSet<Procedure> Procedures { get; set; }

            public virtual DbSet<Master> Masters { get; set; }

            public virtual DbSet<Commission> Commissions { get; set; }

            public virtual DbSet<Directory> Directories { get; set; }
        }
    
}
