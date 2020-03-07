using Market.Windows;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Market
{
    public partial class GroupList : Form
    {
        public GroupList()
        {
            InitializeComponent();
        }
        MarketEntities db = new MarketEntities();

        private void GroupList_Load(object sender, EventArgs e)
        {
            ShowAll();
        }

        //ახალი ჯგუფის დამატება
        private void AddNewGroup_Click(object sender, EventArgs e)
        {
            AddOrEditGroup group = new AddOrEditGroup();
            var list = db.Groups.Select(x => x.gid).ToList();
            if (list.Count() != 0)
            {
                group.gcode.Text = (db.Groups.OrderByDescending(x => x.gid).FirstOrDefault().gid + 1).ToString();
            }
            else
            {
                group.gcode.Text = "1";
            }
            group.Text = "ახალი ჯგუფი";
            group.ExecuteButton.Text = "დამატება";
            group.Show();
        }

        //ჯგუფის წაშლა
        private void delete_Click(object sender, EventArgs e)
        {
            var code = dgv1.CurrentRow.Cells[0].Value;

            DialogResult result = MessageBox.Show("გსურთ ჩანაწერის წაშლა?", "ყურადღება", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var gr = db.Groups.FirstOrDefault(x => x.gid.ToString() == code.ToString());
                    db.Groups.Remove(gr);

                    db.SaveChanges();
                    ShowAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //ჯგუფების სიის გამოტანა
        public void ShowAll()
        {
            var table = db.Groups.OrderBy(x => x.gid);
            dgv1.DataSource = table.Select(x => new Groups
            {
                gcode = x.gid.ToString(),
                gname = x.gname
            }).ToList();
            this.dgv1.Columns["gcode"].HeaderText = "კოდი";
            this.dgv1.Columns["gname"].HeaderText = "დასახელება";
        }

        //ექსპორტი ექსელში
        private void ExportExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel.Export(dgv1);
        }

        private void dgv1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddOrEditGroup group = new AddOrEditGroup();
            group.gcode.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
            group.gname.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
            group.Text = "ჯგუფის რედაქტირება";
            group.ExecuteButton.Text = "რედაქტირება";
            group.Show();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void GroupList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                ShowAll();
            }
        }
    }

    public class Groups
    {
        public string gcode { get; set; }
        public string gname { get; set; }
    }
}
