using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Configuration;
using Dapper;

namespace PasswordManager
{
    //this class is responsible for all SQL statements
    public class SqliteDataAccess
    {
        //get all data from the passwords table
        public static List<PasswordModel> LoadPasswords()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PasswordModel>("SELECT * FROM passwords", new DynamicParameters());
                return output.ToList();
            }
        }

        //post a new password to the passwords table
        public static void SaveNewPassword(PasswordModel password)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO passwords (application, password) VALUES (@Application, @Password)", password);
            }
        }

        //remove a password by ID
        public static void RemovePassword(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM passwords WHERE id=" + id);
            }
        }

        //this will update the password on the database after is hass been generated
        public static void SaveGeneratedPassword(int id, string password)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE passwords SET password = '" + password + "' WHERE id = " + id);
            }
        }

        //calling this method connects the application to the database.
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
