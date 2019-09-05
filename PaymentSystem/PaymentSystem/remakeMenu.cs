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
    public partial class remakeMenu : Form
    {
        public remakeMenu()
        {
            InitializeComponent();
            SQLiteConnection Connect = new SQLiteConnection(@"Data Source=D:\4семестр\прПР\PaymentSystem\systemDb.db; Version=3;");
            Connect.Open();
            string sqlQuery;
            DataTable dTable = new DataTable();
            sqlQuery = string.Format("SELECT * FROM Reports WHERE id=\"{0}\" AND checked=\"true\" AND finished=\"false\";", User.id);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, Connect);
            adapter.Fill(dTable);
            if (dTable.Rows.Count > 0)
            {
                reportTB.Text = dTable.Rows[0][1].ToString();
                Connect.Close();
            }
            else
            {
                MessageBox.Show("You don't have reports to remake");
                Connect.Close();
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql_con = new SQLiteConnection(@"Data Source=D:\4семестр\прПР\PaymentSystem\systemDb.db; Version=3;");

            sql_con.Open();
            //string updatecorect = "update Records set lastVacation=0 where id=" + User.id;
            string updatecorect = "update Reports set report=\"" + reportTB.Text + "\", checked=\"false\" WHERE id=" + User.id + " AND checked=\"true\" AND finished=\"false\";";
            SQLiteCommand updatec = new SQLiteCommand(updatecorect, sql_con);
            updatec.ExecuteNonQuery();

            sql_con.Close();

            LowClassEmployeeMenu lowRankMenu = new LowClassEmployeeMenu();
            Hide();
            lowRankMenu.ShowDialog();
            Close();
        }
    }
}
