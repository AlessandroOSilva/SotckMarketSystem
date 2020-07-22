using MarketStockSystem.Entities;
using MarketStockSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStockSystem.Services
{
    class CadastroService : ICadastrable
    {

        protected Acao _a = new Acao();

        public CadastroService(Acao a)
        {
            _a = a;
        }

        public void CadastrarAcao(Acao a)
        {
            _a.CodAtivo = a.CodAtivo;
            _a.Empresa = a.Empresa;
            _a.Segmento = a.Segmento;
            _a.CotacaoAtual = a.CotacaoAtual;
            _a.LucroAnoAnt = a.LucroAnoAnt;
            _a.PatrimonioLiquido= a.PatrimonioLiquido;
            _a.QuantAcoes = a.QuantAcoes;
        }

    }
}
