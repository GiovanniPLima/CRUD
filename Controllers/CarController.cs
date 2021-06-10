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
       

     [HttpGet]
     public async Task<ActionResult> Editar(Car car)
     {
         var carro = db.tb_AnnuncioWebmotors.Find(car.Id);
         return View("Editar", carro);
     }

   //MEsmo erro do Delete - Retornando Null
     public async Task<ActionResult> Edita(Car car)
     {
         var carro = db.tb_AnnuncioWebmotors.Find(car.Id);
         db.tb_AnnuncioWebmotors.Update(carro);
         return View();
     }
        public async Task<ActionResult> Index( )
        {
          
            var lista = await db.tb_AnnuncioWebmotors.ToListAsync();
           
             return View(lista);
                
        }

        public ActionResult CriarCarro()
        {
            return View();
        }
        public ActionResult Buscar(Car car)
        
        {

            if(ModelState.IsValid)
            {
                 
                 return View("Buscar", car);
            }
            else
            {
                return View("Index");
            }
        }
          
        public async Task<ActionResult> Criar(Car car)
        {
            if(ModelState.IsValid)
            {
                db.Add(car);
                await db.SaveChangesAsync();
                return View("Criar", car);
            }
            else
            {
                return View("Index");
            }
        }
            [HttpGet]
     public async Task<ActionResult> Apagar(Car car)
     {
            var carro = db.tb_AnnuncioWebmotors.Find(car.Id);
           
             return View("Apagar",carro);
         
         
     }
    
    //RETORNANDO NULO VERIFICAR O PORQUE 
     public async Task<ActionResult> Delet(Car car)
     {
         var carro = db.tb_AnnuncioWebmotors.Find(car.Id);
         db.Remove(carro);
         await db.SaveChangesAsync();
         return View("Delet");
       
     }

    
    }
    
}