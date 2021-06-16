using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace CRUD 
{
    public class CarController : Controller 
    {
      
      private readonly DataContext db;


    public CarController(DataContext db)
    {
        this.db = db;
    }
               public async Task<IActionResult> Index( )
        {
          
            var lista = await db.tb_AnnuncioWebmotors.ToListAsync();
           
             return View(lista);
                
        }

        [HttpGet]
        public IActionResult CriarCarro()
        {
            return View();
        }
     
          
        public async Task<IActionResult> CriarCarro(Car car)
        {
            if(ModelState.IsValid)
            {
                db.Add(car);
                await db.SaveChangesAsync();
               return RedirectToAction("Index");
            }
            else
            {
                return View("Index");
            }
        }
            [HttpGet]
     public  IActionResult Apagar(int id)
     {
            var carro = db.tb_AnnuncioWebmotors.Find(id);
           
             return View("Apagar",carro);
         
         
     }
    
 
    [HttpPost]
     public async Task<IActionResult> Apagar(Car car)
     {
         
         db.tb_AnnuncioWebmotors.Remove(car);
         await db.SaveChangesAsync();
         return RedirectToAction("Index");
       
     }
      [HttpGet]
     public IActionResult Editar(int id)
     {
         var carro = db.tb_AnnuncioWebmotors.Find(id);
         return View("Editar", carro);
     }

 
    [HttpPost]
     public async Task<IActionResult> Editar(Car car)
     {
        
         db.tb_AnnuncioWebmotors.Update(car);
         await db.SaveChangesAsync();
        return RedirectToAction("Index");
     }


    
    }
    
}
