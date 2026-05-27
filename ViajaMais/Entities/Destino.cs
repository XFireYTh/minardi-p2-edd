namespace ViajaMais.Entities
{
    public class Destino
    {
        private int _id {  get; set; }
        public string NomeDestino { get; set; }
        public string EstadoPais { get; set; }
        
        public Destino() { }

        public Destino(int id, string nomeDestino, string estadoPais)
        {
            _id = id;
            NomeDestino = nomeDestino;
            EstadoPais = estadoPais;
        }
    }

}
