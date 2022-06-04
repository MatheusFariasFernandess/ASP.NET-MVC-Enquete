using System.ComponentModel.DataAnnotations;
namespace Questionario.Models
{
    public class Resposta
    {
        [Required(ErrorMessage ="O nome deve ser inserido")]
        public string Nome{get;set;}=string.Empty;
        [Required (ErrorMessage ="O Email deve ser inserido")]
        public string Email{get;set;}=string.Empty;
        [Required(ErrorMessage ="Uma opção deve ser marcada")]
        public bool? Sim{get;set;}
        
    }
}