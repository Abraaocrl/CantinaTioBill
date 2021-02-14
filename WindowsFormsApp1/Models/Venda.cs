using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
	public class Venda
	{
		public int Id { get; set; }
		public int ClienteId { get; set; }
		public Cliente Cliente { get; set; }
		public decimal? ValorFrete { get; set; }
		public DateTime? DataPedido { get; set; }
		public DateTime? DataEntrega { get; set; }
		public DateTime? DataCancelado { get; set; }
	}
}
