using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloInterface.Models
{
    class BasicPerson : PersonBase, IPerson
    {
        public BasicPerson()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public decimal WalletAmount { get; set; }
    }
}
