namespace lab2;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {
        dataGridView1.Columns.Add("Number", "Number");
        dataGridView1.Columns.Add("Client", "Client");
        dataGridView1.Columns.Add("Date", "Date");
        dataGridView1.Columns.Add("�����", "Adress");
        DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
        checkBoxColumn.Name = "Urgency";
        checkBoxColumn.HeaderText = "Urgency";
        dataGridView1.Columns.Add(checkBoxColumn);
        //AddSampleData();
    }
    //private void AddSampleData()
    //{
    //    dataGridView1.Rows.Add(1, "Ivan Ivanov Hyuev", "123-456-7890", true);
    //    dataGridView1.Rows.Add(2, "", "098-765-4321", false);
    //}

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == 3)
        {
            //hz ne nado
        }
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int orderId;
        if (int.TryParse(textBox1.Text, out orderId))
        {
            LoadOrderData();
        }
        else
        {
            MessageBox.Show("������� ���������� ����� ������.");
        }
    }
    private void LoadOrderData()
    {
        //TODO: load data
        List<Ordere> orders = new List<Ordere>
        {
            new Ordere()
        };
        dataGridView1.DataSource = orders;
    }

    private void AddItemToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.Visible = false;
        Form2 f1 = new Form2();
        f1.ShowDialog();
    }

    private void AddCustomerToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.Visible = false;
        Form3 f = new Form3();
        f.ShowDialog();
    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {

    }
}