using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pi.Univesp.Models
{
    /// <summary>
    /// ao invés de int a PK será Guid (hash)
    /// </summary>
    public class Disciplina
    {
        
        public Guid DisciplinaId { get; set; }

        [MaxLength(50)]
        public string Nome { get; set; }

        public virtual ICollection<Nota> Notas { get; set; }
    }
}
