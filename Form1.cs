using ObjectPooling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pool pool = new Pool();
            Person person01 = pool.GetPerson();
            Console.WriteLine("First person");
            Person person02 = pool.GetPerson();
            Console.WriteLine("Second person");
        }
    }
}
