namespace Modulo1.Console.Entidades;

internal class PrecoVariavel : Preco
{
    public decimal ValorPrimeiraHora { get; set; }
    public decimal ValorAdicionalHora { get; set; }

    public override long CalcularPreco(Ticket ticket)
    {
        //TODO: a fazer
        return 0;
    }
}