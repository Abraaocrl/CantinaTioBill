using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
	public class Cliente
	{
		public int Id { get; set; }
		[StringLength(100)]
		[Required]
		public string Nome { get; set; }
		[StringLength(100)]
		public string Email { get; set; }
		public string Celular { get; set; }
	}
}
