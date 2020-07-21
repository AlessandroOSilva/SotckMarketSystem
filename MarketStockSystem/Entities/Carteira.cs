using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStockSystem.Entities
{
    public class Carteira
    {
        public int Id { get; set; }
        public ICollection<Ativo> Comprados { get; set; }

        public void AdicionarAtivo(Ativo a)
        {
            Comprados.Add(a);
        }
    }
}
