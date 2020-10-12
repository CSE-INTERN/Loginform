namespace InternKadai_LoginForm_Normal
{
    partial class MessageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MessageText = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageText
            // 
            this.MessageText.Enabled = false;
            this.MessageText.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MessageText.Location = new System.Drawing.Point(0, 0);
            this.MessageText.Multiline = true;
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(450, 190);
            this.MessageText.TabIndex = 3;
            this.MessageText.Text = " ";
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OKButton.Location = new System.Drawing.Point(171, 201);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(110, 40);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Visible = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.YesButton.Location = new System.Drawing.Point(30, 201);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(110, 40);
            this.YesButton.TabIndex = 1;
            this.YesButton.Text = "はい";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Visible = false;
            // 
            // NoButton
            // 
            this.NoButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NoButton.Location = new System.Drawing.Point(313, 201);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(110, 40);
            this.NoButton.TabIndex = 2;
            this.NoButton.Text = "いいえ";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Visible = false;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 261);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.MessageText);
            this.Name = "MessageForm";
            this.Text = "メッセージ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
    }
}