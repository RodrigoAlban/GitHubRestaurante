using System;
using Restaurante.OO.Model;

namespace Restaurante.OO.Repository;

public class RepositoryPedidoCliente
{
    private List<Pedido> pedidos = [];

    public void Cadastrar(Pedido pedido)
    {
        pedidos.Add(pedido);
    }

    public List<Pedido> Pedidos(){
        return pedidos;
    }
}
