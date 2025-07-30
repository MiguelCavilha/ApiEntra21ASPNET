using Microsoft.AspNetCore.Mvc;

namespace ApiEntra21ASPNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : Controller
    {
        // GET: Aluno
        [HttpGet("BuscarDadosAluno/{id})")]

        public IActionResult BuscarDadosAluno(int id)
        {
            try
            {

                // Simulate fetching data from a database or service
                var aluno = new
                {
                    Id = id,
                    Nome = "João da Silva",
                    Idade = 20,
                    Cep = "12345-678"
                };
                if (aluno == null)
                {
                    return NotFound("Aluno not found.");
                }
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
