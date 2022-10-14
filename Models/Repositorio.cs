using System.Collections.Generic;


namespace EnqueteWeb.Models
{
    public class Repositorio
    {
        private static List<Resposta> respostas = new List<Resposta>();
        public static IEnumerable<Resposta> Respostas {get {return respostas; } }
        public static void AdicionarRespostas(Resposta resposta){
            respostas.Add(resposta);
        }

        static Repositorio(){
            respostas.Add(
                new Resposta {Nome = "Fulano", Email="fulano@gmail.com", Sim = true}
                );
            respostas.Add(
                new Resposta {Nome = "Ciclano", Email="ciclano@gmail.com", Sim = false}
                );
            respostas.Add(
                new Resposta {Nome = "Beltrano", Email="beltrano@gmail.com", Sim = false}
                );
            respostas.Add(
                new Resposta {Nome = "Maria", Email="maria@gmail.com", Sim = true}
                );
            respostas.Add(
                new Resposta {Nome = "Joao", Email="joao@gmail.com", Sim = true}
                );

        }
    }
}