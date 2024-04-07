using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpotLite.Application.Streaming.Dto;
using SpotLite.Application.Streaming;

namespace SpotLite.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BandaController : ControllerBase
    {
        private BandaService _bandaService;

        public BandaController(BandaService bandaService)
        {
            _bandaService = bandaService;
        }

        [HttpGet]
        public IActionResult GetBandas()
        {
            var result = this._bandaService.Obter();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetBandas(Guid id)
        {
            var result = this._bandaService.Obter(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Criar([FromBody] BandaDto dto)
        {
            if (ModelState is { IsValid: false })
                return BadRequest();

            var result = this._bandaService.Criar(dto);

            return Created($"/banda/{result.Id}", result);
        }

        [HttpPost("{id}/albums")]
        public IActionResult AssociarAlbum(AlbumDto dto)
        {
            if (ModelState is { IsValid: false })
                return BadRequest();

            var result = this._bandaService.AssociarAlbum(dto);

            return Created($"/banda/{result.BandaId}/albums/{result.Id}", result);

        }


        [HttpGet("{idBanda}/albums/{id}")]
        public IActionResult ObterAlbumPorId(Guid idBanda, Guid id)
        {
            var result = this._bandaService.ObterAlbumPorId(idBanda, id);

            if (result == null)
                return NotFound();

            return Ok(result);

        }

        [HttpGet("{idBanda}/albums")]
        public IActionResult ObterAlbuns(Guid idBanda)
        {
            var result = this._bandaService.ObterAlbum(idBanda);

            if (result == null)
                return NotFound();

            return Ok(result);

        }


        [HttpGet("Musicas")]
        public IActionResult ObterMusicasPorNome([FromQuery] string nomeMusica)
        {
            var result = this._bandaService.ObterMusicasPorNome(nomeMusica);

            if (result == null || result.Count() == 0)
                return NotFound();

            return Ok(result);
        }

        [HttpPost("favoritar/{idMusica}")]
        public IActionResult MarcarComoFavorita(Guid idMusica)
        {
            try
            {
                _bandaService.MarcarComoFavorita(idMusica);
                return Ok("Música marcada como favorita com sucesso.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao marcar como favorita: {ex.Message}");
            }
        }

        [HttpGet("favoritas")]
        public IActionResult ObterMusicasFavoritas()
        {
            try
            {
                var musicasFavoritas = _bandaService.ObterMusicasFavoritas();
                return Ok(musicasFavoritas);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao obter músicas favoritas: {ex.Message}");
            }
        }
    }
}
