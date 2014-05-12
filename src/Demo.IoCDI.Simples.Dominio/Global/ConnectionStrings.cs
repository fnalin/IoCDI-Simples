
namespace Demo.IoCDI.Simples.Dominio.Global
{
    public class ConnectionStrings
    {
        private static string sqlExpress;

        static ConnectionStrings()
        {
            sqlExpress = @"Data Source=.\sqlexpress;Initial Catalog=DemoIOCDIC;Integrated Security=True;MultipleActiveResultSets=True";
            LocalDB = @"Server=(localdb)\v11.0;AttachDbFilename=|DataDirectory|DemoIOCDICLocal.mdf;
                Database=DemoIOCDICLocal;Trusted_Connection=Yes;";
        }

        public static string SQLExpress { get { return sqlExpress;} }
        public static string LocalDB { get; private set; }

    }
}
