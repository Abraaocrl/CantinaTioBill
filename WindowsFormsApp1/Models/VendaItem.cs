using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
	class VendaItem
	{
		public int Id { get; set; }
		public int TipoQuentinhaId { get; set; }
		public TipoQuentinha TipoQuentinha { get; set; }
		public int Quantidade { get; set; }
		public decimal ValorPagoUnidade { get; set; }
		public int VendaId { get; set; }
		public Venda Venda { get; set; }
	}
}
