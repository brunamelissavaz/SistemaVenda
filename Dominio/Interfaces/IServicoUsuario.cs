using SistemaVenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Interfaces
{
    public interface IServicoUsuario : IServicoCRUD<Usuario>
    {
        public bool ValidarLogin(string email, string senha);
    }
}
