using MarketStockSystem.Entities.Enums;
using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YahooFinanceApi;

namespace MarketStockSystem.Entities
{
    public class Acao : Ativo
    {
        [Required]
        [MaxLength(100)]
        [MinLength(5)]
        public string Empresa { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(5)]
        public SegmentoEmpresa Segmento { get; set; }
        public double Preco { get; set; }
        public double LucroAnoAnt { get; set; }
        public int QuantAcoes { get; set; }
        public double DividaLiquida { get; set; }
        public double PatrimonioLiquido { get; set; }

        public Acao()
        {

        }

        public Acao(string codAtivo, double cotacaoAtual, string empresa, SegmentoEmpresa segmento, double lucroAnoAnt, int quantAcoes, double dividaLiquida, double patrimonioLiquido)
            : base(codAtivo, cotacaoAtual)
        {
            Empresa = empresa;
            Segmento = segmento;
            LucroAnoAnt = lucroAnoAnt;
            QuantAcoes = quantAcoes;
            DividaLiquida = dividaLiquida;
            PatrimonioLiquido = patrimonioLiquido;
        }

        public double CalcularRoe()
        {
            double roe = 0;

            return roe;
        }

        public double CacularPl()
        {
            double pl = 0;

            return pl;
        }

    }
}
