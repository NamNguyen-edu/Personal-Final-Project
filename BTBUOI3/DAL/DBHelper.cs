using System;
using System.Data.SQLite;
using System.IO;

namespace TDashMiniStore.DAL
{
    public class DbHelper
    {
        private static readonly string DbFilePath =
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Database",
                "tdash.db"
            );

        private static readonly string ConnectionString =
            $"Data Source={DbFilePath};Version=3;";

        public static SQLiteConnection GetConnection()
        {
            if (!File.Exists(DbFilePath))
            {
                throw new FileNotFoundException(
                    "Không tìm thấy file database tdash.db"
                );
            }

            return new SQLiteConnection(ConnectionString);
        }
    }
}
