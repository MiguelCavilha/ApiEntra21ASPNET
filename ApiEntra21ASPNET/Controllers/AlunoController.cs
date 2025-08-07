using Microsoft.AspNetCore.Mvc;
using Modelo.Aplicattion.Interfaces;
using Modelo.Domain;

namespace ApiEntra21.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : Controller
    {
        private readonly IAlunoAplicattion _alunoApplication;

        public AlunoController(IAlunoAplicattion alunoApplication)
        {
            _alunoApplication = alunoApplication;
        }

        [HttpGet("BuscarDadosAluno/{id}")]
        public IActionResult BuscarDadosAluno(int id)
        {
            Retorno<Aluno> retorno = new(null);

            try
            {
                var aluno = _alunoApplication.BuscarAluno(id);

                if (aluno != null)
                {
                    retorno.CarregaRetorno(aluno, true, "Consulta realizada com Sucesso!", 200);
                }
                else
                {
                    retorno.CarregaRetorno(aluno, false, $"Aluno com id: {id} não foi encontrado", 204);
                }


                return Ok(retorno);
            }
            catch (Exception e)
            {

                retorno.CarregaRetorno(false, e.Message, 400);
                return BadRequest();
            }
        }
        [HttpPost("InserirDadosAluno")]
        public IActionResult InserirDadosAluno([FromBody] Aluno aluno)
        {
            Retorno retorno = new();
            try
            {
                var mensagem = _alunoApplication.AdicionarAluno(aluno);
                retorno.CarregaRetorno(string.IsNullOrEmpty(mensagem), mensagem, 200);

                _alunoApplication.AdicionarAluno(aluno);

                return Ok(retorno);
            }
            catch (Exception e)
            {
                retorno.CarregaRetorno(false, e.Message, 400);
                return BadRequest();
            }
        }
        [HttpDelete("ExcluirDadosAluno/{id}")]
        public IActionResult ExcluirDadosAluno(int id)
        {
            try
            {
                _alunoApplication.ExcluirAluno(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
    }

}