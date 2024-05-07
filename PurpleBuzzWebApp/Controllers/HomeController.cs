using Microsoft.AspNetCore.Mvc;
using PurpleBuzzWebApp.DAL;
using PurpleBuzzWebApp.Models;
using PurpleBuzzWebApp.ViewModels;

namespace PurpleBuzzWebApp.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _dbContext;
        public HomeController(AppDbContext dbContext)
        {
            dbContext= _dbContext;
        }
        public IActionResult Index()
        {




            Slider slider1 = new Slider()
            {
                BackGroundImg= "img/banner-bg-01.jpg",
                Title="fhdjvfjjd"

            };

            Slider slider2 = new Slider()
            {
                BackGroundImg = "img/banner-bg-01.jpg",
                Title = "fhdjvfjjd"

            };

            List<Slider> sliders = new List<Slider>();
            sliders.Add(slider1);
            sliders.Add(slider2);






            Client client = new Client()
            {

                Fullname = "nicat mecidov",
                Description = "chunks as necessary, making this the first true generator on the ınternet.",
                PhotoUrl = "images/client-1.jpg"

            };
            Client client1 = new Client()
            {
                Fullname = "ramiz mecidov",
                Description = "chunks as necessary, making this the first true generator on the ınternet.",
                PhotoUrl = "images/client-2.jpg"

            };
            List<Client> clients = new List<Client>();
            clients.Add(client1);
            clients.Add(client);






            Service service = new Service()
            {
                Name = "maintenance",
                Description = "bhgyhgyhghyg",
                PhotoUrl = "images/s1.png",

            };
            Service service1 = new Service()
            {
                Name = "maintenance",
                Description = "bhgyhgyhghyg",
                PhotoUrl = "images/s1.png",

            };
            Service service2 = new Service()
            {
                Name = "maintenance",
                Description = "bhgyhgyhghyg",
                PhotoUrl = "images/s1.png",

            };
            List<Service> services = new List<Service>();
            services.Add(service);
            services.Add(service2);
            services.Add(service1);


            HomeVM homeVM = new HomeVM()
            {
                Clients = clients,
                Services = services,
                Sliders=sliders,
            };

            return View(homeVM);
        }
    }
}
