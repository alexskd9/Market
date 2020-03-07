using Market.Windows;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Market
{
    public partial class ProductsList : Form
    {
        public ProductsList()
        {
            InitializeComponent();
        }
        MarketEntities db = new MarketEntities();


        private void ProductsList_Load(object sender, EventArgs e)
        {
            ShowAll();
        }

        //ახალი საქონლის დამატება
        private void AddNewProduct_Click(object sender, EventArgs e)
        {
            AddOrEditProduct product = new AddOrEditProduct();
            product.Text = "ახალი საქონლის დამატება";
            product.ExecuteButton.Text = "დამატება";
            var list = db.Products.Select(x => x.mid).ToList();
            if (list.Count() != 0)
            {
                product.mcode.Text = (db.Products.OrderByDescending(x => x.mid).FirstOrDefault().mid + 1).ToString();
            }
            else
            {
                product.mcode.Text = "1";
            }
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


        //საქონლის წაშლა
        private void delete_Click(object sender, EventArgs e)
        {
            int code = (int)dgv1.CurrentRow.Cells[0].Value;

            DialogResult result = MessageBox.Show("გსურთ ჩანაწერის წაშლა?", "ყურადღება", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var material = db.Products.FirstOrDefault(x => x.mid == code);
                    db.Products.Remove(material);

                    db.SaveChanges();
                    ShowAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //საქონლის სიის გამოძახება
        public void ShowAll()
        {
            var table = db.Products.OrderBy(x => x.mid);
            dgv1.DataSource = table.Select(x => new ListOfProducts
            {
                mid = x.mid,
                mname = x.mname,
                mbarcode = x.mbarcode,
                mgroup = x.Group.gname,
                munit = x.MUnit1.muname,
                mprice = x.mprice.ToString()
            }).ToList();
            //სვეტების სათაურების გადარქმევა
            this.dgv1.Columns["mid"].HeaderText = "კოდი";
            this.dgv1.Columns["mname"].HeaderText = "დასახელება";
            this.dgv1.Columns["mbarcode"].HeaderText = "შტრიხკოდი";
            this.dgv1.Columns["mgroup"].HeaderText = "ჯგუფი";
            this.dgv1.Columns["munit"].HeaderText = "საზომი ერთეული";
            this.dgv1.Columns["mprice"].HeaderText = "გასაყიდი ფასი";
        }

        //ექსპორტი ექსელში
        private void ExportExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel.Export(dgv1);
        }

        private void dgv1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddOrEditProduct product = new AddOrEditProduct();
            product.mcode.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
            product.mname.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
            product.mgroup.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
            product.munit.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
            product.mprice.Value = Convert.ToDecimal(dgv1.CurrentRow.Cells[4].Value);
            product.barcode.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
            product.Text = "საქონლის რედაქტირება";
            product.ExecuteButton.Text = "რედაქტირება";
            product.ExecuteButton.Width += 20;
            product.Show();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void ProductsList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                ShowAll();
            }
        }
    }

    public class ListOfProducts
    {
        public int mid { get; set; }
        public string mname { get; set; }
        public string mgroup { get; set; }
        public string munit { get; set; }
        public string mprice { get; set; }
        public string mbarcode { get; set; }
    }
}
