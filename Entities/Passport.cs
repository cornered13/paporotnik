using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Entities
{
    public class Passport
    {
        public int PassportId { get; set; }
        public int ClientId { get; set; }
        public string Series { get; set; } = null!;
        public string Number { get; set; } = null!;
        public string DocumentType { get; set; } = null!;
        public string KemVidan { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string CountryIssue { get; set; } = null!;

        public Client Client { get; set; } = null!;
    }
}
