using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Market
{
    public partial class SaleWindow : Form
    {
        public SaleWindow()
        {
            InitializeComponent();
        }
        MarketEntities db = new MarketEntities();
        int i = 0;
        double sum = 0;

        //Enter-ის დაჭერისას საქონლის ძებნა ხორციელდება შტრიხკოდით
        private void ValueField_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (ValueField.Text != "")
                    {  
                        //ახალი სტრიქონის დამატება
                        dgv1.Rows.Add();
                        //კოდის მოტანა
                        dgv1.Rows[i].Cells[0].Value = db.Products.FirstOrDefault(x => x.mbarcode == ValueField.Text).mid;
                        //დასახელების მოტანა
                        dgv1.Rows[i].Cells[1].Value = db.Products.FirstOrDefault(x => x.mbarcode == ValueField.Text).mname;

                        //საქონლის საზომი ერთეულის დასახელების მოტანა
                        var uname = db.MUnits.FirstOrDefault(x => x.mucode == db.Products.FirstOrDefault(z => z.mname == name.ToString()).mid).muname;
                        dgv1.Rows[i].Cells[2].Value = uname;

                        dgv1.Rows[i].Cells[3].Value = 1;
                        //საქონლის გასაყიდი ფასის მოტანა
                        dgv1.Rows[i].Cells[4].Value = db.Products.FirstOrDefault(x => x.mbarcode == ValueField.Text).mprice;
                        //სტრიქონის ჰამის გამოთვლა
                        dgv1.Rows[i].Cells[5].Value = Convert.ToDouble(dgv1.Rows[i].Cells[3].Value) * Convert.ToDouble(dgv1.Rows[i].Cells[4].Value);


                        DocumentSum();
                        ValueField.Clear();
                        i++;
                        ValueField.Focus();
                    }
                    else
                    {
                        MessageBox.Show("შეიყვანეთ კოდი ან შტრიხკოდი და სცადეთ კიდევ ერთხელ", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //თუ დავაჭერთ F8, იქნება კოდის ღილაკის იმიტაცია, F9 - დასახელების ღილაკის იმიტაცია
                else if (e.KeyCode == Keys.F8)
                {
                    SearchByCode_Click(sender, e);
                }
                else if (e.KeyCode == Keys.F9)
                {
                    SearchByName_Click(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //საქონლის ძებნა სახელით
        private void SearchByName_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValueField.Text != "")
                {
                    if (db.Products.Select(x => x.mname).ToList().Contains(ValueField.Text))
                    {
                        dgv1.Rows.Add();
                        dgv1.Rows[i].Cells[0].Value = db.Products.FirstOrDefault(x => x.mname == ValueField.Text).mid;
                        dgv1.Rows[i].Cells[1].Value = ValueField.Text;

                        var uname = db.MUnits.FirstOrDefault(x => x.mucode == db.Products.FirstOrDefault(z => z.mname == name.ToString()).mid).muname;
                        dgv1.Rows[i].Cells[2].Value = uname;

                        dgv1.Rows[i].Cells[3].Value = 1;
                        dgv1.Rows[i].Cells[4].Value = db.Products.FirstOrDefault(x => x.mname == ValueField.Text).mprice;
                        dgv1.Rows[i].Cells[5].Value = Convert.ToDouble(dgv1.Rows[i].Cells[3].Value) * Convert.ToDouble(dgv1.Rows[i].Cells[4].Value);

                        DocumentSum();
                        ValueField.Clear();
                        i++;
                        ValueField.Focus();
                    }
                    else
                    {
                        MessageBox.Show("საქონელი დასახელებით " + ValueField.Text + " არ არსებობს", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ValueField.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("შეიყვანეთ შტრიხკოდი, კოდი ან დასახელება და სცადეთ კიდევ ერთხელ", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //საქონლის ძებნა კოდით
        private void SearchByCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValueField.Text != "")
                {
                    dgv1.Rows.Add();
                    dgv1.Rows[i].Cells[0].Value = ValueField.Text;
                    dgv1.Rows[i].Cells[1].Value = db.Products.FirstOrDefault(x => x.mid.ToString() == ValueField.Text).mname;

                    var uname = db.MUnits.FirstOrDefault(x => x.mucode == (db.Products.FirstOrDefault(z => z.mname == name.ToString()).mid)).muname;
                    dgv1.Rows[i].Cells[2].Value = uname;

                    dgv1.Rows[i].Cells[3].Value = 1;
                    dgv1.Rows[i].Cells[4].Value = db.Products.FirstOrDefault(x => x.mid == Convert.ToInt32(ValueField.Text)).mprice;
                    dgv1.Rows[i].Cells[5].Value = Convert.ToDouble(dgv1.Rows[i].Cells[3].Value) * Convert.ToDouble(dgv1.Rows[i].Cells[4].Value);

                    DocumentSum();
                    ValueField.Clear();
                    i++;
                    ValueField.Focus();
                }
                else
                {
                    MessageBox.Show("შეიყვანეთ კოდი ან შტრიხკოდი და სცადეთ კიდევ ერთხელ", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //დოკუმენტის თანხის გამოთვლა
        private void DocumentSum()
        {
            sum = 0;
            for (int z = 0; z < dgv1.RowCount; z++)
            {
                DocSum.Clear();
                sum += Convert.ToDouble(dgv1.Rows[z].Cells[5].Value);
                DocSum.Text = sum.ToString();                
            }
        }

        //სტრიქონის წაშლა
        private void DeleteRow_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("გსურთ ჩანაწერის წაშლა?", "ყურადღება", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //სტრიქონის წაშლა და გადასახდელი თანხის ველის მნიშვნელობის განახლება
                    dgv1.Rows.RemoveAt(dgv1.CurrentRow.Index);
                    dgv1.Update();
                    DocumentSum();
                    //i ინდექსის ერთით შემცირება
                    i--;
                    //თუ i=0, მაშინ გადასახდელი თანხა განულდება და დოკუმენტის თანხის ველის გასუფთავდება
                    if (i == 0)
                    {
                        sum = 0;
                        DocSum.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       

        private void SaleWindow_Load(object sender, EventArgs e)
        {
            if (db.Sales.Any())
            {
                var z = db.Sales.OrderByDescending(x => x.sdocnum).First().sdocnum;
                DocNumber.Text = (Convert.ToInt32(z) + 1).ToString();
            }
            else
            {
                DocNumber.Text = "1";
            }
            changetext.Visible = false;
            change.Visible = false;
            ValueField.Focus();
        }

        private void dgv1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //თუ რაოდენობა და ერთეულის ფასი წერია, სტრიქონის ჰამი გამოითვლება ავტომატურად
            if (dgv1.CurrentRow.Cells[3].Value != null && dgv1.CurrentRow.Cells[4].Value != null)
            {
                dgv1.CurrentRow.Cells[5].Value = Convert.ToDouble(dgv1.CurrentRow.Cells[3].Value) * Convert.ToDouble(dgv1.CurrentRow.Cells[4].Value);
            }
            DocumentSum();
        }

        //თუ გადახდილი თანხა აღემატება დოკუმენტის თანხას, გამოჩნდება გამოთვლილი ხურდის ველი
        private void PaidSum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                Execute_Click(sender, e);
            }
            else if(e.KeyCode==Keys.Enter)
            {
                if(Convert.ToDecimal(PaidSum.Text) > Convert.ToDecimal(DocSum.Text))
                {
                    change.Text = (Convert.ToDecimal(PaidSum.Text) - Convert.ToDecimal(DocSum.Text)).ToString();
                    changetext.Visible = true;
                    change.Visible = true;
                }
            }
        }

        //გაყიდვის შენახვა ბაზაში (ცხრილში Sales)
        private void Execute_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv1.RowCount; i++)
            {
                var sale = new Sale();
                sale.sdate = Convert.ToDateTime(Date.Value);
                sale.sdocnum = DocNumber.Text;
                sale.mcode = (int)dgv1.Rows[i].Cells[0].Value;
                sale.mqty = Convert.ToDecimal(dgv1.Rows[i].Cells[3].Value);
                sale.mprice = Convert.ToDecimal(dgv1.Rows[i].Cells[4].Value);
                sale.ssum = Convert.ToDecimal(dgv1.Rows[i].Cells[5].Value);

                db.Sales.Add(sale);
                db.SaveChanges();
            }
            this.Close();
        }
        //F6-ის დაჭერისას ვდგებით გადახდილი თანხის ველში, F2-ის დაჭერისას ვდგებით მნიშვნელობის შეყვანის ველში, Ctrl+D - სტრიქონის წაშლა, Ctrl+Enter - შენახვა
        private void SaleWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F6)
            {
                PaidSum.Focus();
            }
            else if(e.KeyCode==Keys.F2)
            {
                ValueField.Focus();
            }
            else if(e.Control && e.KeyCode == Keys.D)
            {
                DeleteRow_Click(sender, e);
            }
            else if(e.Control && e.KeyCode==Keys.Enter)
            {
                Execute_Click(sender, e);
            }
        }
    }
}
