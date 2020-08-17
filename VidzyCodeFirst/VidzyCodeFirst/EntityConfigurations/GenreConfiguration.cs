using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidzyCodeFirst.Entities;
using System.Data.Entity.ModelConfiguration;

namespace VidzyCodeFirst.EntityConfigurations
{
    public class GenreConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenreConfiguration()
        {
            Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(255);
        }
    }
}
