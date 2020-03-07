using Excel = Microsoft.Office.Interop.Excel;

public static class ExportToExcel
{
    public static void Export(System.Windows.Forms.DataGridView dgv1)
    {
        var ex = new Excel.Application();
        var sheet = new Excel.Worksheet();
        int k = 2;
        ex.Workbooks.Add();
        sheet = ex.Worksheets["Sheet1"];
        sheet.Name = "test";

        //ცხრილის სათაურის გამოტანა
        for (int t = 0; t < dgv1.ColumnCount; t++)
        {
            sheet.Cells[1, t + 1] = dgv1.Columns[t].HeaderText;
        }

        //ცხრილის მონაცემების გამოტანა
        for (int i = 0; i < dgv1.RowCount; i++)
        {
            for (int t = 0; t < dgv1.ColumnCount; t++)
            {
                sheet.Cells[k, t + 1] = dgv1.Rows[i].Cells[t].Value;
            }
            k++;
        }

        //ცხრილის გამოსახულების შეცვლა
        sheet.Range[sheet.Cells[1, 1], sheet.Cells[dgv1.RowCount + 1, dgv1.Columns.Count]].Font.Name = "Sylfaen";
        sheet.Range[sheet.Cells[1, 1], sheet.Cells[dgv1.RowCount + 1, dgv1.Columns.Count]].Font.Size = "12";
        sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, dgv1.Columns.Count]].Font.Bold = true;
        sheet.Range[sheet.Cells[1, 1], sheet.Cells[dgv1.RowCount + 1, dgv1.Columns.Count]].Borders.LineStyle = 1;
        sheet.Range[sheet.Cells[1, 1], sheet.Cells[dgv1.RowCount + 1, dgv1.Columns.Count]].Borders.Weight = 1;

        sheet.Columns.AutoFit();
        sheet.Rows.AutoFit();
        ex.Visible = true;
    }
}    