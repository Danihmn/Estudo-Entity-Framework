using EF_Core.BDContexto;
using EF_Core.Entidades;

namespace EF_Core
{
    /// <summary>
    /// Classe responsável pelas inserções no banco
    /// </summary>
    class Insercoes
    {
        /// <summary>
        /// Método responsável por inserir os filmes no banco
        /// </summary>
        /// <param name="titulo">Título a ser inserido</param>
        /// <param name="ano">Ano a ser inserido</param>
        public static void InserirFilme(string titulo, int ano)
        {
            using (var bancoDeDados = new Contexto())
            {
                // Adiciona filme
                bancoDeDados.Add(new Filme { Titulo = titulo, Ano = ano });
                bancoDeDados.SaveChanges(); // Gera o SQL e insere os dados
            }
        }
    }
}
