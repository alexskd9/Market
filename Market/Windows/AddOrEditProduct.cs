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
    public partial class AddOrEditProduct : Form
    {
        public AddOrEditProduct()
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
                    //ახალი საქონლის დამატება
                    var mt = new Product();
                    mt.mid = Convert.ToInt32(mcode.Text);
                    mt.mname = mname.Text;
                    mt.mgroup = db.Groups.FirstOrDefault(z => z.gname == mgroup.Text).gid;
                    mt.munit = db.MUnits.FirstOrDefault(z => z.muname == munit.Text).mucode;
                    mt.mprice = Convert.ToDecimal(mprice.Text.Replace(",", "."));
                    mt.mbarcode = barcode.Text;

                    db.Products.Add(mt);
                    db.SaveChanges();

                    ProductsList pl = new ProductsList();
                    pl.ShowAll();

                    mcode.Text = (Convert.ToInt32(mcode.Text) + 1).ToString();
                    mname.Clear();
                    mprice.Value = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ExecuteButton.Text == "რედაქტირება")
            {
                try
                {
                    var product = db.Products.FirstOrDefault(x => x.mid.ToString() == mcode.Text);
                    product.mname = mname.Text;
                    product.mgroup = db.Groups.Where(x => x.gname == mgroup.Text).Select(x => x.gid).FirstOrDefault();
                    product.munit = db.MUnits.Where(x => x.muname == munit.Text).Select(x => x.mucode).FirstOrDefault();
                    product.mprice = Convert.ToDecimal(mprice.Value);

                    db.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
