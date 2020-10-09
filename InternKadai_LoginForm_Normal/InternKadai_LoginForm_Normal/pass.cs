using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace InternKadai_LoginForm_Normal
{
    public partial class pass : TextBox
    {

        public pass()
        {
            InitializeComponent();
        }

       

        private void pass_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.Text) == false)
            {

                bool IsCheckPassword = Regex.IsMatch(this.Text, @"[0-9]+");
                if (IsCheckPassword == false)
                {

                    MessageBox.Show("パスワードには数字が含まれている必要があります。",
                                    "パスワード入力文字違反",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    this.Text = "";
                    this.Select();
                    return;
                }

                IsCheckPassword = Regex.IsMatch(this.Text, @"[a-z]+");
                if (IsCheckPassword == false)
                {

                    MessageBox.Show("パスワードには英小文字が含まれている必要があります。",
                                    "パスワード入力文字違反",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    this.Text = "";
                    this.Select();
                    return;
                }

                IsCheckPassword = Regex.IsMatch(this.Text, @"[A-Z]+");
                if (IsCheckPassword == false)
                {

                    MessageBox.Show("パスワードには英大文字が含まれている必要があります。",
                                    "パスワード入力文字違反",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    this.Text = "";
                    this.Select();
                    return;
                }
            }
        }
    }
}
