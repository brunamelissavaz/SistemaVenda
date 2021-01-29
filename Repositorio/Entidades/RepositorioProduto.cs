using Microsoft.EntityFrameworkCore;
using Repositorio.Interfaces;
using SistemaVenda.Dominio.Entidades;
using Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;
using Repositorio.Contexto;
using System.Linq;

namespace Repositorio.Entidades
{
    public class RepositorioProduto : Repositorio<Produto>, IRepositorioProduto
    {
        public RepositorioProduto(ApplicationDbContext dbContext) : base(dbContext) 
        {  
          
        }

        public override IEnumerable<Produto> Read()
        {
            return DbSetContext.Include(x => x.Categoria).AsNoTracking().ToList();
        }

    }
}
