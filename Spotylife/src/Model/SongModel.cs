
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spotylife.src.Model
{
    /// <summary>
    /// <para>Resumo: Classe Responsavel por representar a Tb_musicas no banco</para>
    /// <para>Criado por: José Vinicius </para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 29/04/2022</para>
    /// </summary>
    /// 
    [Table("tb_musicas")]
    public class SongModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Titulo { get; set; }

        [Required, StringLength(50)]
        public string Descricao { get; set; }

        public string Foto { get; set; }

        [ForeignKey("fk_users")]
        public UserModel Criador { get; set; }
    }
}