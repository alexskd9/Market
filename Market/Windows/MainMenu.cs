using System;
using System.Windows.Forms;
using Market.Windows;

namespace Market
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        //მთავარი მენიუ, საიდანაც ხდება შესაბამისი ფანჯრების გამოძახება

        private void Products_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductsList product = new ProductsList();
            product.Show();
        }

        private void Groups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GroupList groups = new GroupList();
            groups.Show();
        }

        private void PurchaseWindow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PurchaseWindow pw = new PurchaseWindow();
            pw.Show();
        }

        private void SaleWindow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaleWindow sw = new SaleWindow();
            sw.Show();
        }

        private void SoldList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SoldProductsList spl = new SoldProductsList();
            spl.Show();
        }

        private void ShowProductBalance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductBalance pb = new ProductBalance();
            pb.Show();
        }

        private void Options_Click(object sender, EventArgs e)
        {
            OptionsWindow ow = new OptionsWindow();
            ow.Show();
        }

        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode==Keys.O)
            {
                OptionsWindow ow = new OptionsWindow();
                ow.Show();
            }
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
