using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStockSystem.Entities
{
    abstract class Ativo
    {
        public int Id { get; set; }
        public string CodAtivo { get; set; }
        public double CotacaoAtual { get; set; }

        public Ativo()
        {

        }

        protected Ativo(int id, string codAtivo, double cotacaoAtual)
        {
            Id = id;
            CodAtivo = codAtivo;
            CotacaoAtual = cotacaoAtual;
        }
    }
}
