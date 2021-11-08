using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pi.Univesp.Models
{
    public class Aluno
    {
        //[Key]
        public int AlunoId { get; set; }

        public string Nome { get; set; }

        public int RA { get; set; }


        // diferença entre float e decimal no C#
        public float Nota { get; set; }
        
    }
}
