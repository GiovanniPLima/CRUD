using System.Collections;
using  System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace CRUD
{
   
    public class Car 
    {
    
        [Key]
        [Required]
        
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Marca { get; set; }   
        [Required]
        [MaxLength(45)]
        public string Modelo { get; set; }
        [Required]
      
        public int Ano { get; set; }

        [Required]
        public int Quilometragem { get; set; }

        [Required]
        public string Observacao { get; set; }

    }
}