using System;

namespace WSA.Model
{
    public class Associado
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public DateTime Nascimento { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public bool Administrador { get; set; }
    }
}
