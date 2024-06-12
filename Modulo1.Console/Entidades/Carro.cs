namespace Modulo1.Console.Entidades;

internal class Carro : Veiculo
{
    public TipoVeiculo TipoVeiculo { get; set; }

    public override void CadastrarVeiculo(string placa)
    {
        Placa = placa;
        TipoVeiculo = TipoVeiculo.Carro;
    }
}