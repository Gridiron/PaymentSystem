using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PaymentSystem
{
    public partial class removeMenu : Form
    {
        private SQLiteCommand sql_cmd;
        public removeMenu()
        {
            InitializeComponent();
        }

        private void rmBt_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql_con = new SQLiteConnection(@"Data Source=D:\4семестр\прПР\PaymentSystem\systemDb.db; Version=3;");

            sql_con.Open();
            DataTable dTable = new DataTable();
            string sqlQuery;
            string FIO = fioTB.Text;
            string id="0";
            sqlQuery = string.Format("SELECT * FROM Records WHERE FIO=\"{0}\";", FIO);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, sql_con);
            adapter.Fill(dTable);
            if (dTable.Rows.Count > 0)
            {
                id = dTable.Rows[0][0].ToString();
            }
            else
            {
                return;
            }
            sql_cmd = sql_con.CreateCommand();

            sql_cmd.CommandText = "DELETE FROM Records WHERE id=" + id;

            sql_cmd.ExecuteNonQuery();

            sql_cmd.CommandText = "DELETE FROM User WHERE id=" + id;

            sql_cmd.ExecuteNonQuery();

            sql_con.Close();

            AdministratorMenu adminMenu = new AdministratorMenu();
            Hide();
            adminMenu.ShowDialog();
            Close();
        }
    }
}
