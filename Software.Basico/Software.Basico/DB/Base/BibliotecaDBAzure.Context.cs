﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Software.Basico.DB.Base
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AzureBiblioteca : DbContext
    {
        public AzureBiblioteca()
            : base("name=AzureBiblioteca")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_aluno> tb_aluno { get; set; }
        public virtual DbSet<tb_autor> tb_autor { get; set; }
        public virtual DbSet<tb_curso> tb_curso { get; set; }
        public virtual DbSet<tb_emprestimo> tb_emprestimo { get; set; }
        public virtual DbSet<tb_estoque> tb_estoque { get; set; }
        public virtual DbSet<tb_genero> tb_genero { get; set; }
        public virtual DbSet<tb_livro> tb_livro { get; set; }
        public virtual DbSet<tb_turma> tb_turma { get; set; }
        public virtual DbSet<tb_turma_aluno> tb_turma_aluno { get; set; }
    }
}
