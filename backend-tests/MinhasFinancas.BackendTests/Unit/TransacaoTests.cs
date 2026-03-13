using Xunit;

namespace MinhasFinancas.BackendTests.Unit;

public class TransacaoTests
{
    [Fact]
    public void NaoDevePermitirValorNegativo()
    {
        decimal valor = -100;

        bool valorValido = valor > 0;

        Assert.True(valorValido);
    }

    [Fact]
    public void NaoDevePermitirValorZero()
    {
        decimal valor = 0;

        bool valorValido = valor > 0;

        Assert.True(valorValido);
    }

    [Fact]
    public void NaoDevePermitirDataFutura()
    {
        DateTime dataTransacao = DateTime.Now.AddDays(5);

        bool dataValida = dataTransacao <= DateTime.Now;

        Assert.True(dataValida);
    }
}

