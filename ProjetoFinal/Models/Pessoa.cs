using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(11)]
        public string Cpf { get; set; }

        [StringLength(45)]
        public string Email { get; set; }

        [StringLength(8)]
        public string Senha { get; set; }

        [StringLength(11)]
        public string Telefone { get; set; }

        [StringLength(80)]
        public string Endereco { get; set; }

        [StringLength(8)]
        public string Cep { get; set; }

        [StringLength(45)]
        public string Cidade { get; set; }

        [StringLength(2)]
        public string Uf { get; set; }
    }
}
