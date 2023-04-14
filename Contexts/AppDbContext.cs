//TODO Instalar dependências 
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using aplicativoweb.Models;
using aplicativoweb.EntityConfigs;
public class  AppDbContext:DbContext{
public DbSet<Curso> Cursos => Set<Curso>(); //representa a tabela
protected override void OnConfiguring(DbContextOptionsBuilder builder){

    
    builder.UseSqlServer("Server=LAB-F08-06;Database=EscolaDotNet;User Id=sa;Password=senai@123;TrustServerCertificate=True");
}

protected override void OnModelCreating(ModelBuilder builder){
    builder.ApplyConfiguration(new CursoEntityConfig());
}


}