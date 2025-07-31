using Microsoft.AspNetCore.Mvc;
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
                // Log the exception (not implemented here)
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
           
        }
    }
}
