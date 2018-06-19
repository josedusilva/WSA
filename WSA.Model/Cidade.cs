namespace WSA.Model
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public short EstadoId { get; set; }
        public Estado Estado { get; set; }
    }
}