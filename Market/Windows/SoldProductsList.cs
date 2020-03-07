using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Market
{
    public partial class SoldProductsList : Form
    {
        public SoldProductsList()
        {
            InitializeComponent();
        }

        MarketEntities db = new MarketEntities();

        private void SoldProductsList_Load(object sender, EventArgs e)
        {
            //ფანჯრის მთელ ეკრანზე გახსნა
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            //მონაცემების მოტანა Sales ცხრილიდან
            var sold = db.Sales.OrderBy(x => x.sid);
            dgv1.DataSource = sold.Select(x => new SoldList
            {
                Date = x.sdate.ToString(),
                DocNumber = x.sdocnum,
                //საქონლის დასახელების ძებნა
                Name = db.Products.Where(z => z.mid == x.mcode).Select(z => z.mname).FirstOrDefault().ToString(),
                //საქონლის საზომი ერთეულის დასახელების ძებნა
                MUnitName = db.MUnits.Where(z=>z.mucode.Equals(db.Products.Where(y=>y.mid.Equals(x.mcode)).Select(y=>y.munit).FirstOrDefault())).Select(z=>z.muname).FirstOrDefault().ToString(),
                Qty = x.mqty,
                //საქონლის თვითღირებულების გამოთვლა საშუალო არითმეტიკულის მიხედვით
                SelfCost = db.Purchases.Where(z => z.mcode == x.mcode).Select(z => z.mpprice).DefaultIfEmpty(0).Average(),
                //საქონლის თვითღირებულების ჯამის გამოთვლა საშუალო არითმეტიკულის მიხედვით
                SelfCostSum = (x.mqty* db.Purchases.Where(z => z.mcode == x.mcode).Select(z => z.mpprice).DefaultIfEmpty(0).Average()),
                Price=x.mprice,
                Sum=x.ssum,
                //მოგების გამოთვლა
                Profit= db.Purchases.Where(z => z.mcode == x.mcode).Select(z => z.mpprice).DefaultIfEmpty(0).Average() == 0 ? 0 : (x.ssum - (x.mqty * db.Purchases.Where(z => z.mcode == x.mcode).Select(z => z.mpprice).DefaultIfEmpty(0).Average()))
            }).ToList();
            //ცხრილის სხვეტების გადარქმევა
            this.dgv1.Columns["Date"].HeaderText = "თარიღი";
            this.dgv1.Columns["DocNumber"].HeaderText = "დოკუმენტის N";
            this.dgv1.Columns["Name"].HeaderText = "დასახელება";
            this.dgv1.Columns["MUnitName"].HeaderText = "საზომი ერთეული";
            this.dgv1.Columns["Qty"].HeaderText = "რაოდენობა";
            this.dgv1.Columns["SelfCost"].HeaderText = "თვითღირებულება";
            this.dgv1.Columns["SelfCostSum"].HeaderText = "თვითღირებულების ჯამი";
            this.dgv1.Columns["Price"].HeaderText = "ფასი";
            this.dgv1.Columns["Sum"].HeaderText = "თანხა";
            this.dgv1.Columns["Profit"].HeaderText = "მოგება";

            //სვეტების ფორმატის შეცვლა
            this.dgv1.Columns["SelfCost"].DefaultCellStyle.Format = "N4";
            this.dgv1.Columns["SelfCostSum"].DefaultCellStyle.Format = "N2";
            this.dgv1.Columns["Price"].DefaultCellStyle.Format = "N4";
            this.dgv1.Columns["Sum"].DefaultCellStyle.Format = "N2";
            this.dgv1.Columns["Profit"].DefaultCellStyle.Format = "N2";
        }

        //ექსელში გამოტანა
        private void ExportExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel.Export(dgv1);
        }
    }

    public class SoldList
    {
        public string Date { get; set; }
        public string DocNumber { get; set; }
        public string Name { get; set; }
        public string MUnitName { get; set; }
        public decimal Qty { get; set; }
        public decimal SelfCost { get; set; }
        public decimal SelfCostSum { get; set; }
        public decimal Price { get; set; }
        public decimal Sum { get; set; }
        public decimal Profit { get; set; }
    }
}
