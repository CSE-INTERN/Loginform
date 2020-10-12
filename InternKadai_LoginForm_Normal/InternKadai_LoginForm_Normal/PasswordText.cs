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
    public partial class PasswordText : TextBox
    {
        public PasswordText() { }
        public void PasswordText_Leave()
        {
            if (String.IsNullOrEmpty(this.Text) == false)
            {

                bool IsCheckPassword = Regex.IsMatch(this.Text, @"[0-9]+");
                if (IsCheckPassword == false)
                {
                    using (var MSGBox = new MessageForm("パスワードには数字が含まれている必要があります。", true))
                    {
                        MSGBox.ShowDialog();
                    }

                    this.Text = "";
                    this.Select();
                    return;
                }

                IsCheckPassword = Regex.IsMatch(this.Text, @"[a-z]+");
                if (IsCheckPassword == false)
                {
                    using (var MSGBox = new MessageForm("パスワードには英小文字が含まれている必要があります。", true))
                    {
                        MSGBox.ShowDialog();
                    }
                    this.Text = "";
                    this.Select();
                    return;
                }

                IsCheckPassword = Regex.IsMatch(this.Text, @"[A-Z]+");
                if (IsCheckPassword == false)
                {
                    using (var MSGBox = new MessageForm("パスワードには英大文字が含まれている必要があります。", true))
                    {
                        MSGBox.ShowDialog();
                    }

                    this.Text = "";
                    this.Select();
                    return;
                }
            }
        }
    }
}
