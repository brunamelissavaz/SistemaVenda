using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVenda.DAL;
using SistemaVenda.Models;

namespace SistemaVenda.Controllers
{
    public class RelatorioController : Controller
    {
        protected ApplicationDbContext mContext;

        public RelatorioController(ApplicationDbContext context)
        {
            mContext = context;
        }

        public IActionResult Grafico()
        {
           /* var lista = mContext.VendaProdutos
                .GroupBy(x => x.CodigoProduto)
                .Select(y => new GraficoViewModel
                {
                    CodigoProduto = y.First().CodigoProduto,
                    Descricao = y.First().Produto.Descricao,
                    TotalVendido = y.Sum(z => z.Quantidade)
                }).ToList();*/

            return View();
        }
    }
}
