using System.IO;
using Ders4.Droid.ConnectionHelper;
using Ders4.Helper;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(GetDroidConnection))]
namespace Ders4.Droid.ConnectionHelper
{
    public class GetDroidConnection : ISQLiteConnection
    {
        public SQLiteConnection GetConnection()
        {
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            var path = Path.Combine(documentPath, App.DbName);
            //var platform = new SQLitePlatformAndroid();
            var connection = new SQLiteConnection(path);
            
            return connection;

        }
    }
}