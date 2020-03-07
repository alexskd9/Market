using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Windows.Forms;

namespace Market.Windows
{
    public partial class OptionsWindow : Form
    {
        public OptionsWindow()
        {
            InitializeComponent();
        }
        MarketEntities db = new MarketEntities();
        //სარეზერვო ასლის შექმნა
        private void Backup_Click(object sender, EventArgs e)
        {
            //პროგრეს ბარის მნიშვნელობის განულება
            ProgressBar.Value = 0;
            try
            {
                db.Dispose();
                //SQL სერვერის მისამართის, ლოგინის და პაროლის მითითება
                Server DataBase = new Server(new ServerConnection($@".\{ServerName.Text}", "sa","SaSa111"));
                //მონაცემთა ბაზის არჩევა
                Backup dbBackup = new Backup() { Action = BackupActionType.Database, Database = "Market" };
                //სარეზერვო ასლის შენახვის ადგილი და ტიპი
                dbBackup.Devices.AddDevice($@"C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.{ServerName.Text}\MSSQL\Backup\Market.bak", DeviceType.File);                
                dbBackup.Initialize = true;
                //დასრულების პროცენტის რეცხვის გამოთვლა
                dbBackup.PercentComplete += DB_PercentComplete;
                dbBackup.SqlBackupAsync(DataBase);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
        //სარეზერვო ასლის აღდგენა
        private void RestoreDB_Click(object sender, EventArgs e)
        {
            db.Dispose();
            //სარეზერვო ასლის პოვნა და არჩევა
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "აირჩიეთ სარეზერვო ასლი";
            //.bak ფაილების გაფილტვრა
            file.Filter = "SQL backup files (.bak)|*.bak";
            file.InitialDirectory = $@"C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.{ServerName.Text}\MSSQL\Backup";
            file.FileName = "";
            var result = file.ShowDialog();
            if (result == DialogResult.OK)
            {
                Server DataBase = new Server(new ServerConnection($@".\{ServerName.Text}", "sa", "SaSa111"));
                Restore dbRestore = new Restore() { Action = RestoreActionType.Database, Database = "Market" };
                //სარეზერვო ასლად არჩეული ფაილის გამოყენება
                dbRestore.Devices.AddDevice($"{file.FileName}", DeviceType.File);
                dbRestore.PercentComplete += DB_PercentComplete;
                dbRestore.SqlRestoreAsync(DataBase);
            }

        }
        private void DB_PercentComplete (object sender, PercentCompleteEventArgs e)
        {
            //პროგრეს ბარის შევსება
            ProgressBar.Invoke((MethodInvoker)delegate
            {
                ProgressBar.Value = e.Percent;
                ProgressBar.Update();                
            });
            //პროცენტის ასახვა
            Percent.Invoke((MethodInvoker)delegate
            {
                Percent.Text = $"{e.Percent}%";
            });           
        }
        //სისტემა მუშაობს ლოკარურად, მაგრამ SQL-ს შეიძლება სხვა სახელი ჰქონდეს. ჩემს შემთხვევაში 2 სხვადასხვა კომპიუტერზე SQL მიყენია სახელებით SQLEXPRESS და ASACC, ამიტომ დავამატე ეს ორი ვარიანტი
        private void OptionsWindow_Load(object sender, EventArgs e)
        {
            ServerName.Items.Add("ASACC");
            ServerName.Items.Add("SQLEXPRESS");
        }
    }
}
