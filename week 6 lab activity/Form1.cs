namespace week_6_lab_activity
{
    public partial class Form1 : Form
    {
        string name, age, ID, pos, type, email, dept;
        public Form1()
        {
            InitializeComponent();
            postbx.DropDownStyle = ComboBoxStyle.DropDownList;
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
    }
}
