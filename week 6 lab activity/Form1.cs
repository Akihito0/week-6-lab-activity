using GemBox.Spreadsheet.WinFormsUtilities;
using GemBox.Spreadsheet;

namespace week_6_lab_activity
{
    public partial class Form1 : Form
    {
        string name, age, ID, pos, type, email, dept;
        public Form1()
        {
            InitializeComponent();
            postbx.DropDownStyle = ComboBoxStyle.DropDownList;
            savebtn.Enabled = false;
        }



        private void clearbtn_Click(object sender, EventArgs e)
        {
            nametbx.Text = "";
            agetbx.Text = "";
            employeeIDtxb.Text = "";
            postbx.SelectedIndex = -1;
            emailAddtbx.Text = "";
            depttbx.Text = "";
            typetbx.Text = "";
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter =
             "XLS files (*.xls, *.xlt)|*.xls;*.xlt|" +
             "XLSX files (*.xlsx, *.xlsm, *.xltx, *.xltm)|*.xlsx;*.xlsm;*.xltx;*.xltm|" +
             "ODS files (*.ods, *.ots)|*.ods;*.ots|" +
             "CSV files (*.csv, *.tsv)|*.csv;*.tsv|" +
             "HTML files (*.html, *.htm)|*.html;*.htm";
            openFileDialog.FilterIndex = 2;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
                var workbook = ExcelFile.Load(openFileDialog.FileName);
                var worksheet = workbook.Worksheets.ActiveWorksheet;
                // From ExcelFile to DataGridView.
                DataGridViewConverter.ExportToDataGridView(
                worksheet,
                this.dataGridView1,
                new ExportToDataGridViewOptions() { ColumnHeaders = true }); ;
            }
            savebtn.Enabled = true;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter =
            "XLS (*.xls)|*.xls|" +
            "XLT (*.xlt)|*.xlt|" +
            "XLSX (*.xlsx)|*.xlsx|" +
            "XLSM (*.xlsm)|*.xlsm|" +
            "XLTX (*.xltx)|*.xltx|" +
            "XLTM (*.xltm)|*.xltm|" +
            "ODS (*.ods)|*.ods|" +
            "OTS (*.ots)|*.ots|" +
            "CSV (*.csv)|*.csv|" +
            "TSV (*.tsv)|*.tsv|" +
            "HTML (*.html)|*.html|" +
            "MHTML (.mhtml)|*.mhtml|" +
            "PDF (*.pdf)|*.pdf|" +
            "XPS (*.xps)|*.xps|" +
            "BMP (*.bmp)|*.bmp|" +
            "GIF (*.gif)|*.gif|" +
            "JPEG (*.jpg)|*.jpg|" +
            "PNG (*.png)|*.png|" +
            "TIFF (*.tif)|*.tif|" +
            "WMP (*.wdp)|*.wdp";
            saveFileDialog.FilterIndex = 3;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = new ExcelFile();
                var worksheet = workbook.Worksheets.Add("Sheet1");
                // From DataGridView to ExcelFile.
                DataGridViewConverter.ImportFromDataGridView(
                worksheet,
                this.dataGridView1,
                new ImportFromDataGridViewOptions() { ColumnHeaders = true });
                workbook.Save(saveFileDialog.FileName);
            }
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            name = nametbx.Text;
            age = agetbx.Text;
            ID = employeeIDtxb.Text;
            pos = postbx.SelectedItem?.ToString();
            email = emailAddtbx.Text;
            dept = depttbx.Text;
            type = typetbx.Text;

            // Add the data to the DataGridView
            dataGridView1.Rows.Add(name, age, ID, pos, email, dept, type);

            // Clear the input fields after submission
            clearbtn_Click(sender, e);
            savebtn.Enabled = true;
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                nametbx.Text = selectedRow.Cells[0].Value.ToString();
                agetbx.Text = selectedRow.Cells[1].Value.ToString();
                employeeIDtxb.Text = selectedRow.Cells[2].Value.ToString();
                postbx.SelectedItem = selectedRow.Cells[3].Value.ToString();
                emailAddtbx.Text = selectedRow.Cells[4].Value.ToString();
                depttbx.Text = selectedRow.Cells[5].Value.ToString();
                typetbx.Text = selectedRow.Cells[6].Value.ToString();

                // Remove the selected row from the DataGridView
                dataGridView1.Rows.Remove(selectedRow);
            }
            savebtn.Enabled = true;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }
    }
}
