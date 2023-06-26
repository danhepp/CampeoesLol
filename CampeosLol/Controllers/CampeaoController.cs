using CampeosLol.Models;
using Microsoft.AspNetCore.Mvc;

namespace CampeosLol.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CampeaoController : ControllerBase
    {
        private static List<Campeao> campeoes = new List<Campeao>();

        [HttpPost]
        public void AdicionaCampeao([FromBody]Campeao campeao)
        {
            campeoes.Add(campeao);
            Console.WriteLine(campeao.Nome);
        }

        [HttpGet]
        public IEnumerable<Campeao> ListaCampeos() 
        {
            return campeoes;
        }

        [HttpGet("{nome}")]
        public Campeao? RecuperaCampeaoPorNome (string nome)
        {
            return campeoes.FirstOrDefault(campeao => campeao.Nome == nome);
        }
    }
}