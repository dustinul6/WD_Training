using ModelCollections.ModelBuilers;

namespace ModelCollections.Models
{
    using System.Data.Entity;

    public partial class ModelDbContext : DbContext
    {
        public ModelDbContext()
            : base("name=connection1")
        {
        }

        private PURBuilder _purBuilder = new PURBuilder();
        private SALBuilder _salBuilder = new SALBuilder();
        private PCMBuilder _pcmBuilder = new PCMBuilder();

        public virtual DbSet<PCM010> PCM010 { get; set; }
        public virtual DbSet<PUR010> PUR010 { get; set; }
        public virtual DbSet<PUR070> PUR070 { get; set; }
        public virtual DbSet<SAL041> SAL041 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            _purBuilder.PUR070(modelBuilder);
            _purBuilder.PUR010(modelBuilder);
            _salBuilder.SAL041(modelBuilder);
            _pcmBuilder.PCM010(modelBuilder);

            
        }
    }
}
