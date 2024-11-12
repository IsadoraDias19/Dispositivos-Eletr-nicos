using Dispositivos_Eletrônicos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dispositivos_Eletrônicos.Controllers
{
    public class DispositivoController : Controller
    {
       
        public IActionResult Index()
        {
            List<DispositivoEletronicos> dispositivos = new List<DispositivoEletronicos>
            {
                new Computador{ Marca = "Dell", Modelo = "Inspirion", AnoDeFabricacao = 2021, EhLaptop = true, MemoriaRam = 16, SistemaOperacional= "Laptop"},
                new Computador{ Marca = "HP", Modelo = "Pavilion", AnoDeFabricacao = 2019, EhLaptop = true, MemoriaRam = 8, SistemaOperacional= "DeskTop"},
                new Smartphone{ Marca = "Apple", Modelo = "iPhone 13", AnoDeFabricacao = 2022, Tem5G = true }

            };
            return View(dispositivos);
        }
    }
}
