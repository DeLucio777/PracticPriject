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
        dataGridView1.Columns.Add("Code", "���");
        dataGridView1.Columns.Add("FullName", "���");
        dataGridView1.Columns.Add("Phone", "�������");
        dataGridView1.Columns.Add("Privileged", "�����������������");


        AddSampleData();
    }
    private void AddSampleData()
    {
        dataGridView1.Rows.Add(1, "������ ���� ��������", "123-456-7890", true);
        dataGridView1.Rows.Add(2, "������ ���� ��������", "098-765-4321", false);
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        // ������ ��������� ������� �� ������
        if (e.ColumnIndex == 3) // ���� ������ ������ IsActive
        {
            // ������ ���������
        }
    }
}