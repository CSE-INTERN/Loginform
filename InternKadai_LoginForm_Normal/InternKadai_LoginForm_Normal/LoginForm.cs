using System;
using System.Data;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace InternKadai_LoginForm_Normal
{
    //変更したつもり2
    public partial class LoginForm : Form
    {
         
        public LoginForm()
        {

            InitializeComponent();
        }

        /// <summary>
        /// クラス内で使用する変数を定義します。
        /// </summary>
        private SqlConnection sqlConnection;
        private SqlDataReader sqlDataReader;

        /// <summary>
        /// ログイン名に入力された文字列のチェック処理を記述します。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_LoginName_Leave(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(this.textBox_LoginName.Text) == false)
            {

                bool IsCheckLoginName = Regex.IsMatch(this.textBox_LoginName.Text, @"^[a-z]+$");
                if (IsCheckLoginName == false)
                {

                    MessageBox.Show("ログイン名は半角英小文字のみです。",
                                    "ログイン名入力文字違反",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    this.textBox_LoginName.Text = "";
                    this.textBox_LoginName.Select();
                    return;

                }
            }
        }


        /// <summary>
        /// パスワードに入力された文字列のチェック処理を記述します。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Password_Leave(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(this.textBox_Password.Text) == false)
            {

                bool IsCheckPassword = Regex.IsMatch(this.textBox_Password.Text, @"[0-9]+");
                if (IsCheckPassword == false)
                {

                    MessageBox.Show("パスワードには数字が含まれている必要があります。",
                                    "パスワード入力文字違反",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    this.textBox_Password.Text = "";
                    this.textBox_Password.Select();
                    return;
                }

                IsCheckPassword = Regex.IsMatch(textBox_Password.Text, @"[a-z]+");
                if (IsCheckPassword == false)
                {

                    MessageBox.Show("パスワードには英小文字が含まれている必要があります。",
                                    "パスワード入力文字違反",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    this.textBox_Password.Text = "";
                    this.textBox_Password.Select();
                    return;
                }

                IsCheckPassword = Regex.IsMatch(textBox_Password.Text, @"[A-Z]+");
                if (IsCheckPassword == false)
                {

                    MessageBox.Show("パスワードには英大文字が含まれている必要があります。",
                                    "パスワード入力文字違反",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    this.textBox_Password.Text = "";
                    this.textBox_Password.Select();
                    return;
                }
            }
        }

        protected void ConnectionDB()
        {

            this.sqlConnection = new SqlConnection(InternKadaiDatabase.ConnectionString());
            this.sqlConnection.Open();
        }


        /// <summary>
        /// ログインボタンが押下された時の処理を記述します。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Login_Click(object sender, EventArgs e)
        {


            //ログイン名の入力チェックを行います。
            if (String.IsNullOrEmpty(this.textBox_LoginName.Text))
            {

                MessageBox.Show("ログイン名を入力してください。",
                                "ログイン名未入力",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            //パスワードの入力チェックを行います。
            if (String.IsNullOrEmpty(this.textBox_Password.Text))
            {

                MessageBox.Show("パスワードを入力してください。",
                                "パスワード未入力",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }


            //入力されたログイン名とパスワードが、DBに合致するかどうかチェックします。
            try
            {

                ConnectionDB();

                //ログインユーザー数を検索する
                string sql = " SELECT Id,LastName,FirstName,LoginPassword " +
                             " FROM [User]" +
                             " WHERE LoginName = " +
                             InternKadaiCommonFunction.SQLStringFormat(this.textBox_LoginName.Text);

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = sql;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlCommand.Dispose();


                var id = new List<string>();
                var lastname = new List<string>();
                var firstname = new List<string>();
                var password = new List<string>();

                while (sqlDataReader.Read())
                {
                    id.Add(sqlDataReader["Id"].ToString());
                    lastname.Add(sqlDataReader["LastName"].ToString());
                    firstname.Add(sqlDataReader["FirstName"].ToString());
                    password.Add(sqlDataReader["LoginPassword"].ToString());
                }

                //ログインユーザ数ーをもとに処理を分岐します。
                //1.ログインユーザがDBに登録されていない場合、エラーメッセージを返す
                if (id.Count == 0)
                {

                    MessageBox.Show("ユーザーが登録されていません。\nユーザーを登録してください。",
                                    "エラーメッセージ",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;

                    //2.ログインユーザが登録されている場合
                }
                else if (id.Count == 1)
                {


                    //パスワードが一致している場合、メイン画面へ遷移する
                    if (textBox_Password.Text.CompareTo(password) == 0)
                    {

                        MainForm mf = new MainForm(lastname.ToString(), firstname.ToString());
                        mf.Show();


                        //パスワードが間違っている場合、エラーメッセージを返す
                    }
                    else
                    {

                        MessageBox.Show("パスワードが間違っています。\n再度入力してください。",
                                        "エラーメッセージ",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);

                        this.textBox_LoginName.Text = "";
                        this.textBox_Password.Text = "";
                    }


                    //3.ログインユーザが同名で登録されている場合、エラーメッセージを返す
                }
                else
                {

                    MessageBox.Show("ユーザーが複数登録されています。\nシステム管理者に問い合わせください。",
                                    "エラーメッセージ",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                                "エラーメッセージ",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

            }
            finally
            {

                if (sqlConnection.State 　==　 ConnectionState.Open)
                {

                    sqlConnection.Close();
                    sqlConnection.Dispose();
                }
                if (sqlDataReader != null) {
                    sqlDataReader.Close();
                    sqlDataReader.Dispose();
                }

            }
        }


        /// <summary>
        /// キャンセルボタンが押下された時の処理を記述します。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Cancel_Click(object sender, EventArgs e)
        {

            this.textBox_LoginName.Text = "";
            this.textBox_Password.Text = "";
        }

    }
}
