namespace Mängelrüge
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
            Frage = new TextBox();
            Antwort = new TextBox();
            Zurück = new Button();
            Nächste = new Button();
            Abschicken = new Button();
            SuspendLayout();
            // 
            // Frage
            // 
            Frage.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Frage.Location = new Point(122, 51);
            Frage.Multiline = true;
            Frage.Name = "Frage";
            Frage.Size = new Size(547, 82);
            Frage.TabIndex = 0;
            Frage.TextChanged += Frage_TextChanged;
            // 
            // Antwort
            // 
            Antwort.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Antwort.Location = new Point(122, 148);
            Antwort.Multiline = true;
            Antwort.Name = "Antwort";
            Antwort.Size = new Size(547, 82);
            Antwort.TabIndex = 1;
            Antwort.TextChanged += Antwort_TextChanged;
            // 
            // Zurück
            // 
            Zurück.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Zurück.Location = new Point(122, 280);
            Zurück.Name = "Zurück";
            Zurück.Size = new Size(142, 51);
            Zurück.TabIndex = 2;
            Zurück.Text = "Zurück";
            Zurück.UseVisualStyleBackColor = true;
            Zurück.Click += Zurück_Click;
            // 
            // Nächste
            // 
            Nächste.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Nächste.Location = new Point(285, 280);
            Nächste.Name = "Nächste";
            Nächste.Size = new Size(152, 51);
            Nächste.TabIndex = 3;
            Nächste.Text = "Nächste";
            Nächste.UseVisualStyleBackColor = true;
            Nächste.Click += Nächste_Click;
            // 
            // Abschicken
            // 
            Abschicken.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Abschicken.Location = new Point(457, 280);
            Abschicken.Name = "Abschicken";
            Abschicken.Size = new Size(212, 51);
            Abschicken.TabIndex = 4;
            Abschicken.Text = "Abschicken";
            Abschicken.UseVisualStyleBackColor = true;
            Abschicken.Click += Abschicken_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Abschicken);
            Controls.Add(Nächste);
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
        private Button Nächste;
        private Button Abschicken;
    }
}