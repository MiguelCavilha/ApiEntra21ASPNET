
using Modelo.Aplicattion.Interfaces;
using Modelo.Domain;
using Modelo.Infra.Repositorio.Interfaces;

namespace Modelo.Aplicattion
{
    public class AlunoAplicattion : IAlunoAplicattion
    {
        private readonly IAlunoRepositorio _alunoRepositorio;

        public AlunoAplicattion(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }


        public Aluno BuscarAluno(int id)
        {
            return _alunoRepositorio.BuscarID(id);


        }

        public string AdicionarAluno(Aluno aluno)
        {
            var mensagem = ValidarAluno(aluno);
            if (mensagem == "")
            _alunoRepositorio.AdicionarAluno(aluno);
            return (mensagem);
            
            
        }

        public void ExcluirAluno(int id)
        {
            _alunoRepositorio.ExcluirAluno(id);
        }

        private string ValidarAluno(Aluno aluno)
        {
            if (string.IsNullOrEmpty(aluno.Nome))
            {
                return "O nome do aluno é obrigatório.";
            }
            if (aluno.Idade <= 0)
            {
                return "A idade do aluno deve ser maior que zero.";
            }
            if (string.IsNullOrEmpty(aluno.CEP))
            {
                return "O CEP do aluno é obrigatório.";
            }
            return string.Empty;
        }


    }
}
