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
    public partial class HighClassEmployeeMenu : Form
    {
        public HighClassEmployeeMenu()
        {
            InitializeComponent();
        }

        private void checkButton_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void fillButton_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void vacationButton_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql_con = new SQLiteConnection(@"Data Source=D:\4семестр\прПР\PaymentSystem\systemDb.db; Version=3;");
        
            sql_con.Open();
            DataTable dTable = new DataTable();
            string sqlQuery;
            string hours = "0";
            sqlQuery = string.Format("SELECT * FROM Records WHERE id=\"{0}\";", User.id);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, sql_con);
            adapter.Fill(dTable);
            if (dTable.Rows.Count > 0)
            {
                hours = dTable.Rows[0][4].ToString();
            }
            else
            {
                return;
            }
            int temp = Convert.ToInt32(hours);
            if (temp > 150)
            {
                string updatecorect = "update Records set lastVacation=0 where id=" + User.id;
                SQLiteCommand updatec = new SQLiteCommand(updatecorect, sql_con);
                updatec.ExecuteNonQuery();
                MessageBox.Show("Success! Happy vacations");
                return;
            }
            else
            {
                MessageBox.Show("You have not entered a password");
                return;
            }
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            fillFormMenu menu = new fillFormMenu();
            Hide();
            menu.ShowDialog();
            Close();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            checkButton menu = new checkButton();
            Hide();
            menu.ShowDialog();
            Close();
        }
    }
}
