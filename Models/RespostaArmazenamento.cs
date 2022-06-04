using System.Collections.Generic;
namespace Questionario.Models
{
    public static class RespostaArmazenamento
    {
        private static List<Resposta> respostas = new List<Resposta>();
        public static IEnumerable<Resposta> RespostaExibicao{get{return respostas;}}
        static RespostaArmazenamento()
        {
            respostas.Add(new Resposta() { Nome = "Matheus", Sim = true });
            respostas.Add(new Resposta() { Nome = "Calors", Sim = false });
        }
        public static void AdicionarResposta(Resposta resposta)
        {
            respostas.Add(resposta);
        }

    }
}