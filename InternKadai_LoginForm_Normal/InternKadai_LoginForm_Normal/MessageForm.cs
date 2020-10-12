using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternKadai_LoginForm_Normal
{
    public partial class MessageForm : Form
    {
        /// <summary>
        /// true：OK　、false：はい/いいえ
        /// </summary>
        private bool changeButton;

        /// <summary>
        /// 0：未選択、1：OK、 2：はい、 3：いいえ
        /// </summary>
        private int selectButton = 0;

        /// <summary>
        /// コンストラクタ定義
        /// </summary>
        public MessageForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="che"></param>
        /// <returns></returns>
        public  MessageForm(string message , bool changeButton)
        {
            InitializeComponent();
            MessageText.Text = message;
           
            if (changeButton == true) {
                YesButton.Visible = false;
                NoButton.Visible = false;
                OKButton.Visible = true;
            }
            else
            {
                YesButton.Visible = true;
                NoButton.Visible = true;
                OKButton.Visible = false;
            }
             //return selectButton;
        }

        /// <summary>
        /// 「OK」ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            selectButton = 1;
            this.Close();
        }

        /// <summary>
        /// 「はい」ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private int YesButton_Click(object sender, EventArgs e)
        {
            selectButton = 2;
            this.Close();
            return selectButton;
        }

        /// <summary>
        /// 「いいえ」ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private int NoButton_Click(object sender, EventArgs e)
        {
            selectButton = 3;
            this.Close();
            return selectButton;
        }

    }
}
