using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacFoods
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // criar as propriedades
        // id int,
        public int Id { get; set; }
        // nome string,
        public string Nome { get; set; }
        // email string,
        public string Email { get; set; }
        // senha string,
        public string Senha { get; set; }
        // ativo bool
        public bool Ativo {  get; set; }


    }
}
