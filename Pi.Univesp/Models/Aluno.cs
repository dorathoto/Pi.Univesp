using System.Collections.Generic;

namespace Pi.Univesp.Models
{
    public class Aluno
    {
        //[Key]
        public int AlunoId { get; set; }

        public string Nome { get; set; }

        public int RA { get; set; }

        public virtual ICollection<Nota> Notas { get; set; }


    }
}
