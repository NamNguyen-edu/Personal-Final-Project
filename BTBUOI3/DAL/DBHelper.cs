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
            // Đảm bảo thư mục Database tồn tại
            string dir = Path.GetDirectoryName(DbFilePath)!;
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            // Tạo DB nếu chưa tồn tại
            if (!File.Exists(DbFilePath))
            {
                SQLiteConnection.CreateFile(DbFilePath);
            }

            return new SQLiteConnection(ConnectionString);
        }
    }
}
