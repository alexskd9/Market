using Market.Windows;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Market
{
    public partial class PurchaseWindow : Form
    {
        public PurchaseWindow()
        {
            InitializeComponent();
        }
        MarketEntities db = new MarketEntities();

        //ახალი, ცარიელი სტრიქონის დამატება
        private void AddRow_Click(object sender, EventArgs e)
        {
            dgv1.Rows.Add();
        }

        //შესყიდვის შენახვა ბაზაში (ცხრილი Purchases)
        private void SaveDoc_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv1.RowCount; i++)
            {
                var purch = new Purchase();
                purch.pdate = Convert.ToDateTime(Date.Value);
                purch.pdocnum = DocNumber.Text;
                purch.mcode = (int)dgv1.Rows[i].Cells[5].Value;
                purch.mqty = Convert.ToDecimal(dgv1.Rows[i].Cells[2].Value);
                purch.mpprice = Convert.ToDecimal(dgv1.Rows[i].Cells[3].Value);
                purch.mpsum = Convert.ToDecimal(dgv1.Rows[i].Cells[4].Value);

                db.Purchases.Add(purch);
                db.SaveChanges();
            }
            this.Close();
        }

        private void PurchaseWindow_Load(object sender, EventArgs e)
        {
            //დოკუმენტის რიგითი ნომრის მინიჭება (sql-იდან ბოლო ჩომერს იღებს და უმატებს 1)
            if (db.Purchases.Any())
            {
                var z = db.Purchases.OrderByDescending(x => x.pdocnum).First().pdocnum;
                DocNumber.Text = (Convert.ToInt32(z) + 1).ToString();
            }
            else
            {
                DocNumber.Text = "1";
            }

            productBindingSource.DataSource = db.Products.ToList();
        }

        //სტრიქონის წაშლა
        private void DeleteRow_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("გსურთ ჩანაწერის წაშლა?", "ყურადღება", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    dgv1.Rows.RemoveAt(dgv1.CurrentRow.Index);
                    dgv1.Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //სტრიქონის ველების ცვლილებების მოვლენები
        private void dgv1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

            var name = dgv1.CurrentRow.Cells[0].EditedFormattedValue;
            if (name != null)
            {
                //საზომი ერთეულის დასახელების მოტანა
                var uname = db.MUnits.FirstOrDefault(x => x.mucode == db.Products.FirstOrDefault(z => z.mname == name.ToString()).mid).muname;
                dgv1.CurrentRow.Cells[1].Value = uname;

                //საქონლის კოდის მოტანა (საჭიროა შესყიდვის ბაზაში ჩაწერისთვის)
                var code = db.Products.FirstOrDefault(x => x.mname == name.ToString()).mid;
                dgv1.CurrentRow.Cells[5].Value = code;
            }
            //თუ შევსებულია რაოდენობა და ერთეულის ფასი, გამოთვალოს თანხა
            if (dgv1.CurrentRow.Cells[2].Value != null && dgv1.CurrentRow.Cells[3].Value != null)
            {
                dgv1.CurrentRow.Cells[4].Value = Convert.ToDouble(dgv1.CurrentRow.Cells[2].Value) * Convert.ToDouble(dgv1.CurrentRow.Cells[3].Value);
            }
        }

        //ახალი საქონლის დამატება
        private void AddNewProduct_Click(object sender, EventArgs e)
        {
            AddOrEditProduct product = new AddOrEditProduct();
            product.Text = "ახალი საქონლის დამატება";
            product.ExecuteButton.Text = "დამატება";
            product.mcode.Text = (db.Products.OrderByDescending(x => x.mid).FirstOrDefault().mid + 1).ToString();
            //ჯგუფების სიის ჩაწერა combobox-ში
            var groups = from Gname in db.Groups select new { Gname.gname };
            foreach (var i in groups)
            {
                product.mgroup.Items.Add(i.gname);
            }

            //საზომი ერთეულების სიის ჩაწერა combobox-ში
            var munits = from Muname in db.MUnits select new { Muname.muname };
            foreach (var i in munits)
            {
                product.munit.Items.Add(i.muname);
            }
            product.Show();
        }
    }
}
