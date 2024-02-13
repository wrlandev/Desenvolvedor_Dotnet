using Calculadora.Services;

namespace CalculadoraTeste;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com19ERetornar15()
    {
        int x = 5;
        int y = 10;

        int res = _calc.Somar(x, y);

        Assert.Equal(15 , res);
    }
}