using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domainlayer.BankSystem.Entites
{
    public class Customer
    {
        public int Id { get; set; }

        public string NationallId{ get; set; }
        public string Nationality{ get; set; }
        public string ImageFrontId{ get; set; }
        public string ImageBackId{ get; set; }
        public int UserId  { get; set; }
        public int AccountId  { get; set; }
        [ForeignKey("UId")]
        public User ?user { get; set; }
        public virtual ICollection<BankAccount>?BankAccounts { get; set; }

    }
}
