using AutoMapper;
using CampeoesLol.Data;
using CampeoesLol.Data.Dtos;
using CampeosLol.Models;
using Microsoft.AspNetCore.Mvc;

namespace CampeosLol.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CampeaoController : ControllerBase
    {
        private CampeaoContext _context;
        private IMapper _mapper;

        public CampeaoController(CampeaoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaCampeao([FromBody] CreateCampeaoDto campeaoDto)
        {
            Campeao campeao = _mapper.Map<Campeao>(campeaoDto);
            _context.Campeoes.Add(campeao);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaCampeaoPorNome), new { nome = campeao.Nome }, campeao);
        }

        [HttpGet]
        public IEnumerable<Campeao> ListaCampeos([FromQuery] int skip = 0, [FromQuery] int take = 20) 
        {
            return _context.Campeoes.Skip(skip).Take(take);
        }

        [HttpGet("{nome}")]
        public IActionResult RecuperaCampeaoPorNome (string nome)
        {
            var campeao = _context.Campeoes.FirstOrDefault(campeao => campeao.Nome == nome);
            if (campeao == null) return NotFound();
            return Ok(campeao);
        }
    }
}