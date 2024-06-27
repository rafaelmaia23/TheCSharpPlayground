namespace TheCSharpPlayground.TestesTecnicos;

public class Matematica
{
    public int Soma(int a, int b) => a + b;

    public void SomaEProduto(int a, int b, out int soma, out int produto)
    {
        soma = a + b;
        produto = a * b;
    }

    int CalculaSomaDDeImparesEntre100e200()
    {
        int soma = 0;
        for (int i = 100; i <= 200; i++)
        {
            if (i % 2 != 0)
            {
                soma += i;
            }
        }
        return soma;
    }
}
