namespace EF_Core.Entidades
{
    internal class Diretor
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public ICollection<Filme> Filmes { get; set; } = [];
    }
}
