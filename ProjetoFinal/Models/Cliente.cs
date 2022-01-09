using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [Required]
        public int IdCliente { get; set; }

        [StringLength(100)]
        [Required (ErrorMessage ="Digite seu nome!")]
        public string Nome { get; set; }

        [StringLength(11)]
        [Required(ErrorMessage = "Digite seu CPF!")]

        public string Cpf { get; set; }

        [StringLength(45)]
        [Required(ErrorMessage = "Digite seu E-mail!")]

        public string Email { get; set; }

        [StringLength(8)]
        [Required(ErrorMessage = "Digite uma senha de até 8 caracteres!")]

        public string Senha { get; set; }

        [StringLength(11)]
        [Required(ErrorMessage = "Digite seu número de telefone com DDD!")]

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
