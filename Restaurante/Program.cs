using Restaurante.OO.Model;
using Restaurante.OO.Repository;
using Restaurante.OO.UI;

RepositoryPedidoCliente repositoryPedidoCliente = new();

string opcaoDoUsuario = Menu.Show();

if (int.TryParse(opcaoDoUsuario, out int opcao))
{
    if (opcao == 1) // Usuário é Cliente
    {
        PedidoCliente pedidoCliente = new();
        Pedido pedido = pedidoCliente.CadastrarPedido();
        repositoryPedidoCliente.Cadastrar(pedido);

        for (int i = 0; i < repositoryPedidoCliente.Pedidos().Count; i++)
        {
            Pedido Pedido = repositoryPedidoCliente.Pedidos()[i];
            Console.WriteLine(pedido);
        }
    }
    else if (opcao == 2) // Usuário é Gerente
    {
        // adicionarMesa();
        // removerMesa();
        Console.Write("Teste");
    }
}
else
{
    Console.WriteLine("Opção inválida. Por favor, digite um número válido.");
}


