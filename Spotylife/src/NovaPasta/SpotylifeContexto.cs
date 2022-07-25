using Microsoft.EntityFrameworkCore;
using Spotylife.src.Model;

namespace Spotylife.src.NovaPasta
{
    public class Spotylife
    {
        /// <summary>
        /// <para>Resumo: Classe contexto, responsavel por carregar contexto e definir DbSets</para>
        /// <para>Criado por: Jose Vinicius </para>
        /// <para>Versão: 1.0</para>
        /// <para>Data: 25/07/2022</para>
        /// </summary>
        public class SpotylifeContexto : DbContext
        {
            public DbSet<UserModel> Users { get; set; }
            public DbSet<SongModel> Songs { get; set; }

            public SpotylifeContexto(DbContextOptions<SpotylifeContexto> opt) : base(opt)
            {

            }
        }
    }
}
