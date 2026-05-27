using System.Globalization;

namespace ViajaMais.Entities
{
    public class Cliente
    {
        private int _id {  get; set; }
        public string Nome { get; set; }
        private string _email { get; set; }
        private string _cpf { get; set; }

        public Cliente(int id, string nome, string email, string cpf) 
        {
            _id = id;
            Nome = nome;
            _email = email;
            _cpf = cpf;
        }

        public Cliente() { }
    }
}
