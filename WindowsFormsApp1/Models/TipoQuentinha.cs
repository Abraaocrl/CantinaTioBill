using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
	public class TipoQuentinha
	{
		public int Id { get; set; }
		[Required]
		public string Descricao { get; set; }
		public decimal Valor { get; set; }
	}
}
