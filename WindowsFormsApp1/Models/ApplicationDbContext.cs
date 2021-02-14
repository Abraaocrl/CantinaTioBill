using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
	class ApplicationDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=ABRAAO-PC;Initial Catalog=CantinaTioBill;Integrated Security=True");
		}
		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<TipoQuentinha> TiposQuentinha { get; set; }
		public DbSet<Venda> Vendas { get; set; }
		public DbSet<VendaItem> VendaItens { get; set; }
	}
}
