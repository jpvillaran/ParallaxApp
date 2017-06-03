using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParallaxApp.Models
{
    public class UserAccount
    {
        /// <summary>
        /// Unique identifier for the User's account.  For DB use.
        /// </summary>
        [Key]
        public Guid Id { get; set; }


        /// <summary>
        /// The user's account number.  This value should be unique for the whole accounts table.
        /// </summary>
        [Required]
        public string UserName { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// The date when the account was created.
        /// </summary>
        public DateTime CreateDate { get; set; }

        public ICollection<PaymentMethod> PaymentMethods { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Purchase> PurchaseHistory { get; set; }

    }
}
