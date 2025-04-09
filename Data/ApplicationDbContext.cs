using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityManager.Data;


public class ApplicationDbContext : IdentityDbContext
{
	public ApplicationDbContext(DbContextOptions options) : base(options)
	{
	}

	protected override void OnConfiguring(DbContextOptionsBuilder options) => 
	options.UseSqlServer("Server=localhost;initial catalog=iii;Trusted_Connection=True;multipleactiveresultsets=true;TrustServerCertificate=True");
}
