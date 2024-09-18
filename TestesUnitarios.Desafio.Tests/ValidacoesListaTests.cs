using NuGet.Frameworks;
using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        List<int> lista = new List<int> { 5, -1, -8, 9 };
        List<int> resultadoEsperado = new List<int> { 5, 9 };

        // Act
        List<int> resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        List<int> lista = new List<int> { 5, -1, -8, 9 };
        int numeroParaProcurar = 9;

        // Act
        bool resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        // FEITO: Implementar método de teste

        // Arrange
        List<int> lista = new List<int> { 5, -1, -8, 9 };
        int numeroParaProcurar = 10;

        // Act
        bool resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.False(resultado);
    }

    // FEITO: Corrigir a anotação [Fact]
    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        // FEITO: Implementar método de teste

        // Arrange
        List<int> lista = new List<int> { 5, 7, 8, 9 };
        List<int> resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        
        // Act
        List<int> resultados = _validacoes.MultiplicarNumerosLista(lista, 2);

        // Assert
        Assert.Equal(resultadoEsperado, resultados);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        // FEITO: Implementar método de teste

        // Arrange
        List<int> lista = new List<int> { 5, -1, -8, 9 };

        // Act
        int resultado = _validacoes.RetornarMaiorNumeroLista(lista);

        // Assert
        Assert.Equal(9, resultado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        // FEITO: Implementar método de teste

        // Arrange
        List<int> lista = new List<int> { 5, -1, -8, 9 };

        // Act
        int resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        Assert.Equal(-8, resultado);
    }
}
