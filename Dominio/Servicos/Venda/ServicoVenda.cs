using Dominio.Interfaces;
using Dominio.Repositorio;
using SistemaVenda.Dominio.DTO;
using SistemaVenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;


namespace Dominio.Servicos
{
    public class ServicoVenda : IServicoVenda
    {
        IRepositorioVenda RepositorioVenda;
        IRepositorioVendaProdutos RepositorioVendaProdutos;


        public ServicoVenda(IRepositorioVenda repositorioVenda, IRepositorioVendaProdutos repositorioVendaProdutos)
        {
            RepositorioVenda = repositorioVenda;
            RepositorioVendaProdutos = repositorioVendaProdutos;

        }

        public void Cadastrar(Venda venda)
        {
            RepositorioVenda.Create(venda);
        }

        public Venda CarregarRegistro(int id)
        {
            return RepositorioVenda.Read(id);
        }

        public void Excluir(int id)
        {
            RepositorioVenda.Delete(id);
        }

        public IEnumerable<Venda> Listagem()
        {
            return RepositorioVenda.Read();

         
        }

        public IEnumerable<GraficoViewModel> ListaGrafico()
        {
            return RepositorioVendaProdutos.ListaGrafico();                      
        }
    }
}
