using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.Windows
{
    public partial class AddOrEditGroup : Form
    {
        public AddOrEditGroup()
        {
            InitializeComponent();
        }

        MarketEntities db = new MarketEntities();
        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            if (ExecuteButton.Text == "დამატება")
            {
                try
                {
                    var NewGroup = new Group();
                    NewGroup.gid = Convert.ToInt32(gcode.Text);
                    NewGroup.gname = gname.Text;

                    db.Groups.Add(NewGroup);
                    db.SaveChanges();

                    gcode.Text = (Convert.ToInt32(gcode.Text) + 1).ToString();
                    gname.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(ExecuteButton.Text=="რედაქტირება")
            {
                var group = db.Groups.FirstOrDefault(x => x.gid.ToString() == gcode.Text);
                group.gname = gname.Text;

                db.SaveChanges();
                this.Close();
            }
        }
    }
}
