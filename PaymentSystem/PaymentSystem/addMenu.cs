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
    public partial class addMenu : Form
    {
        private SQLiteCommand sql_cmd;
        public addMenu()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql_con = new SQLiteConnection(@"Data Source=D:\4семестр\прПР\PaymentSystem\systemDb.db; Version=3;");

            sql_con.Open();

            sql_cmd = sql_con.CreateCommand();

            sql_cmd.CommandText = "insert into Records (id, FIO, goodsSold, hoursWorked, lastVacation) values ('" + idTB.Text + "','" + fioTB.Text + "','" + soldTB.Text + "','" + hoursTB.Text + "','" + vacationTB.Text + "');";

            sql_cmd.ExecuteNonQuery();

            sql_cmd.CommandText = "insert into User (id, login, password, type) values ('" + idTB.Text + "','" + loginTB.Text + "','" + passwordTB.Text + "','" + typeTB.Text + "');";

            sql_cmd.ExecuteNonQuery();

            sql_con.Close();

            AdministratorMenu adminMenu = new AdministratorMenu();
            Hide();
            adminMenu.ShowDialog();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void addMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
