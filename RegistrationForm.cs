using System;
using System.Data;
using System.Linq;
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
            if (usernameComboBox.SelectedIndex < 0)
            {
                infoLabel.Text = "Пользователь не найден";
                infoLabel.Visible = true;                
                return;
            }
            User currentUser = (User)(usernameComboBox.SelectedItem);
            
            if (Users.ValidatePassword(currentUser, passwordBox.Text))
            {
                this.DialogResult = DialogResult.OK;
                Form1.currentUser = currentUser;                
                this.Close();
            }
                
            else{                
                infoLabel.Text = "Неверная пара логин/пароль";
                infoLabel.Visible = true;
            }
        }

        private void ClearInfoString(object sender, EventArgs e)
        {            
            infoLabel.Visible = false;            
        }

        private void usernameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            passwordBox.Clear();
            passwordBox.Text = "";
        }
        
    }
}
