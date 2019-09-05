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
    public partial class makeReportMenu : Form
    {
        private SQLiteCommand sql_cmd;
        public makeReportMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql_con = new SQLiteConnection(@"Data Source=D:\4семестр\прПР\PaymentSystem\systemDb.db; Version=3;");

            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();

            sql_cmd.CommandText = "insert into Reports (id, report, checked, finished) values ('" + User.id + "','" + reportTB.Text + "','" + "false" + "','" + "false" + "');";

            sql_cmd.ExecuteNonQuery();

            sql_con.Close();

            LowClassEmployeeMenu lowRankMenu = new LowClassEmployeeMenu();
            Hide();
            lowRankMenu.ShowDialog();
            Close();
        }

    }
}
