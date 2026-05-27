namespace ViajaMais.Entities
{
    public class Reserva
    {
        private int _id;
        public int Id { get { return _id; } set { _id = value; } }
        public DateTime DataReseva { get; set; }
        private string _statusPagamento;
        public string StatusPagamento { get { return _statusPagamento; } set { _statusPagamento = value; } }
        private int _idCliente;
        public int IdCliente { get { return _idCliente; } set { _idCliente = value; }  }
        private int _idHotel;
        public int IdHotel { get { return _idHotel; } set { _idHotel = value; } }

        public Reserva() { }

        public Reserva(int id, DateTime reserva, string status, int idCliente, int idHotel) 
        {
            Id = id;
            DataReseva = reserva;
            StatusPagamento = status;
            IdCliente = idCliente;
            IdHotel = idHotel;
        }
    }
}
