using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domainlayer.BankSystem.Entites
{
    public class User
    {

        public int Id { get; set; }

        public string Role { get; set; }
        public DateTime CreatedAt{ get; set; }

        public Customer Customer { get; set; }
        public virtual ICollection<BankAccount> ?BankAccounts { get; set; }
        public virtual ICollection<AuditLog> ?AuditLogs { get; set; }
    }
}
