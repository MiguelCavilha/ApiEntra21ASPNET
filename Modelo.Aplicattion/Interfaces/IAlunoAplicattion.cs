

using Modelo.Domain;

namespace Modelo.Aplicattion.Interfaces
{
   public interface IAlunoAplicattion
    {
        Aluno BuscarAluno(int id);

        string AdicionarAluno(Aluno aluno);
        void ExcluirAluno(int id);
    }
}
