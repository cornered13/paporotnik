using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Entities
{
    public class Treaty
    {
        public int TreatyId { get; set; }
        public DateTime TreatyDate { get; set; }
        public int ClientId { get; set; }
        public int HotelNumber { get; set; }
        public DateTime DateEntrance { get; set; }
        public DateTime DateDeparture { get; set; }
        public int SumOfPay { get; set; }
        public string MethodOfPay { get; set; } = null!;

        public Client Client { get; set; } = null!;
        public HotelRoom HotelRoom { get; set; } = null!;
    }
}
