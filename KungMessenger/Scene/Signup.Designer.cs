namespace KungMessenger.Scene
{
    partial class Signup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PW_Label = new System.Windows.Forms.Label();
            this.ID_Label = new System.Windows.Forms.Label();
            this.Submit_Btn = new System.Windows.Forms.Button();
            this.Nickname_Textbox = new System.Windows.Forms.TextBox();
            this.PWCheck_Textbox = new System.Windows.Forms.TextBox();
            this.PW_Textbox = new System.Windows.Forms.TextBox();
            this.IDCheck_Btn = new System.Windows.Forms.Button();
            this.ID_Textbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 490);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PW_Label);
            this.panel2.Controls.Add(this.ID_Label);
            this.panel2.Controls.Add(this.Submit_Btn);
            this.panel2.Controls.Add(this.Nickname_Textbox);
            this.panel2.Controls.Add(this.PWCheck_Textbox);
            this.panel2.Controls.Add(this.PW_Textbox);
            this.panel2.Controls.Add(this.IDCheck_Btn);
            this.panel2.Controls.Add(this.ID_Textbox);
            this.panel2.Location = new System.Drawing.Point(12, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 417);
            this.panel2.TabIndex = 0;
            // 
            // PW_Label
            // 
            this.PW_Label.AutoSize = true;
            this.PW_Label.Location = new System.Drawing.Point(3, 223);
            this.PW_Label.Name = "PW_Label";
            this.PW_Label.Size = new System.Drawing.Size(50, 20);
            this.PW_Label.TabIndex = 9;
            this.PW_Label.Text = "label1";
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Location = new System.Drawing.Point(3, 133);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(50, 20);
            this.ID_Label.TabIndex = 8;
            this.ID_Label.Text = "label1";
            // 
            // Submit_Btn
            // 
            this.Submit_Btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Submit_Btn.Location = new System.Drawing.Point(65, 312);
            this.Submit_Btn.Name = "Submit_Btn";
            this.Submit_Btn.Size = new System.Drawing.Size(207, 29);
            this.Submit_Btn.TabIndex = 7;
            this.Submit_Btn.Text = "Submit";
            this.Submit_Btn.UseVisualStyleBackColor = false;
            this.Submit_Btn.Click += new System.EventHandler(this.Submit_Btn_Click);
            // 
            // Nickname_Textbox
            // 
            this.Nickname_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.Nickname_Textbox.Location = new System.Drawing.Point(65, 279);
            this.Nickname_Textbox.Name = "Nickname_Textbox";
            this.Nickname_Textbox.Size = new System.Drawing.Size(207, 27);
            this.Nickname_Textbox.TabIndex = 6;
            this.Nickname_Textbox.Text = "NickName";
            this.Nickname_Textbox.Enter += new System.EventHandler(this.Nickname_Textbox_Enter);
            this.Nickname_Textbox.Leave += new System.EventHandler(this.Nickname_Textbox_Leave);
            // 
            // PWCheck_Textbox
            // 
            this.PWCheck_Textbox.BackColor = System.Drawing.Color.White;
            this.PWCheck_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.PWCheck_Textbox.Location = new System.Drawing.Point(3, 193);
            this.PWCheck_Textbox.Name = "PWCheck_Textbox";
            this.PWCheck_Textbox.Size = new System.Drawing.Size(328, 27);
            this.PWCheck_Textbox.TabIndex = 5;
            this.PWCheck_Textbox.Text = "Password";
            this.PWCheck_Textbox.Enter += new System.EventHandler(this.PWCK_TextBox_Enter);
            this.PWCheck_Textbox.Leave += new System.EventHandler(this.PWCK_TextBox_Leave);
            // 
            // PW_Textbox
            // 
            this.PW_Textbox.BackColor = System.Drawing.Color.White;
            this.PW_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.PW_Textbox.Location = new System.Drawing.Point(3, 160);
            this.PW_Textbox.Name = "PW_Textbox";
            this.PW_Textbox.Size = new System.Drawing.Size(328, 27);
            this.PW_Textbox.TabIndex = 2;
            this.PW_Textbox.Text = "Password";
            this.PW_Textbox.Enter += new System.EventHandler(this.PW_TextBox_Enter);
            this.PW_Textbox.Leave += new System.EventHandler(this.PW_TextBox_Leave);
            // 
            // IDCheck_Btn
            // 
            this.IDCheck_Btn.Location = new System.Drawing.Point(229, 101);
            this.IDCheck_Btn.Name = "IDCheck_Btn";
            this.IDCheck_Btn.Size = new System.Drawing.Size(102, 29);
            this.IDCheck_Btn.TabIndex = 4;
            this.IDCheck_Btn.Text = "SingUp";
            this.IDCheck_Btn.UseVisualStyleBackColor = true;
            this.IDCheck_Btn.Click += new System.EventHandler(this.IDCheck_Btn_Click);
            // 
            // ID_Textbox
            // 
            this.ID_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.ID_Textbox.Location = new System.Drawing.Point(3, 103);
            this.ID_Textbox.Name = "ID_Textbox";
            this.ID_Textbox.Size = new System.Drawing.Size(223, 27);
            this.ID_Textbox.TabIndex = 3;
            this.ID_Textbox.Text = "ID";
            this.ID_Textbox.Enter += new System.EventHandler(this.ID_TextBox_Enter);
            this.ID_Textbox.Leave += new System.EventHandler(this.ID_TextBox_Leave);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Signup";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox ID_Textbox;
        private Button IDCheck_Btn;
        private Button Submit_Btn;
        private TextBox Nickname_Textbox;
        private TextBox PWCheck_Textbox;
        private TextBox PW_Textbox;
        private Label PW_Label;
        private Label ID_Label;
    }
}