using System;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

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
            // Array of strings to be added to the PDF
            

            // Get the user's Downloads folder path
            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";

            // Set the file path for the PDF in the Downloads folder
            string filePath = Path.Combine(downloadsPath, "output.pdf");

            // Create a new document
            Document doc = new Document();

            try
            {
                // Create a PdfWriter to write the document to the chosen file
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

                // Open the document for writing
                doc.Open();

                // Interleave the content of Array1 and Array2
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
                // Close the document
                doc.Close();
            }

            MessageBox.Show("PDF created successfully and saved to the Downloads folder!");
        }
    }
}
