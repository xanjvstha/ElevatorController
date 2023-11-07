using System.Data.SQLite;
using System.Data;

namespace ElevatorController
{
    internal class DatabaseCommand
    {
        private string GetConnectionString()
        {
            string databaseFile = "Elevator.db";
            string connectionString = $"Data Source={databaseFile};Version=3;";
            return connectionString;
        }
        public DataTable SelectData()
        {
            string connectionString = GetConnectionString();
            string sql = "SELECT time, action FROM elevator_events_log ORDER BY id DESC LIMIT 32";
            SQLiteDataAdapter adapter = null;
            DataTable table = null;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        adapter = new SQLiteDataAdapter(command);
                        table = new DataTable();
                        adapter.Fill(table);
                        conn.Close();
                        return table;
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                }
            }
        }

        public void InsertData(string action, DateTime time)
        {
            string connectionString = GetConnectionString();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                string selectSql = "SELECT * FROM elevator_events_log";

                using (SQLiteDataAdapter selectAdapter = new SQLiteDataAdapter(selectSql, conn))
                {
                    using (SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(selectAdapter))
                    {
                        using (DataSet dataSet = new DataSet())
                        {
                            try
                            {
                                conn.Open();

                                selectAdapter.Fill(dataSet, "elevator_events_log");
                                DataTable dataTable = dataSet.Tables["elevator_events_log"];

                                DataRow newRow = dataTable.NewRow();
                                newRow["time"] = time.ToString("yyyy-MM-dd HH:mm:ss");
                                newRow["action"] = action;
                                
                                dataTable.Rows.Add(newRow);

                                selectAdapter.Update(dataSet, "elevator_events_log");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                            }
                        }
                    }
                }
                conn.Close();
            }
        }
    }
}