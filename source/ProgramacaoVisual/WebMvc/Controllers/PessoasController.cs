using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class PessoasController : Controller
    {
        private static IList<Pessoa> pessoaList = new List<Pessoa>
        {
            new Pessoa{Id = 1 , Nome = "Joao" },
            new Pessoa{Id = 2 , Nome = "Juao" },
            new Pessoa{Id = 3 , Nome = "Jonh" }
        };

        //Actions

        //localhost:5000/Pessoas/Index
        public IActionResult Index()
        {
            //Busca dos dados
            //Transforma os dados recebidos em dados de visualização

            var viewModel = new PessoaViewModel
            {
                Items = pessoaList
            };
            //Visualização dos dados
            return View(viewModel);

        }
    }
}