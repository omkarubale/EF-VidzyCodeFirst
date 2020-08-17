using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidzyCodeFirst.Entities;

namespace VidzyCodeFirst.EntityConfigurations
{
    public class VideoConfiguration : EntityTypeConfiguration<Video>
    {
        public VideoConfiguration()
        {
            Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255);

            HasRequired(e => e.Genre)
                .WithMany(e => e.Videos)
                .HasForeignKey(e => e.GenreId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.Tags)
                .WithMany(e => e.Videos)
                .Map(m => {
                    m.ToTable("VideoTags");
                    m.MapLeftKey("VideoId");
                    m.MapRightKey("TagId");
                });
        }
    }
}
