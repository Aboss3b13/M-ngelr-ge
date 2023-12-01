namespace Maengelruege
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            Frage = new TextBox();
            Antwort = new TextBox();
            Zurück = new Button();
            nächste = new Button();
            Abschicken = new Button();
            tac = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            accepttac = new Button();
            option1 = new Button();
            option2 = new Button();
            option3 = new Button();
            Username = new TextBox();
            enterun = new Button();
            Password = new TextBox();
            enterp = new Button();
            shippingnumber = new TextBox();
            entersh = new Button();
            emailtxt = new TextBox();
            email = new Button();
            SuspendLayout();
            // 
            // Frage
            // 
            Frage.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Frage.Location = new Point(158, 50);
            Frage.Multiline = true;
            Frage.Name = "Frage";
            Frage.Size = new Size(584, 127);
            Frage.TabIndex = 0;
            Frage.TextChanged += txt1_TextChanged;
            // 
            // Antwort
            // 
            Antwort.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Antwort.Location = new Point(158, 183);
            Antwort.Multiline = true;
            Antwort.Name = "Antwort";
            Antwort.Size = new Size(584, 127);
            Antwort.TabIndex = 1;
            Antwort.TextChanged += Antwort_TextChanged;
            // 
            // Zurück
            // 
            Zurück.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            Zurück.Location = new Point(138, 334);
            Zurück.Name = "Zurück";
            Zurück.Size = new Size(179, 64);
            Zurück.TabIndex = 2;
            Zurück.Text = "Zurück";
            Zurück.UseVisualStyleBackColor = true;
            Zurück.Click += Zurück_Click;
            // 
            // nächste
            // 
            nächste.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            nächste.Location = new Point(347, 334);
            nächste.Name = "nächste";
            nächste.Size = new Size(179, 64);
            nächste.TabIndex = 3;
            nächste.Text = "nächste";
            nächste.UseVisualStyleBackColor = true;
            nächste.Click += nächste_Click;
            // 
            // Abschicken
            // 
            Abschicken.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            Abschicken.Location = new Point(563, 334);
            Abschicken.Name = "Abschicken";
            Abschicken.Size = new Size(179, 64);
            Abschicken.TabIndex = 4;
            Abschicken.Text = "Abschicken";
            Abschicken.UseVisualStyleBackColor = true;
            Abschicken.Click += Abschicken_Click_1;
            // 
            // tac
            // 
            tac.Location = new Point(6, 50);
            tac.Name = "tac";
            tac.Size = new Size(146, 81);
            tac.TabIndex = 5;
            tac.Text = "terms and conditions";
            tac.UseVisualStyleBackColor = true;
            tac.Click += tac_Click;
            // 
            // accepttac
            // 
            accepttac.Location = new Point(6, 137);
            accepttac.Name = "accepttac";
            accepttac.Size = new Size(146, 81);
            accepttac.TabIndex = 6;
            accepttac.Text = "accept terms and conditions";
            accepttac.UseVisualStyleBackColor = true;
            accepttac.Click += accepttac_Click;
            // 
            // option1
            // 
            option1.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            option1.Location = new Point(158, 202);
            option1.Name = "option1";
            option1.Size = new Size(146, 81);
            option1.TabIndex = 7;
            option1.UseVisualStyleBackColor = true;
            option1.Click += option1_Click;
            // 
            // option2
            // 
            option2.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            option2.Location = new Point(380, 202);
            option2.Name = "option2";
            option2.Size = new Size(146, 81);
            option2.TabIndex = 8;
            option2.UseVisualStyleBackColor = true;
            option2.Click += option2_Click;
            // 
            // option3
            // 
            option3.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            option3.Location = new Point(596, 202);
            option3.Name = "option3";
            option3.Size = new Size(146, 81);
            option3.TabIndex = 9;
            option3.UseVisualStyleBackColor = true;
            option3.Click += option3_Click;
            // 
            // Username
            // 
            Username.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Username.Location = new Point(151, 154);
            Username.Multiline = true;
            Username.Name = "Username";
            Username.Size = new Size(375, 112);
            Username.TabIndex = 10;
            Username.TextChanged += Username_TextChanged;
            // 
            // enterun
            // 
            enterun.Location = new Point(596, 146);
            enterun.Name = "enterun";
            enterun.Size = new Size(146, 82);
            enterun.TabIndex = 11;
            enterun.Text = "enter username";
            enterun.UseVisualStyleBackColor = true;
            enterun.Click += enterun_Click;
            // 
            // Password
            // 
            Password.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Password.Location = new Point(151, 272);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.Size = new Size(375, 104);
            Password.TabIndex = 12;
            Password.TextChanged += Password_TextChanged;
            // 
            // enterp
            // 
            enterp.Location = new Point(596, 246);
            enterp.Name = "enterp";
            enterp.Size = new Size(146, 82);
            enterp.TabIndex = 13;
            enterp.Text = "enter password";
            enterp.UseVisualStyleBackColor = true;
            enterp.Click += enterp_Click;
            // 
            // shippingnumber
            // 
            shippingnumber.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            shippingnumber.Location = new Point(151, 389);
            shippingnumber.Multiline = true;
            shippingnumber.Name = "shippingnumber";
            shippingnumber.Size = new Size(375, 109);
            shippingnumber.TabIndex = 14;
            // 
            // entersh
            // 
            entersh.Location = new Point(596, 334);
            entersh.Name = "entersh";
            entersh.Size = new Size(146, 109);
            entersh.TabIndex = 15;
            entersh.Text = "enter shippingnumber";
            entersh.UseVisualStyleBackColor = true;
            entersh.Click += entersh_Click;
            // 
            // emailtxt
            // 
            emailtxt.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            emailtxt.Location = new Point(151, 12);
            emailtxt.Multiline = true;
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(375, 128);
            emailtxt.TabIndex = 16;
            // 
            // email
            // 
            email.Location = new Point(596, 41);
            email.Name = "email";
            email.Size = new Size(146, 82);
            email.TabIndex = 17;
            email.Text = "enter email";
            email.UseVisualStyleBackColor = true;
            email.Click += email_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(email);
            Controls.Add(emailtxt);
            Controls.Add(entersh);
            Controls.Add(shippingnumber);
            Controls.Add(enterp);
            Controls.Add(Password);
            Controls.Add(enterun);
            Controls.Add(Username);
            Controls.Add(option3);
            Controls.Add(option2);
            Controls.Add(option1);
            Controls.Add(accepttac);
            Controls.Add(tac);
            Controls.Add(Abschicken);
            Controls.Add(nächste);
            Controls.Add(Zurück);
            Controls.Add(Antwort);
            Controls.Add(Frage);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox Frage;
        private TextBox Antwort;
        private Button Zurück;
        private Button nächste;
        private Button Abschicken;
        private Button tac;
        private System.Windows.Forms.Timer timer1;
        private Button accepttac;
        private Button option1;
        private Button option2;
        private Button option3;
        private TextBox Username;
        private Button enterun;
        private TextBox Password;
        private Button enterp;
        private TextBox shippingnumber;
        private Button entersh;
        private TextBox emailtxt;
        private Button email;
    }
}

