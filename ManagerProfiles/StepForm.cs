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
    public partial class StepForm : Form
    {
        MySQL mySQL;
        string idStep = String.Empty;
        public StepForm(MySQL mySQL)
        {
            this.mySQL = mySQL;
            InitializeComponent();

            using (DataTable dt = mySQL.GetDataTableSQL("SELECT name FROM object WHERE name NOT LIKE 'Telegram'"))
            {
                foreach (DataRow dr in dt.Rows)
                {
                    objectComboBox.Items.Add(dr["name"]);
                }
            }
        }
        public StepForm(MySQL mySQL, string idStep)
        {
            this.idStep = idStep;
            this.mySQL = mySQL;
            InitializeComponent();

            using (DataTable dt = mySQL.GetDataTableSQL("SELECT name FROM object WHERE name NOT LIKE 'Telegram'"))
            {
                foreach (DataRow dr in dt.Rows)
                {
                    objectComboBox.Items.Add(dr["name"]);
                }
            }
            using (DataTable dt = mySQL.GetDataTableSQL("SELECT object.name, step.step, step.user_agent, step.language FROM step, object WHERE step.id = " + idStep + " AND step.id_object = object.id"))
            {
                if (dt.Rows.Count > 0)
                {
                    stepTextBox.Text = dt.Rows[0]["step"].ToString();
                    userAgTextBox.Text = dt.Rows[0]["user_agent"].ToString();
                    objectComboBox.Text = dt.Rows[0]["name"].ToString();
                    langTextBox.Text = dt.Rows[0]["language"].ToString();
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
            if (langTextBox.Text.Length == 0)
            {
                MessageBox.Show("Введите lang.");
                return;
            }
            if (userAgTextBox.Text.Length == 0)
            {
                MessageBox.Show("Введите пароль.");
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
            if (idStep == String.Empty)
                mySQL.SendSQL("INSERT step (step, id_object, user_agent, language) VALUES(" +
                    stepTextBox.Text + "," +
                    idObj + ",'" +
                    userAgTextBox.Text + "','" +
                    langTextBox.Text + "')");
            else
                mySQL.SendSQL("UPDATE step SET id_object = " + idObj +
                    " , step = '" + stepTextBox.Text +
                    " , user_agent = '" + userAgTextBox.Text +
                    "' , language = '" + langTextBox.Text +
                    "' WHERE id = " + idStep);
            this.Close();
        }
    }

}
