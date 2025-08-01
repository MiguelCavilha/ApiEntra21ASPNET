using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Domain;
using Modelo.Infra.Repositorio.Interfaces;

namespace Modelo.Infra.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly BancoContexto _bancoContexto;

        public AlunoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public Aluno BuscarID(int id) => _bancoContexto.Aluno.FirstOrDefault(x => x.Id == id);
        public void AdicionarAluno(Aluno aluno)
        {
            _bancoContexto.Aluno.Add(aluno);
            _bancoContexto.SaveChanges();
        }

        public void ExcluirAluno(int id)
        {
            var aluno = BuscarID(id);
            if (aluno != null)
            {
                _bancoContexto.Aluno.Remove(aluno);
                _bancoContexto.SaveChanges();
            }
            else
            {
                throw new Exception("Aluno não encontrado");
            }
        }
    }
}


