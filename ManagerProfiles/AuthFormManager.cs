using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerProfiles
{
    public enum EnumStatusObject
    {
        Activate,
        Deactivate,
        Wait,
        Error
    }
    public partial class AuthFormManager : Form
    {
        MySQL mySQL;
        string idAuth = String.Empty;
        public AuthFormManager(MySQL mySQL)
        {
            this.mySQL = mySQL;
            InitializeComponent();
            siteComboBox.DataSource = Enum.GetValues(typeof(EnumTypeSite));
            statusComboBox.DataSource = Enum.GetValues(typeof(EnumStatusObject));
            using (DataTable dt = mySQL.GetDataTableSQL("SELECT name FROM object WHERE name NOT LIKE 'Telegram'"))
            {
                foreach (DataRow dr in dt.Rows)
                {
                    objectComboBox.Items.Add(dr["name"]);
                }
            }
        }
        public AuthFormManager(MySQL mySQL, string ID)
        {
            this.mySQL = mySQL;
            InitializeComponent();
            idAuth = ID;
            siteComboBox.DataSource = Enum.GetValues(typeof(EnumTypeSite));
            statusComboBox.DataSource = Enum.GetValues(typeof(EnumStatusObject));
            using (DataTable dt = mySQL.GetDataTableSQL("SELECT name FROM object WHERE name NOT LIKE 'Telegram'"))
            {
                foreach (DataRow dr in dt.Rows)
                {
                    objectComboBox.Items.Add(dr["name"]);
                }
            }
            using (DataTable dt = mySQL.GetDataTableSQL("SELECT object.name, auth.step, auth.login, auth.password, auth.site, auth.status FROM auth , object WHERE auth.id = " + ID + " AND auth.id_object = object.id"))
            {
                if (dt.Rows.Count > 0)
                {
                    stepTextBox.Text = dt.Rows[0]["step"].ToString();
                    objectComboBox.Text = dt.Rows[0]["name"].ToString();
                    loginTextBox.Text = dt.Rows[0]["login"].ToString();
                    passTextBox.Text = dt.Rows[0]["password"].ToString();
                    siteComboBox.Text = dt.Rows[0]["site"].ToString();
                    statusComboBox.Text = dt.Rows[0]["status"].ToString();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (stepTextBox.Text.Length == 0)
            {
                MessageBox.Show("Введите step.");
                return;
            }
            if (objectComboBox.Text.Length == 0)
            {
                MessageBox.Show("Введите объект.");
                return;
            }
            if (loginTextBox.Text.Length == 0)
            {
                MessageBox.Show("Введите логин.");
                return;
            }
            if (passTextBox.Text.Length == 0)
            {
                MessageBox.Show("Введите пароль.");
                return;
            }
            if (siteComboBox.Text.Length == 0)
            {
                MessageBox.Show("Введите сайт.");
                return;
            }
            if (statusComboBox.Text.Length == 0)
            {
                MessageBox.Show("Введите статус.");
                return;
            }
            string idObj;
            using (DataTable dt = mySQL.GetDataTableSQL("SELECT id FROM object WHERE name = '" + objectComboBox.Text + "'"))
            {
                if (dt.Rows.Count > 0)
                    idObj = dt.Rows[0]["id"].ToString();
                else
                {
                    MessageBox.Show("Обьект не найден");
                    return;
                }
            }
            if (idAuth == String.Empty)
                mySQL.SendSQL("INSERT auth (id_object, step, login, password, site, status, last_day, all_time) VALUES('" +
                    idObj + "'," +
                    stepTextBox.Text + ",'" +
                    loginTextBox.Text + "','" +
                    passTextBox.Text + "','" +
                    siteComboBox.Text + "','" +
                    statusComboBox.Text + "' , 0 , 0)");
            else
                mySQL.SendSQL("UPDATE auth SET step = " + stepTextBox.Text +
                    ", login = '" + loginTextBox.Text +
                    "' , password = '" + passTextBox.Text +
                    "' , site = '" + siteComboBox.Text +
                    "' , status = '" + statusComboBox.Text + "' WHERE id = " + idAuth);
            this.Close();
        }
    }
}
