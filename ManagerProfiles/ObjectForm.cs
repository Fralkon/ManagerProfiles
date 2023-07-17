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
    public partial class ObjectForm : Form
    {
        MySQL mySQL;
        string idObject = "";
        public ObjectForm(MySQL mySQL)
        {
            InitializeComponent();
            this.mySQL = mySQL;
        }
        public ObjectForm(MySQL mySQL, string idObject)
        {
            InitializeComponent();
            this.mySQL = mySQL;
            this.idObject = idObject;
            string SQLData = "SELECT name, ip, port FROM object WHERE id = " + idObject;
            DataTable datatable = mySQL.GetDataTableSQL(SQLData);
            if (datatable.Rows.Count > 0)
            {
                nameText.Text = datatable.Rows[0]["name"].ToString();
                ipText.Text = datatable.Rows[0]["ip"].ToString();
                portText.Text = datatable.Rows[0]["port"].ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (portText.Text.Length == 0)
            {
                MessageBox.Show("Введите порт");
                return;
            }
            if (ipText.Text.Length == 0)
            {
                MessageBox.Show("Введите IP");
                return;
            }
            if (nameText.Text.Length == 0)
            {
                MessageBox.Show("Введите наименование");
                return;
            }
            if (idObject == "")
            {
                mySQL.SendSQL("INSERT object (name, ip, port, status) VALUES('" + nameText.Text + "','" + ipText.Text + "'," + portText.Text + ",'offline')");
            }
            else
            {
                mySQL.SendSQL("UPDATE object SET port = '" + portText.Text + "' , name = '" + nameText.Text + "' , ip = '" + ipText.Text + "' WHERE id = " + idObject);
            }
            this.Close();
        }
    }
}
