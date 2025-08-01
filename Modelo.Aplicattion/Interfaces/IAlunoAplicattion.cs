

using Modelo.Domain;

namespace Modelo.Aplicattion.Interfaces
{
   public interface IAlunoAplicattion
    {
        Aluno BuscarAluno(int id);

        void AdicionarAluno(Aluno aluno);
        void ExcluirAluno(int id);
    }
}
