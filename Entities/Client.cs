using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Entities
{
    public class Client
    {
        public Client()
        {
            Treaties = new HashSet<Treaty>();
        }

        public int ClientId { get; set; }
        public string FIO { get; set; } = null!;
        public string Sex { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string BonusCard { get; set; } = null!;

        public Passport Passport { get; set; } = null!;
        public MigrationCard MigrationCard { get; set; } = null!;
        public ICollection<Treaty> Treaties { get; set; }
    }
}
