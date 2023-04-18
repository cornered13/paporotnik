using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Entities
{
    public class HotelRoom
    {
        public HotelRoom()
        {
            Treaties = new HashSet<Treaty>();
        }

        public int HotelRoomId { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; } = null!;
        public int Floor { get; set; }
        public int CostPerDay { get; set; }
        public int NumberOfSeats { get; set; }
        public string Status { get; set; } = null!;

        public ICollection<Treaty> Treaties { get; set; } = null!;
        public Category Category { get; set; } = null!;
    }
}
