using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyShop
{
    public partial class Form1 : Form
    {
        public static User currentUser = null;
        RegistrationForm registration = new RegistrationForm();

        public Form1()
        {
            InitializeComponent();       
            
        }
        //события формы
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();            
            if (registration.ShowDialog() == DialogResult.OK)
            {
                invitationLabel.Text = "Добро пожаловать, " + currentUser.UserName;
                this.Show();
            }
            else this.Close();            
        }        
    }
}
