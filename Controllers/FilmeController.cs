using filme_web_api.Models;
using filme_web_api.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace filme_web_api.Controllers
{
    [ApiController]
    [Route("api/filmes")]
    public class FilmeController : ControllerBase
    {
        private readonly IFilmeRepository _filmeRepository;

        public FilmeController(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }

        [HttpPost]
        public IActionResult Add(FilmeViewModel filmeViewModel)
        {
            var filme = new Filme(filmeViewModel.Titulo, filmeViewModel.Sinopse, filmeViewModel.Genero, null, DateTime.UtcNow);
            _filmeRepository.Add(filme);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var filmes = _filmeRepository.GetAll();
            return Ok(filmes);
        }
    }
}
