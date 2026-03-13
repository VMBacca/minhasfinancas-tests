using Xunit;

namespace MinhasFinancas.BackendTests.Unit;

public class CategoriaTests
{
    [Fact]
    public void CategoriaDespesa_NaoDevePermitirReceita()
    {
        var finalidade = "Despesa";
        var tipoTransacao = "Receita";

        var permite = finalidade == "Despesa" && tipoTransacao == "Receita";

        Assert.False(permite);
    }
}