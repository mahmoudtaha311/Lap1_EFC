using Lap1_EFC.Models;
using System;
using System.Data;
using System.Transactions;

namespace Lap1_EFC
{
    public partial class Form1 : Form
    {
        public TransactionContext context;
        public Form1()
        {
            InitializeComponent();
            context = new TransactionContext();


        }



        private void Form1_Load(object sender, EventArgs e)
        {
            var data = context.Users.ToList();
            dataGridView1.DataSource = data;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = textBox1.Text;
            var result = context.Users.Where(x => x.UserName.ToLower().Contains(data.ToLower())).ToList();
            dataGridView1.DataSource = result;
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var username = Name.Text;
            var id = int.Parse(Id.Text);
            var Age = int.Parse(age.Text);
            
            var user = new User { UserName = username, Id = id, Age = Age };
            context.Users.Add(user);
            context.SaveChanges();
            
        }
    }

}

