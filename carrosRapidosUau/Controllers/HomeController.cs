using carrosRapidosUau.Models;
using Microsoft.AspNetCore.Mvc;
using Servico.model;
using Servico;
using System.Diagnostics;

namespace carrosRapidosUau.Controllers
{
    public class HomeController : Controller
    {
        private static List<Carros> _List = new List<Carros>()
        {
            new Carros() { id = 1 , nome = "carro legal", fabricante = "fabricante boa", marca = "marca bonita", modelo = "modelo foda", ano = 2001 },
            new Carros() { id = 2 , nome = "carro legal 2", fabricante = "fabricante boa 2", marca = "marca bonita 2", modelo = "modelo foda 2", ano = 2002 },
        };

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult Carro()
        {
            var db = new Db();

            var listaTO = db.GetCarros();

            var listaCarro = new List<Carros>();

            foreach (var carroTO in listaTO)
            {
                listaCarro.Add(new Carros() { 
                    id = carroTO.Id, 
                    nome = carroTO.Nome, 
                    fabricante = carroTO.Fabricante, 
                    marca = carroTO.Marca, 
                    modelo = carroTO.Modelo, 
                    ano = carroTO.Ano
                }
                );
            }


            var viewModel = new CarrosViewModel() { listCarro = listaCarro };

            return View(viewModel);
        }

        public IActionResult CadastrarCarro(int? id)
        {
            Carros? carro = null;

            if (id != null)
            {
                var db = new Db();

                var carroTO = db.GetCarroById(id.GetValueOrDefault());

                carro = new Carros()
                {
                    id = carroTO.Id,
                    nome = carroTO.Nome,
                    fabricante = carroTO.Fabricante,
                    marca = carroTO.Marca,
                    modelo = carroTO.Modelo,
                    ano = carroTO.Ano
                };
            }

            return View(carro);
        }

        public IActionResult PersistirCarro(int? id, string nome, string fabricante, string marca, string modelo, string ano)
        {
            var db = new Db();
            if (id == null)
            {
                var novoCarro = new CarroTO()
                {
                    Nome = nome,
                    Fabricante = fabricante,
                    Marca = marca,
                    Modelo = modelo,
                    Ano = int.Parse(ano),

                };

                db.AddCarro(novoCarro);
            }
            else
            {
                var alterarCarro = new CarroTO()
                {
                    Id = id.GetValueOrDefault(),
                    Nome = nome,
                    Fabricante = fabricante,
                    Marca = marca,
                    Modelo = modelo,
                    Ano = int.Parse(ano),
                };

                db.UpdateCarro(alterarCarro);
            }

            return RedirectToAction("Carro");
        }

        public IActionResult Deletar(int Id)
        {
            var db = new Db();

            db.DeletarCarro(Id);

            return RedirectToAction("Carro");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
