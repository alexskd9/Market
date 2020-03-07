using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Market.Windows
{
    public partial class ProductBalance : Form
    {
        public ProductBalance()
        {
            InitializeComponent();
        }
        MarketEntities db = new MarketEntities();

        private void ProductBalance_Load(object sender, EventArgs e)
        {
            //საქონლის ნაშთებისა და თვითღირებულებების გამოტანა
            var table = db.Products.ToList();            
            dgv1.DataSource = table.Select(x => new ProductsBalance
            {
                Name = x.mname,
                //DefaultIfEmpty გამოიყენება null-ების იგნორირებისთვის
                Qty = Math.Round(db.Purchases.Where(z => z.mcode.Equals(x.mid)).Select(z => z.mqty).DefaultIfEmpty(0).Sum() - db.Sales.Where(z => z.mcode.Equals(x.mid)).Select(z => z.mqty).DefaultIfEmpty(0).Sum(),4),
                SelfCost = Math.Round(db.Purchases.Where(z => z.mcode.Equals(x.mid)).Select(z => z.mpprice).DefaultIfEmpty(0).Average(),4),
                SelfCostSum = Math.Round(((db.Purchases.Where(z => z.mcode.Equals(x.mid)).Select(z => z.mqty).DefaultIfEmpty(0).Sum() - db.Sales.Where(z => z.mcode.Equals(x.mid)).Select(z => z.mqty).DefaultIfEmpty(0).Sum())* db.Purchases.Where(z => z.mcode.Equals(x.mid)).Select(z => z.mpprice).DefaultIfEmpty(0).Average()),2),
            }).ToList();
            this.dgv1.Columns["Name"].HeaderText = "დასახელება";
            this.dgv1.Columns["Qty"].HeaderText = "რაოდენობა";
            this.dgv1.Columns["SelfCost"].HeaderText = "ერთეულის თვითღირებულება";
            this.dgv1.Columns["SelfCostSum"].HeaderText = "თვითღირებულების ჯამი";
        }
        

        //ექსპორტი ექსელში
        private void ExportExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel.Export(dgv1);
        }
    }

    class ProductsBalance
    {
        public string Name { get; set; }
        public decimal Qty { get; set; }
        public decimal SelfCost { get; set; }
        public decimal SelfCostSum { get; set; }
    }
}
