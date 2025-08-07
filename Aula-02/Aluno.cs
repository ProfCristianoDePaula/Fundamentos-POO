using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02
{
    // Exemplo de classe Aluno que herda da Classe Pessoa
    public class Aluno : Pessoa
    {
        public string? Curso { get; set; }
        public int? Matricula { get; set; }
    }
}
