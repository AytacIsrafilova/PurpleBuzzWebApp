using PurpleBuzzWebApp.Models;

namespace PurpleBuzzWebApp.ViewModels
{
    public class HomeVM
    {
        public List<Slider>Sliders { get; set; }
        public List<Client>Clients { get; set; }
        public List<Service>Services { get; set; }
    }
}
