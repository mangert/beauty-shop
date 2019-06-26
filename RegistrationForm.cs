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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            SetusernameComboBox();

        }

        //технические методы 

        private void SetusernameComboBox() //настройка комбобокса
        {
            var users = Users.GetAllUsers();
            usernameComboBox.Items.AddRange(users.OrderBy(user => user.UserName).ToArray());

            var source = new AutoCompleteStringCollection();
            source.AddRange(users.Select(user => user.UserName).ToArray());
            usernameComboBox.AutoCompleteCustomSource = source;
            usernameComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            usernameComboBox.AutoCompleteMode = AutoCompleteMode.Append;
        }

        
        
        //события формы
        private void submitButton_Click(object sender, EventArgs e)
        {
            User currentUser = (User)(usernameComboBox.SelectedItem);
            if (Users.ValidatePassword(currentUser, passwordBox.Text))
            {
                this.DialogResult = DialogResult.OK;
                Form1.currentUser = currentUser;                
                this.Close();
            }
                
            else{                
                infoLabel.Text = "Неверное имя пользователя или пароль";
                infoLabel.Visible = true;
            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            infoLabel.Visible = false;
        }

        private void usernameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            passwordBox.Clear();
        }
    }
}
