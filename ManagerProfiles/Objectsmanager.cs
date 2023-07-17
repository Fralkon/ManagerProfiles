using System.Data;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ManagerProfiles
{
    public enum EnumTypeSite
    {
        None,
        Router,
        SeoFast,
        Aviso,
        Profitcentr,
        WmrFast,
        WebofSar,
        Losena,
        SeoClub,
        VipClick
    }
    public partial class ObjectsManager : Form
    {
        MySQL mySQL;
        public ObjectsManager()
        {x
            mySQL = new MySQL();
            InitializeComponent();
            authData.ContextMenuStrip = contextMenuStrip1;
            objectsData.ContextMenuStrip = contextMenuStripObjects;
            stepSettingData.ContextMenuStrip = contextMenuStripStep;
            UpDateTable();
            UpDateTableObject();
            UpDateTableStep();
        }
        private void UpDateTable()
        {
            string SQLData = "SELECT auth.id, object.name, auth.step, auth.site, auth.login, auth.password, auth.status FROM auth, object WHERE auth.id_object = object.id";
            DataTable datatable = mySQL.GetDataTableSQL(SQLData);
            datatable.Columns["id"].ColumnName = "ID";
            datatable.Columns["name"].ColumnName = "Obj name";
            datatable.Columns["step"].ColumnName = "Step";
            datatable.Columns["login"].ColumnName = "�����";
            datatable.Columns["password"].ColumnName = "������";
            datatable.Columns["site"].ColumnName = "����";
            datatable.Columns["status"].ColumnName = "������";
            authData.DataSource = datatable;
        }
        private void UpDateTableObject()
        {
            string SQLData = "SELECT * FROM object";
            DataTable datatable = mySQL.GetDataTableSQL(SQLData);
            datatable.Columns["id"].ColumnName = "ID";
            datatable.Columns["name"].ColumnName = "���";
            datatable.Columns["ip"].ColumnName = "IP";
            datatable.Columns["port"].ColumnName = "Port";
            datatable.Columns["status"].ColumnName = "������";
            objectsData.DataSource = datatable;
        }
        private void UpDateTableStep()
        {
            string SQLData = "SELECT * FROM step";
            DataTable datatable = mySQL.GetDataTableSQL(SQLData);
            datatable.Columns["step"].ColumnName = "Step";
            datatable.Columns["id_object"].ColumnName = "Object";
            datatable.Columns["user_agent"].ColumnName = "User agent";
            datatable.Columns["language"].ColumnName = "Language";
            stepSettingData.DataSource = datatable;
        }
        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthFormManager authFormManager = new AuthFormManager(mySQL);
            authFormManager.ShowDialog();
            UpDateTable();
        }
        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (authData.SelectedRows.Count == 1)
            {
                AuthFormManager authFormManager = new AuthFormManager(mySQL, authData.SelectedRows[0].Cells[0].Value.ToString());
                authFormManager.ShowDialog();
                UpDateTable();
            }
            else
            {
                MessageBox.Show("�������� ������.");
            }
        }
        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (authData.SelectedRows.Count == 1)
            {
                mySQL.SendSQL("DELETE FROM admin WHERE id = " + authData.SelectedRows[0].Cells[0].Value.ToString());
                UpDateTable();
            }
            else
            {
                MessageBox.Show("�������� ������.");
            }
        }
        private void �������ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            ObjectForm objectForm = new ObjectForm(mySQL);
            objectForm.ShowDialog();
            UpDateTableObject();
        }
        private void ��������ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (objectsData.SelectedRows.Count != 0)
            {
                ObjectForm objectForm = new ObjectForm(mySQL, objectsData.SelectedRows[0].Cells[0].Value.ToString());
                objectForm.ShowDialog();
                UpDateTableObject();
            }
        }
        private void �������ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (objectsData.SelectedRows.Count == 1)
            {
                mySQL.SendSQL("DELETE FROM object WHERE id = " + objectsData.SelectedRows[0].Cells[0].Value.ToString());
                UpDateTableObject();
            }
        }
        private void �������ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            StepForm stepForm = new StepForm(mySQL);
            stepForm.ShowDialog();
            UpDateTableStep();
        }
        private void ��������ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (stepSettingData.SelectedRows.Count > 0)
            {
                StepForm stepForm = new StepForm(mySQL, stepSettingData.SelectedRows[0].Cells[0].Value.ToString());
                stepForm.ShowDialog();
                UpDateTableStep();
            }
        }
        private void �������ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (stepSettingData.SelectedRows.Count == 1)
            {
                mySQL.SendSQL("DELETE FROM step WHERE id = " + objectsData.SelectedRows[0].Cells[0].Value.ToString());
                UpDateTableStep();
            }
        }
        private void Status_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (authData.SelectedRows.Count > 0)
            {
                ToolStripMenuItem? menuItem = sender as ToolStripMenuItem;
                if (menuItem != null)
                {
                    ChangeStatus("auth", authData.SelectedRows[0].Cells[0].Value.ToString(), menuItem.Text);
                }
                else
                {
                    MessageBox.Show("Error toolStrip");
                }
                UpDateTable();
            }
        }
        private void ChangeStatus(string bd, string id, string status)
        {
            mySQL.SendSQL("UPDATE " + bd + " SET status = '" + status + "' WHERE id = " + id);
        }
    }
}