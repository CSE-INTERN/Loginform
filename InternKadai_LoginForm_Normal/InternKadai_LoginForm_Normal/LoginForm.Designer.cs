﻿namespace InternKadai_LoginForm_Normal
{
    partial class LoginForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox_LoginName = new System.Windows.Forms.TextBox();
            this.label_LoginName = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.textBox_Password = new InternKadai_LoginForm_Normal.PasswordText();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Login
            // 
            this.button_Login.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Login.Location = new System.Drawing.Point(98, 254);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(120, 38);
            this.button_Login.TabIndex = 3;
            this.button_Login.Text = "ログイン";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Cancel.Location = new System.Drawing.Point(274, 254);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(120, 38);
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.TabStop = false;
            this.button_Cancel.Text = "キャンセル";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // textBox_LoginName
            // 
            this.textBox_LoginName.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_LoginName.Location = new System.Drawing.Point(148, 39);
            this.textBox_LoginName.Name = "textBox_LoginName";
            this.textBox_LoginName.Size = new System.Drawing.Size(129, 21);
            this.textBox_LoginName.TabIndex = 1;
            this.textBox_LoginName.Leave += new System.EventHandler(this.textBox_LoginName_Leave);
            // 
            // label_LoginName
            // 
            this.label_LoginName.AutoSize = true;
            this.label_LoginName.Font = new System.Drawing.Font("メイリオ", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_LoginName.Location = new System.Drawing.Point(32, 39);
            this.label_LoginName.Name = "label_LoginName";
            this.label_LoginName.Size = new System.Drawing.Size(85, 23);
            this.label_LoginName.TabIndex = 4;
            this.label_LoginName.Text = "ログイン名";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("メイリオ", 10.8F);
            this.label_Password.Location = new System.Drawing.Point(34, 102);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(85, 23);
            this.label_Password.TabIndex = 5;
            this.label_Password.Text = "パスワード";
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.textBox_Password);
            this.panel.Controls.Add(this.textBox_LoginName);
            this.panel.Controls.Add(this.label_Password);
            this.panel.Controls.Add(this.label_LoginName);
            this.panel.Location = new System.Drawing.Point(98, 43);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(296, 183);
            this.panel.TabIndex = 6;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(148, 106);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(129, 19);
            this.textBox_Password.TabIndex = 7;
            this.textBox_Password.Leave += new System.EventHandler(this.textBox_Password_Leave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 342);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Login);
            this.Name = "LoginForm";
            this.Text = "ログイン画面";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox textBox_LoginName;
        private System.Windows.Forms.Label label_LoginName;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Panel panel;
        private PasswordText textBox_Password;
    }
}

