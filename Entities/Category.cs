using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Entities
{
    public class Category
    {
        public Category()
        {
            HotelRooms = new HashSet<HotelRoom>();
        }

        public int CategoryId { get; set; }
        public string? Designation { get; set; }
        public string? CategoryDescription { get; set; }

        public ICollection<HotelRoom> HotelRooms { get; set; }
    }
}
