using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Entities
{
    public class MigrationCard
    {
        public int MigrationCardId { get; set; }
        public int ClientId { get; set; }
        public string CardNumber { get; set; } = null!;
        public string From { get; set; } = null!;
        public DateTime StayWith { get; set; }
        public DateTime StayUntil { get; set; }
        public string TripPurpose { get; set; } = null!;

        public Client Client { get; set; } = null!;
    }
}
