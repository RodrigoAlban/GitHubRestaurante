namespace Restaurante.OO.Model
{
    public class Pedido
    {
        public string Data { get; set; }
        public int Mesa { get; set; }
        public int Comanda { get; set; }
        public string Item { get; set; }
        public bool Status { get; set; }

        public override string ToString()
        {
            return $"Data: {Data}, Mesa: {Mesa}, Comanda: {Comanda}, Item: {Item}";
        }
    }
}
