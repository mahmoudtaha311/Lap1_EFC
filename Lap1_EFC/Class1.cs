using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap1_EFC
{
    internal class Class1
    {
    }
}
//public partial class Form1 : Form
//{
//    public UniversityContext context;
//    public Form1()
//    {
//        InitializeComponent();
//        context = new UniversityContext();
//    }

//    private void Form1_Load(object sender, EventArgs e)
//    {
//        var students = context.Students.ToList();
//        StudentTable.DataSource = students;
//        var department = context.Departments.ToList();
//        comboBox1.DataSource = department;
//        comboBox1.DisplayMember = "Name";
//        comboBox1.ValueMember = "Id";
//    }

//    private void button1_Click(object sender, EventArgs e)
//    {
//        var text = SearchText.Text;
//        var result = context.Students.Where(x => x.FirstName.ToLower().Contains(text.ToLower())).ToList();
//        StudentTable.DataSource = result;
//        SearchText.Text = "";
//    }

//    private void ResetBTN_Click(object sender, EventArgs e)
//    {
//        Form1_Load(sender, e);
//    }

//    private void AddBTN_Click(object sender, EventArgs e)
//    {
//        var firstName = textBox1.Text;
//        var lastName = textBox2.Text;
//        var age = int.Parse(textBox4.Text);
//        var gender = textBox6.Text;
//        var address = textBox3.Text;
//        var phoneNumber = textBox5.Text;
//        var department = (int)comboBox1.SelectedValue!;

//        Student std = new Student()
//        {
//            FirstName = firstName,
//            LastName = lastName,
//            Gender = gender,
//            Address = address,
//            PhoneNumber = phoneNumber,
//            Age = age,
//            DepartmentId = department
//        };
//        context.Students.Add(std);
//        context.SaveChanges();
//        var students = context.Students.ToList();
//        StudentTable.DataSource = students;
//    }

//}
//}


