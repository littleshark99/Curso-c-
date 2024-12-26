﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Teste
{
    internal class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;



        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }


        public void AdicionarProdutos(int  quantidade) {

            Quantidade +=  quantidade;

        }

        public void RemoverProdutos(int quantidade)
        {

            Quantidade -= quantidade;

        }




        public override string ToString()
        {
            return Nome + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", quantidade em estoque "
                + Quantidade
                + " Total: $" + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture) ;


        }



    }
}
