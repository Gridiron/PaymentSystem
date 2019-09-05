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
    public partial class fillFormMenu : Form
    {
        public fillFormMenu()
        {
            InitializeComponent();
            SQLiteConnection Connect = new SQLiteConnection(@"Data Source=D:\4семестр\прПР\PaymentSystem\systemDb.db; Version=3;");
            Connect.Open();
            string sqlQuery;
            DataTable dTable = new DataTable();
            sqlQuery = string.Format("SELECT * FROM Reports WHERE checked=\"true\" AND finished=\"true\";");
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, Connect);
            adapter.Fill(dTable);
            if (dTable.Rows.Count > 0)
            {
                reportTB.Text = dTable.Rows[0][1].ToString();
                Connect.Close();
            }
            else
            {
                MessageBox.Show("You don't have reports to send to DB");
                Connect.Close();
                return;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection Connect = new SQLiteConnection(@"Data Source=D:\4семестр\прПР\PaymentSystem\systemDb.db; Version=3;");
            Connect.Open();
            DataTable dTable = new DataTable();
            string hours;
            string goods;
            string days;
            string sqlQuery;
           
            sqlQuery = string.Format("SELECT * FROM Records WHERE FIO=\"{0}\";", fioTB.Text);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, Connect);
            adapter.Fill(dTable);
            if (dTable.Rows.Count > 0)
            {
                hours = dTable.Rows[0][2].ToString();
                goods = dTable.Rows[0][3].ToString();
                days = dTable.Rows[0][4].ToString();
            }
            else
            {
                MessageBox.Show("There is no such employee");
                return;
            }
            hours = (Convert.ToInt32(hours) + Convert.ToInt32(hoursTB.Text)).ToString();
            goods = (Convert.ToInt32(goods) + Convert.ToInt32(goodsTB.Text)).ToString();
            days = (Convert.ToInt32(days) + Convert.ToInt32(daysTB.Text)).ToString();
            string updatecorect = "update Records set hoursWorked=\"" + hours + "\", goodsSold=\"" + goods + "\", lastVacation=\"" + days + "\" WHERE FIO=\"" + fioTB.Text + "\";";
            SQLiteCommand updatec = new SQLiteCommand(updatecorect, Connect);
            updatec.ExecuteNonQuery();
            string deleteStr= "DELETE FROM Reports WHERE report=\"" + reportTB.Text + "\";";

            SQLiteCommand delete = new SQLiteCommand(deleteStr, Connect);
            delete.ExecuteNonQuery();
            Connect.Close();

            HighClassEmployeeMenu highRankMenu = new HighClassEmployeeMenu();
            Hide();
            highRankMenu.ShowDialog();
            Close();
        }
    }
}
