﻿using Microsoft.EntityFrameworkCore;
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
    public class RepositorioUsuario : Repositorio<Usuario>, IRepositorioUsuario
    {
        public RepositorioUsuario(ApplicationDbContext dbContext) : base(dbContext) 
        {  
          
        }
        public bool ValidarLogin(string email, string senha)
        {
            var usuario = DbSetContext.Where(x => x.Email == email && x.Senha == senha).FirstOrDefault();
            return  (usuario == null) ? false : true; 
            
        }

    }
}
