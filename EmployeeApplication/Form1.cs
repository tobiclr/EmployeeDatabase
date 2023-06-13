namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {

        private BindingSource bindingSourceEmployee = new BindingSource();

        private long EmployeeID;
        private string Firstname;
        private string Lastname;
        private string Position;




        public frmEmployeeDatabase()
        {
            InitializeComponent();
        }

        private void frmEmployeeDatabase_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeID = Convert.ToInt64(txtEmployeeID.Text);
            Firstname = txtFirstname.Text;
            Lastname = txtLastname.Text;
            Position = txtPosition.Text;

            bindingSourceEmployee.Add(new Employee(EmployeeID, Firstname, Lastname, Position));
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = bindingSourceEmployee;




        }
    }
}