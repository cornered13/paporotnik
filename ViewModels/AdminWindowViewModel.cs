using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Entities;

namespace WpfApp1.ViewModels
{
    public class AdminWindowViewModel : ViewModelBase
    {
        private List<Client> _clients;

        public List<Client> Clients
        {
            get => _clients;
            set => Set(ref _clients, value, nameof(Clients));
        }

        public AdminWindowViewModel()
        {
            using(var db = new ApplicationDbContext())
            {
                Clients = db.Clients.ToList();
            }
        }
    }
}
