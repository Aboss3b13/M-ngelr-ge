using System;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace Mängelrüge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Fragen[0] = "Was willst du";
            Frage.Text = Fragen[0];
        }
        string[] Fragen = { "Was willst du?", "Nando ist gay, oder?", "Do you pledge your alligiance to the flag of the grat nation of america like a slave?" };  // Speichert die Fragen
        string[] Antworten = new string[5]; // Speichert die Antworten
        int count = 0; // Eine Hilfsvariabe zu sehen am welche man ist.



        private void Frage_TextChanged(object sender, EventArgs e)  // Code für Textbox Fragen
        {


        }

        private void Nächste_Click(object sender, EventArgs e)
        {
            count++;
            if (2 < count)
            {
                count = 0;
            }
            Frage.Text = Fragen[count];
            Antwort.Text = Antworten[count];

        }

        private void Zurück_Click(object sender, EventArgs e)
        {
            count--;
            if (count < 0)
            {
                count = 2;
            }
            Frage.Text = Fragen[count];
            Antwort.Text = Antworten[count];


        }

        private void Antwort_TextChanged(object sender, EventArgs e)
        {
            Antworten[count] = Antwort.Text;
        }

        private void Abschicken_Click(object sender, EventArgs e)
        {


            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";

            string filePath = Path.Combine(downloadsPath, "output.pdf");

            Document doc = new Document();

            try
            {
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

                doc.Open();

                for (int i = 0; i < Math.Max(Fragen.Length, Antworten.Length); i++)
                {
                    if (i < Fragen.Length)
                    {
                        doc.Add(new Paragraph(Fragen[i]));
                    }
                    if (i < Antworten.Length)
                    {
                        doc.Add(new Paragraph(Antworten[i]));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                doc.Close();
            }

            MessageBox.Show("Der PDF wurde runtergeladen");
            
        }
    }
}
