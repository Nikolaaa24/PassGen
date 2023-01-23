namespace passgen
{
    partial class passgen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.paramlbl = new System.Windows.Forms.Label();
            this.passlength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.csprngchk = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prngchk = new System.Windows.Forms.CheckBox();
            this.csharpmethodchk = new System.Windows.Forms.CheckBox();
            this.genpassbtn = new System.Windows.Forms.Button();
            this.seedtxt = new System.Windows.Forms.TextBox();
            this.mathformtxt = new System.Windows.Forms.TextBox();
            this.errortxt = new System.Windows.Forms.Label();
            this.allowedchars = new System.Windows.Forms.TextBox();
            this.allowedcharslbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.defaultchk = new System.Windows.Forms.CheckBox();
            this.customchk = new System.Windows.Forms.CheckBox();
            this.copybtn = new System.Windows.Forms.Button();
            this.cpdtxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paramlbl
            // 
            this.paramlbl.AutoSize = true;
            this.paramlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.paramlbl.Location = new System.Drawing.Point(278, 9);
            this.paramlbl.Name = "paramlbl";
            this.paramlbl.Size = new System.Drawing.Size(181, 37);
            this.paramlbl.TabIndex = 0;
            this.paramlbl.Text = "PARAMETERS";
            // 
            // passlength
            // 
            this.passlength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.passlength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passlength.Location = new System.Drawing.Point(12, 74);
            this.passlength.Name = "passlength";
            this.passlength.Size = new System.Drawing.Size(270, 23);
            this.passlength.TabIndex = 1;
            this.passlength.Text = "Password Length";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(278, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "PASSWORD";
            // 
            // passtxt
            // 
            this.passtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.passtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passtxt.Enabled = false;
            this.passtxt.Location = new System.Drawing.Point(271, 400);
            this.passtxt.Name = "passtxt";
            this.passtxt.ReadOnly = true;
            this.passtxt.Size = new System.Drawing.Size(168, 23);
            this.passtxt.TabIndex = 3;
            this.passtxt.Text = "Password";
            // 
            // csprngchk
            // 
            this.csprngchk.AutoSize = true;
            this.csprngchk.Checked = true;
            this.csprngchk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.csprngchk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csprngchk.Location = new System.Drawing.Point(500, 74);
            this.csprngchk.Name = "csprngchk";
            this.csprngchk.Size = new System.Drawing.Size(68, 19);
            this.csprngchk.TabIndex = 4;
            this.csprngchk.Text = "CSPRNG";
            this.csprngchk.UseVisualStyleBackColor = true;
            this.csprngchk.CheckedChanged += new System.EventHandler(this.csprngchk_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(288, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "RNG type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(288, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Do not touch if you do not\r\n know what you are doing.";
            // 
            // prngchk
            // 
            this.prngchk.AutoSize = true;
            this.prngchk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prngchk.Location = new System.Drawing.Point(500, 99);
            this.prngchk.Name = "prngchk";
            this.prngchk.Size = new System.Drawing.Size(150, 19);
            this.prngchk.TabIndex = 7;
            this.prngchk.Text = "PRNG with custom seed";
            this.prngchk.UseVisualStyleBackColor = true;
            this.prngchk.CheckedChanged += new System.EventHandler(this.prngchk_CheckedChanged);
            // 
            // csharpmethodchk
            // 
            this.csharpmethodchk.AutoSize = true;
            this.csharpmethodchk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csharpmethodchk.Location = new System.Drawing.Point(500, 128);
            this.csharpmethodchk.Name = "csharpmethodchk";
            this.csharpmethodchk.Size = new System.Drawing.Size(122, 19);
            this.csharpmethodchk.TabIndex = 8;
            this.csharpmethodchk.Text = "Default c# method";
            this.csharpmethodchk.UseVisualStyleBackColor = true;
            this.csharpmethodchk.CheckedChanged += new System.EventHandler(this.csharpmethodchk_CheckedChanged);
            // 
            // genpassbtn
            // 
            this.genpassbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.genpassbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genpassbtn.Location = new System.Drawing.Point(288, 354);
            this.genpassbtn.Name = "genpassbtn";
            this.genpassbtn.Size = new System.Drawing.Size(139, 40);
            this.genpassbtn.TabIndex = 9;
            this.genpassbtn.Text = "Generate Password";
            this.genpassbtn.UseVisualStyleBackColor = false;
            this.genpassbtn.Click += new System.EventHandler(this.genpassbtn_Click);
            // 
            // seedtxt
            // 
            this.seedtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.seedtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seedtxt.Location = new System.Drawing.Point(12, 234);
            this.seedtxt.Name = "seedtxt";
            this.seedtxt.Size = new System.Drawing.Size(270, 23);
            this.seedtxt.TabIndex = 10;
            this.seedtxt.Text = "Seed";
            this.seedtxt.Visible = false;
            // 
            // mathformtxt
            // 
            this.mathformtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.mathformtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mathformtxt.Location = new System.Drawing.Point(12, 263);
            this.mathformtxt.Name = "mathformtxt";
            this.mathformtxt.Size = new System.Drawing.Size(270, 23);
            this.mathformtxt.TabIndex = 11;
            this.mathformtxt.Text = "Mathematical formula";
            this.mathformtxt.Visible = false;
            // 
            // errortxt
            // 
            this.errortxt.AutoSize = true;
            this.errortxt.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.errortxt.ForeColor = System.Drawing.Color.DarkRed;
            this.errortxt.Location = new System.Drawing.Point(433, 354);
            this.errortxt.Name = "errortxt";
            this.errortxt.Size = new System.Drawing.Size(105, 18);
            this.errortxt.TabIndex = 12;
            this.errortxt.Text = "Error Text???";
            this.errortxt.Visible = false;
            // 
            // allowedchars
            // 
            this.allowedchars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.allowedchars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.allowedchars.Location = new System.Drawing.Point(12, 140);
            this.allowedchars.Multiline = true;
            this.allowedchars.Name = "allowedchars";
            this.allowedchars.Size = new System.Drawing.Size(270, 88);
            this.allowedchars.TabIndex = 13;
            this.allowedchars.Text = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789@#$%&";
            // 
            // allowedcharslbl
            // 
            this.allowedcharslbl.AutoSize = true;
            this.allowedcharslbl.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.allowedcharslbl.Location = new System.Drawing.Point(288, 156);
            this.allowedcharslbl.Name = "allowedcharslbl";
            this.allowedcharslbl.Size = new System.Drawing.Size(324, 72);
            this.allowedcharslbl.TabIndex = 14;
            this.allowedcharslbl.Text = "Allowed Characters are characters that are\r\n going to be used while generating yo" +
    "ur\r\n password, leave default if you want a\r\n normal password.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Allowed Characters:";
            // 
            // defaultchk
            // 
            this.defaultchk.AutoSize = true;
            this.defaultchk.Checked = true;
            this.defaultchk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.defaultchk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultchk.Location = new System.Drawing.Point(182, 99);
            this.defaultchk.Name = "defaultchk";
            this.defaultchk.Size = new System.Drawing.Size(61, 19);
            this.defaultchk.TabIndex = 16;
            this.defaultchk.Text = "Default";
            this.defaultchk.UseVisualStyleBackColor = true;
            this.defaultchk.CheckedChanged += new System.EventHandler(this.defaultchk_CheckedChanged);
            // 
            // customchk
            // 
            this.customchk.AutoSize = true;
            this.customchk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customchk.Location = new System.Drawing.Point(182, 115);
            this.customchk.Name = "customchk";
            this.customchk.Size = new System.Drawing.Size(65, 19);
            this.customchk.TabIndex = 17;
            this.customchk.Text = "Custom";
            this.customchk.UseVisualStyleBackColor = true;
            this.customchk.CheckedChanged += new System.EventHandler(this.customchk_CheckedChanged);
            // 
            // copybtn
            // 
            this.copybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.copybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copybtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copybtn.Location = new System.Drawing.Point(445, 400);
            this.copybtn.Name = "copybtn";
            this.copybtn.Size = new System.Drawing.Size(57, 23);
            this.copybtn.TabIndex = 18;
            this.copybtn.Text = "Copy";
            this.copybtn.UseVisualStyleBackColor = false;
            this.copybtn.Click += new System.EventHandler(this.copybtn_Click);
            // 
            // cpdtxt
            // 
            this.cpdtxt.AutoSize = true;
            this.cpdtxt.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cpdtxt.Location = new System.Drawing.Point(550, 400);
            this.cpdtxt.Name = "cpdtxt";
            this.cpdtxt.Size = new System.Drawing.Size(153, 18);
            this.cpdtxt.TabIndex = 19;
            this.cpdtxt.Text = "Copied to clipboard.";
            this.cpdtxt.Visible = false;
            // 
            // passgen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cpdtxt);
            this.Controls.Add(this.copybtn);
            this.Controls.Add(this.customchk);
            this.Controls.Add(this.defaultchk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.allowedcharslbl);
            this.Controls.Add(this.allowedchars);
            this.Controls.Add(this.errortxt);
            this.Controls.Add(this.mathformtxt);
            this.Controls.Add(this.seedtxt);
            this.Controls.Add(this.genpassbtn);
            this.Controls.Add(this.csharpmethodchk);
            this.Controls.Add(this.prngchk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.csprngchk);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passlength);
            this.Controls.Add(this.paramlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "passgen";
            this.Text = "passgen";
            this.Load += new System.EventHandler(this.passgen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label paramlbl;
        private TextBox passlength;
        private Label label1;
        private TextBox passtxt;
        private CheckBox csprngchk;
        private Label label2;
        private Label label3;
        private CheckBox prngchk;
        private CheckBox csharpmethodchk;
        private Button genpassbtn;
        private TextBox seedtxt;
        private TextBox mathformtxt;
        private Label errortxt;
        private TextBox allowedchars;
        private Label allowedcharslbl;
        private Label label4;
        private CheckBox defaultchk;
        private CheckBox customchk;
        private Button copybtn;
        private Label cpdtxt;
    }
}