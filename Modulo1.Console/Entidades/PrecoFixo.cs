namespace Modulo1.Console.Entidades;

internal class PrecoFixo : Preco
{
    public decimal ValorDiaria { get; set; }
    public decimal ValorPernoite { get; set; }

    public override long CalcularPreco(Ticket ticket)
    {
        return ticket.Veiculo.TipoVeiculo == TipoVeiculo.Carro ?
         10 : 7;
    }
}