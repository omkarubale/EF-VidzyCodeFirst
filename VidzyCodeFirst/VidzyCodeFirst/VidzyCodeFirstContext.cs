namespace VidzyCodeFirst
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using VidzyCodeFirst.Entities;
    using VidzyCodeFirst.EntityConfigurations;

    public class VidzyCodeFirstContext : DbContext
    {
        // Your context has been configured to use a 'VidzyCodeFirstContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'VidzyCodeFirst.VidzyCodeFirstContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'VidzyCodeFirstContext' 
        // connection string in the application configuration file.
        public VidzyCodeFirstContext()
            : base("name=VidzyCodeFirstContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VideoConfiguration());
            modelBuilder.Configurations.Add(new GenreConfiguration());
            modelBuilder.Configurations.Add(new TagConfiguration());
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}