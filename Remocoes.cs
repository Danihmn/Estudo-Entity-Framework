using EF_Core.BDContexto;

namespace EF_Core
{
    /// <summary>
    /// Classe responsável pela remoção de dados do banco
    /// </summary>
    class Remocoes
    {
        /// <summary>
        /// Método responsável por remover os filmes do banco
        /// </summary>
        /// <param name="id">Id do filme que será removido</param>
        public static void RemoverFilme(int id)
        {
            using (var bancoDeDados = new Contexto())
            {
                var filme = bancoDeDados.Filmes.Find(id); // Procura o filme pelo seu id

                if (filme != null)
                {
                    bancoDeDados.Remove(filme); // Remove o filme
                }

                bancoDeDados.SaveChanges(); // Gera o SQL e remove o filme
            }
        }
    }
}
