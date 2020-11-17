//using Microsoft.EntityFrameworkCore;
//using System.IO;
//using System.Threading.Tasks;

//namespace HelloApp
//{
//    public class ApplicationContext : DbContext
//    {
//        private readonly StreamWriter logStream = new StreamWriter("mylog.txt", true);
//        public DbSet<User> Users { get; set; }
//        public ApplicationContext()
//        {
//            Database.EnsureDeleted();
//            Database.EnsureCreated();
//        }
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
//            optionsBuilder.LogTo(logStream.WriteLine);
//        }
//        public override void Dispose()
//        {
//            base.Dispose();
//            logStream.Dispose();
//        }

//        public override async ValueTask DisposeAsync()
//        {
//            await base.DisposeAsync();
//            await logStream.DisposeAsync();
//        }
//    }
//}