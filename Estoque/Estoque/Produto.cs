using System;
using System.Globalization;


namespace Estoque
{
    internal class Produto
    {

        public string Nome;
        public double Valor;
        public int Quantidade;
    
    
        public double ValorTotalemEstoque() // Primeiro Método
        {
            return Valor * Quantidade;
        }


        public void AdicionarProdutos(int quantidade) // O método Void Significa que não irá retornar valor, Nesse caso ele irá adicionar valores no Programa Principal
        {
            Quantidade += quantidade;

        }

        public void RemoverProdutos(int remocao) // Esse Método irá remover valores no Programa principal
        {
            Quantidade -= remocao;
        }






        public override string ToString()
        {
            return $" Produto: {Nome}, Valor: {(Valor).ToString("f2", CultureInfo.InvariantCulture)}, Quantidade: {Quantidade}, Total {(Valor * Quantidade).ToString("f2", CultureInfo.InvariantCulture)}";
        }














    }
}
