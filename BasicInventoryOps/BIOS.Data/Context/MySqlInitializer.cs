using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace BIOS.Data.Context
{
    internal class MySqlInitializer : IDatabaseInitializer<BIOSContext>
    {
        public void InitializeDatabase(BIOSContext context)
        {
            if (!context.Database.Exists())
            {
                context.Database.Create();
            }
            else
            {
                var migrationHistoryTableExists = ((IObjectContextAdapter)context).ObjectContext.ExecuteStoreQuery<int>(string.Format("SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = '{0}' AND table_name = '__MigrationHistory'", "[Insert your database schema here such as 'users']"));

                if(migrationHistoryTableExists.FirstOrDefault() == 0)
                {
                    context.Database.Delete();
                    context.Database.Create();

                }
            }
        }
    }
}