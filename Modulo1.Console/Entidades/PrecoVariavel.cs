namespace Modulo1.Console.Entidades;

internal class PrecoVariavel : Preco
{
    public decimal ValorPrimeiraHora { get; set; }
    public decimal ValorAdicionalHora { get; set; }

    public override void CalcularPreco()
    {
    }
}