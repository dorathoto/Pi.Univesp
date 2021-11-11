using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pi.Univesp.Models
{
    public class Nota
    {
        public int NotaId { get; set; }

        public int AlunoId { get; set; }

        public Guid DisciplinaId { get; set; }

        public float ValorNota { get; set; }
        public DateTime Data { get; set; }

        public virtual Aluno Aluno { get; set; }
        public virtual Disciplina Disciplina { get; set; }
    }
}
