using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Spotylife.src.Model
{
    /// <summary>
    /// <para>Resumo: Classe responsavel por representar tb_usuarios no banco</para>
    /// <para>Criado por: Jose Vinicius </para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 25/07/2022</para>
    /// </summary>
    [Table("tb_users")]
    public class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required, StringLength(50)]
        public string Name { get; set; }
        
        [Required, StringLength(100)]
        public string Email { get; set; }

        [Required, StringLength(100)]
        public string Password { get; set; }

        [Required,StringLength(100)]
        public string Bio { get; set; }

        [JsonIgnore]
        public List<SongModel> MinhasMusicas { get; set; }
    }
}
