using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevisaoP1.Dominio;

namespace RevisaoP1.Repositorio
{
    public interface IAlunoRepositorio
    {
        void Salvar(Aluno aluno);
        IEnumerable<Aluno> Listar();
    }
}
