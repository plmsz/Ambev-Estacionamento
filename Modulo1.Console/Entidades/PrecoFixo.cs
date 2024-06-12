namespace Modulo1.Console.Entidades;

internal class PrecoFixo : Preco
{
    public decimal ValorDiaria { get; set; }
    public decimal ValorPernoite { get; set; }

    public override void CalcularPreco()
    {
    }
}