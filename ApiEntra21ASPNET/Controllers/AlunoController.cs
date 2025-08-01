using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Modelo.Aplicattion.Interfaces;

namespace ApiEntra21ASPNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : Controller
    {
        private readonly IAlunoAplicattion _alunoAplicattion;

        public AlunoController(IAlunoAplicattion alunoAplicattion)
        {
            _alunoAplicattion = alunoAplicattion;
        }

        [HttpGet("BuscarDadosAluno/{id})")]

        public IActionResult BuscarDadosAluno(int id)
        {
            try
            {


                var aluno = _alunoAplicattion.BuscarAluno(id);

                return Ok(aluno);

            }
            catch (Exception ex)
            {

                return StatusCode(500, "Internal server error: " + ex.Message);
            }

        }

        [HttpPost("AdicionarAluno")]

        public IActionResult AdicionarAluno([FromBody] Modelo.Domain.Aluno aluno)
        {
            try
            {
                if (aluno == null)
                {
                    return BadRequest("Aluno cannot be null");
                }
                _alunoAplicattion.AdicionarAluno(aluno);
                return CreatedAtAction(nameof(BuscarDadosAluno), new { id = aluno.Id }, aluno);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }

        }

        [HttpDelete("ExcluirAluno/{id}")]
        public IActionResult ExcluirAluno(int id)
        {
            try
            {
                _alunoAplicattion.ExcluirAluno(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }

    }
}
