using EF_Core.BDContexto;

namespace EF_Core
{
    /// <summary>
    /// Classe responsável pela criação do banco de dados
    /// </summary>
    class Criacao
    {
        /// <summary>
        /// Método responsável pela criação do banco de dados
        /// </summary>
        public static void CriaBanco()
        {
            using (var bancoDeDados = new Contexto())
            {
                // Verifica se foi criado um banco, se não, cria um novo
                bancoDeDados.Database.EnsureCreated();
            }
        }
    }
}
