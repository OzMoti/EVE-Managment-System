using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EVE_Managment_System
{
    public static class DBHelper
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;


        public static MySqlConnection GetConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "192.168.43.80";
            builder.UserID = "eve";
            builder.Password = "668073545";
            builder.Database = "eve";
            builder.SslMode = MySqlSslMode.None;
            connection = new MySqlConnection(builder.ToString());
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to Dataabase Failed !\n" + ex.Message);
            }
            return connection;
        }

        public static void AddOrder(PCB pcb)
        {
            string sql = "insert into eve.orders(PNAME,CNAME,STRDATE,SUBDATE,PTYPE,PNUM,PPNUM,PRIORITY) VALUES(@PanelName, @CustomerName, @StartDate, @SubDate, @PanelType, @PNum, @PPNum, @Priority)";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@PanelName", pcb.Name);
            cmd.Parameters.AddWithValue("@CustomerName", pcb.Customer);
            cmd.Parameters.AddWithValue("@StartDate", pcb.StartDate);
            cmd.Parameters.AddWithValue("@SubDate", pcb.SubDate);
            cmd.Parameters.AddWithValue("@PanelType", pcb.PType);
            cmd.Parameters.AddWithValue("@PNum", pcb.PNum);
            cmd.Parameters.AddWithValue("@PPNum", pcb.PPNum);
            cmd.Parameters.AddWithValue("@Priority", pcb.Priority);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("PCB added successfully ! \n", "Infornation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("PCB add Failed ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void Update(PCB pcb, string id)
        {
            string sql = "update eve.orders set PNAME = @PanelName,CNAME =@CustomerName ,STRDATE =@StartDate ,SUBDATE = @SubDate,PTYPE = @PanelType,PNUM = @PNum,PPNUM = @PPNum,PRIORITY = @Priority)";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@PanelName", pcb.Name);
            cmd.Parameters.AddWithValue("@CustomerName", pcb.Customer);
            cmd.Parameters.AddWithValue("@StartDate", pcb.StartDate);
            cmd.Parameters.AddWithValue("@SubDate", pcb.SubDate);
            cmd.Parameters.AddWithValue("@PanelType", pcb.PType);
            cmd.Parameters.AddWithValue("@PNum", pcb.PNum);
            cmd.Parameters.AddWithValue("@PPNum", pcb.PPNum);
            cmd.Parameters.AddWithValue("@Priority", pcb.Priority);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("PCB added successfully ! \n", "Infornation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("PCB add Failed ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void ShowAndSearch(string query, DataGridView dgv)
        {

            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            connection.Close();
        }

        public static void DeletePCB(int ID)
        {
            string sql = "DELETE FROM eve.orders WHERE ORD_ID = @ID";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                cmd.ExecuteNonQuery();
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("PCB delete Failed ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }
    }
}
