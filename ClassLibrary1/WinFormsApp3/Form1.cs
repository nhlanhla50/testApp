using ClassLibrary1;
using System.Xml.Linq;

namespace WinFormsApp3;

public partial class Form1 : Form
{
    private readonly string fullName;

    public Form1()
    {
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        /* string ClassLibrary1.JointName(fullNameText, lastName, IDnumber, CellPhoneNumber, Cours);
        */
        string Message = $"your name is {FirstNameText.Text}  your surname is {LastNameText.Text} your ID number is  {IDnumberText.Text} the course you doing is  {CourseNameText.Text} your cellphone number is {CellPhoneNumText.Text}";
        MessageBox.Show(Message);
        // MessageBox.Show($"your full name is {FirstNameText.Text} {LastNameText.Text}{IDnumberText.Text}{CellPhoneNumText.Text}{CourseNameText.Text}");
        Console.WriteLine("I am here");
    }

    private void CellPhoneNumText_TextChanged(object sender, EventArgs e)
    {
        Console.WriteLine("I am here");
    }

    private void FirstNameText_TextChanged(object sender, EventArgs e)
    {

    }
}