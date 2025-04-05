using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoP1.Dominio
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Nota { get; set; }

        public Aluno(string nome, decimal nota)
        {
            Nome = nome;
            Nota = nota;
        }

        public bool EstaAprovado()
        {
            return Nota > 7;
        }
    }
}
