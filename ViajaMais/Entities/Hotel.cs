namespace ViajaMais.Entities
{
    public class Hotel
    {
        private int _id { get; set; }
        public string NomeHotel { get; set; }
        private int _idDestino { get; set; }

        public Hotel() { }

        public Hotel(int id, string nomeHotel, int idDestino)
        {
            _id = id;
            NomeHotel = nomeHotel;
            _idDestino = idDestino;
        }
    }
}
