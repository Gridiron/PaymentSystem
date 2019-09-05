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
    public partial class EnterMenu : Form
    {
        public EnterMenu()
        {
            InitializeComponent();
        }

        private void enterButton_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            SQLiteConnection Connect = new SQLiteConnection(@"Data Source=D:\4семестр\прПР\PaymentSystem\systemDb.db; Version=3;");
            Connect.Open();
            DataTable dTable = new DataTable();
            string login;
            string password;
            string sqlQuery;
            login = loginTextBox.Text;
            password = passwordTextBox.Text;
            if (login == "")
            {
                MessageBox.Show(
           "You have not entered a login",
           "Warning");
                return;
            }
            if (password == "")
            {
                MessageBox.Show(
            "You have not entered a password",
            "Warning");
                return;
            }
            sqlQuery = string.Format("SELECT * FROM User WHERE login=\"{0}\" AND password=\"{1}\";", login, password);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, Connect);
            adapter.Fill(dTable);
            if (dTable.Rows.Count > 0)
            {
                User.id = dTable.Rows[0][0].ToString();
                User.login = dTable.Rows[0][1].ToString();
                User.password = dTable.Rows[0][2].ToString();
                User.type = dTable.Rows[0][3].ToString();
            }
            else
            {
                MessageBox.Show("No such user");
                Connect.Close();
                return;
            }
            Connect.Close();
            switch(User.type)
            {
                case "1":
                    LowClassEmployeeMenu lowRankMenu = new LowClassEmployeeMenu();
                    Hide();
                    lowRankMenu.ShowDialog();
                    Close();
                    break;
                case "2":
                    AdministratorMenu adminMenu = new AdministratorMenu();
                    Hide();
                    adminMenu.ShowDialog();
                    Close();
                    break;
                case "3":
                    HighClassEmployeeMenu highRankMenu = new HighClassEmployeeMenu();
                    Hide();
                    highRankMenu.ShowDialog();
                    Close();
                    break;
                default:
                    AdministratorMenu menu = new AdministratorMenu();
                    Hide();
                    menu.ShowDialog();
                    Close();
                    break;

            }
        }
    }
}
