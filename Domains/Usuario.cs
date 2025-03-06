using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API_Filmes_SENAI.Domains
{
    [Table("Usuario")]
    [Index(nameof(Email), IsUnique = true)]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "o nome é obrigatorio")]

        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "o email é obrigatorio")]

        public string? Email { get; set; }

        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "a senha é obrigatoria")]
        [StringLength(60, MinimumLength = 6, ErrorMessage = "A senha deve conter no minimo 6 caracteres e no maximo 60")]

        public string? Senha { get; set; }
    }
}
