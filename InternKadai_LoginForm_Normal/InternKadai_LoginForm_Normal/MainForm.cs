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
    public partial class MainForm : Form{
        /// <summary>
        /// クラス内で使用する変数を定義します。
        /// </summary>
        private string _lastname;
        private string _firstname;

        /// <summary>
        /// コンストラクタを定義します。
        /// </summary>
        /// <param name="lastname"></param>
        /// <param name="firstname"></param>
        public MainForm(string lastname, string firstname){

            InitializeComponent();
            this._lastname = lastname;
            this._firstname = firstname;
        }

        public string UserName => _lastname + _firstname;
        


        /// <summary>
        /// フォームを読み込みます。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, System.EventArgs e){

            this.label_username.Text = "ようこそ！！　\n\n" + UserName + " さん！";
        }
    }
}
