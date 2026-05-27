namespace ViajaMais.Entities
{
    public class PacoteViagem
    {
        private int _id {  get; set; }
        public decimal Preco {  get; set; }
        public DateOnly DataSaida { get; set; }
        public DateOnly DataRetorno { get; set; }
        private int _idDestino { get; set; }

        public PacoteViagem() { }

        public PacoteViagem(int id, decimal preco, DateOnly dataSaida, DateOnly dataRetorno, int idDestino)
        {
            _id = id;
            Preco = preco;
            DataSaida = dataSaida;
            DataRetorno = dataRetorno;
            _idDestino = idDestino;
        }
    }
}
