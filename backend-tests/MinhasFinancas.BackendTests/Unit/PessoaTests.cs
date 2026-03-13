using Xunit;

namespace MinhasFinancas.BackendTests.Unit;

public class PessoaTests
{
    [Fact]
    public void NaoDevePermitirCpfDuplicado()
    {
        var cpf1 = "12345678900";
        var cpf2 = "12345678900";

        bool cpfsIguais = cpf1 == cpf2;

        Assert.False(cpfsIguais);
    }
}