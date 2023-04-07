using Microsoft.EntityFrameworkCore;
using OrganizationProject.Models;

namespace OrganizationProject.Contexts;

public class MyContext : DbContext
{
	public MyContext(DbContextOptions<MyContext> options) : base(options)
	{

	}
    public DbSet<Account> Accounts { get; set; }
    public DbSet<AccountRole> AccountRoles { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<DocumentType> DocumentTypes { get; set; }
    public DbSet<Finance> Finances { get; set; }
    public DbSet<Major> Majors { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Title> Titles { get; set; }
    public DbSet<WorkProgram> WorkPrograms { get; set; }

    protected override void OnModelCreating (ModelBuilder modelBuilder)
    {
        base.OnModelCreating (modelBuilder);
        modelBuilder.Entity<Member>().HasIndex(m => new
        { 
            m.PhoneNumber, m.Email
        }).IsUnique();
    }
}
