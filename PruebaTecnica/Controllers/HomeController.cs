using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaTecnica.Models;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


namespace PruebaTecnica.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
       
        public IActionResult BuscarItem()
        {
           
            return View();
        }
        string dirUrl="https://qastudiof.myvtex.com/";                  
        string busqueda="";
              
        public async System.Threading.Tasks.Task <IActionResult> Resultado(String Nombre, String categ){
          if(categ=="55"){
             
             busqueda = "fq=productId:"+Nombre;
          }else{
             busqueda = "_from=1&_to=2&ft="+Nombre+"&fq=C:"+categ;
          }
           List <DataItem> data = new List<DataItem>();
           List <Producto> data2 = new List<Producto>();
            using(var Httpc = new HttpClient()){
              Httpc.BaseAddress= new Uri(dirUrl);
              Httpc.DefaultRequestHeaders.Clear();
              Httpc.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
              //HttpResponseMessage ResMensaje = await Httpc.GetAsync("api/catalog_system/pub/category/tree/"+Id);
              HttpResponseMessage ResMensaje = await Httpc.GetAsync("api/catalog_system/pub/products/search?"+busqueda);
              if(ResMensaje.IsSuccessStatusCode){
                string DataP = ResMensaje.Content.ReadAsStringAsync().Result;
                if(DataP!=null){
                    
                    data2 = JsonConvert.DeserializeObject<List<Producto>>(DataP);
                    
                   
                 
                    
                    }
               
              }
            }
            return View(data2);
        }

   

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
