
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




    }
}
