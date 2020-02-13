using Ders4.Models;
using System.Collections.Generic;
using Xamarin.Forms;
using SQLite;

namespace Ders4.Helper
{
    public class SQLiteManager
    {
        SQLiteConnection _sqlConnection;

        public SQLiteManager()
        {
            _sqlConnection = DependencyService.Get<ISQLiteConnection>().GetConnection();
            _sqlConnection.CreateTable<Student>();
        }

        #region CRUD
        public int Insert(Student student)
        {
            return _sqlConnection.Insert(student);
        }

        public int Update(Student student)
        {
            return _sqlConnection.Update(student);
        }

        public int Delete(int Id)
        {
            return _sqlConnection.Delete<Student>(Id);
        }

        public List<Student> GetAll()
        {
            return _sqlConnection.Table<Student>().ToList();
        }

        public Student Get(int Id)
        {
            return _sqlConnection.Table<Student>().FirstOrDefault(f => f.Id == Id);
        }

        public void Dispose()
        {
            _sqlConnection.Dispose();
        }

        #endregion

    }
}
