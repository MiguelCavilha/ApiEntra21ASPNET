using System;
using System.Collections.Generic;
using Modelo.Domain;

namespace Modelo.Infra.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {
        Aluno BuscarID(int id);

        void AdicionarAluno(Aluno aluno);

        void ExcluirAluno(int id);

    }
}
