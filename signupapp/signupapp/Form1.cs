using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signupapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("please enter a Username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("The Password and Confirmation of password don't match!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            iUserRepository repository = new UserRepository();
            bool result = await repository.Insert(new User() { UserName = txtUserName.Text, Password = txtFullName.Text, FullName = txtFullName.Text, Address = txtAdress.Text, Email = txtEmail.Text });
            if (result)
            {
                MessageBox.Show("You have succesfully signed up", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
