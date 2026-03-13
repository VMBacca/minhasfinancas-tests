using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace MinhasFinancas.BackendTests.Integration;

public class ApiTests
{
    [Fact]
    public async Task Api_DeveResponderStatusOK()
    {
        using var client = new HttpClient();

        var response = await client.GetAsync("http://localhost:5000");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}