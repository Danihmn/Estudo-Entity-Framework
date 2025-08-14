using EF_Core.BDContexto;

namespace EF_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExibirFilmes();
        }

        /// <summary>
        /// Método utilizado para exibição dos dados
        /// </summary>
        public static void ExibirFilmes()
        {
            using (var bancoDeDados = new Contexto())
            {
                var filmes = bancoDeDados.Filmes.ToList();

                foreach (var filme in filmes)
                {
                    Console.WriteLine($"{filme.Id}, {filme.Titulo}");
                }
            }
        }
    }
}
