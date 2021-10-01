using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Destroy_Azure.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult RAM()//RAM
        {
            ViewBag.Message = "Your application description page.";
            RAM();
            return View();
        }

        public ActionResult CPU()//CPU
        {
            while (true)
            {
                Console.WriteLine("Interrumpcion");
            }
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public async System.Threading.Tasks.Task<ActionResult> SpikeTCP()//TCP
        {

             while (true)
          {
                //TcpClient tcpClient = new TcpClient();
                //IPAddress ipAddress = Dns.GetHostEntry("www.google.com").AddressList[0];
                //IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 80);
                //tcpClient.Connect(ipEndPoint);
                string webpage = "https://1.1.1.1/";
                var uri = new Uri(webpage);
                var hc = new HttpClient();
                var result = await hc.GetStringAsync(uri);
            }
            return View();

        }

     

        public ActionResult Summary()
        {
           
            return Redirect("~/PrintConnectionsSummary.aspx");
            
        }
        
    }
}