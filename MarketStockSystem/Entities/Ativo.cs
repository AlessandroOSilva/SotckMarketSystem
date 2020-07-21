using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStockSystem.Entities
{
    abstract class Ativo
    {
        public int Id { get; set; }
        [MaxLength(6)]
        [MinLength(5)]
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
