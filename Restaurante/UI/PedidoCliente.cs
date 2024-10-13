using Restaurante.OO.Model;

namespace Restaurante.OO.UI;

public class PedidoCliente
{
    public Pedido CadastrarPedido()
    {

        Pedido pedido = new();

        Console.Write("Data: ");
        pedido.Data = Console.ReadLine();

        Console.Write("Mesa: ");
        string mesaInput = Console.ReadLine();
        if (int.TryParse(mesaInput, out int mesa))
        {
            pedido.Mesa = mesa;
        }
        else
        {
            Console.WriteLine("Input inválido para a Mesa. Por favor digite um número válido.");
        }

        Console.Write("Comanda: ");
        string comandaInput = Console.ReadLine();
        if (int.TryParse(comandaInput, out int comanda))
        {
            pedido.Comanda = comanda;
        }
        else
        {
            Console.WriteLine("Input inválido para a Comanda. Por favor digite um número válido.");
        }

        Console.Write("Item: ");

        pedido.Item = Console.ReadLine();

        return pedido;
    }
}
