using EF_Core.BDContexto;

namespace EF_Core
{
    /// <summary>
    /// Classe responsável por modificar os dados do banco de dados
    /// </summary>
    class Modificacoes
    {
        /// <summary>
        /// Método responsável por modificar o título do filme passado
        /// </summary>
        /// <param name="id">Id do filme que será modificado</param>
        /// <param name="titulo">Título novo que será atribuído</param>
        public static void ModificarTituloFilme(int id, string titulo)
        {
            using (var bancoDeDados = new Contexto())
            {
                var filme = bancoDeDados.Filmes.Find(id); // Encontra no banco a tupla com o id passado

                if (filme != null)
                {
                    filme.Titulo = titulo; // Altera o título
                }

                bancoDeDados.SaveChanges(); // Gera o SQL e altera no banco
            }
        }
    }
}
