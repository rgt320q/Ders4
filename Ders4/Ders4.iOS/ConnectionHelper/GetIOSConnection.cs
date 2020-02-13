using System.IO;
using Ders4.Helper;
using Ders4.iOS.ConnectionHelper;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(GetIOSConnection))]
namespace Ders4.iOS.ConnectionHelper
{
    class GetIOSConnection : ISQLiteConnection
    {
        public SQLiteConnection GetConnection()
        {
           
                string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

                var path = Path.Combine(documentPath, App.DbName);
                //var platform = new SQLitePlatformIOS();
                var connection = new SQLiteConnection(path);

                return connection;

        }
    }
}