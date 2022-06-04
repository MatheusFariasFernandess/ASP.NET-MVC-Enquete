using System.ComponentModel.DataAnnotations;
namespace Questionario.Models
{
    public class Resposta
    {
        [Required]
        public string Nome{get;set;}=string.Empty;
        [Required]
        public string Email{get;set;}=string.Empty;
        [Required]
        public bool? Sim{get;set;}
        
    }
}