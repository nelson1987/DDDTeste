namespace Portifolio.Domain.Interfaces
{
    public interface IImposto
    {
        double Juros { get; }
        double Calcular(double bruto);
    }
}
