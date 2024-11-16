using System;
using Microsoft.EntityFrameworkCore;
using StudentApi.Models;

namespace StudentApi.Data;

public class StudentContext : DbContext
{
    public StudentContext(DbContextOptions options) : base(options) {}
	public StudentContext() : base(new DbContextOptions<StudentContext>())
	{
	}
	public DbSet<Student> Students { get; set; }
}