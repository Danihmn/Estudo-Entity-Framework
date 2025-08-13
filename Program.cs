using EF_Core.BDContexto;
using EF_Core.Entidades;

namespace EF_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new Contexto())
            {
                // Verifica se o banco foi criado, se não, cria
                contexto.Database.EnsureCreated();
            }

            // Cria nova instância do contexto
            using (var bancoDeDados = new Contexto())
            {
                // Rastreia qual será o processo de manipulação CRUD
                bancoDeDados.Add(new Filme { Titulo = "Batman o Cavaleiro das Trevas", Ano = 2000 });
                bancoDeDados.SaveChanges(); // Gera o SQL e insere os dados no banco

                var filmes = bancoDeDados.Filmes.ToList(); // Converte a tabela em uma lista

                foreach (var filme in filmes)
                {
                    Console.WriteLine(filme.Titulo); // Percorre a lista e exibe os títulos
                }
            }
        }
    }
}
