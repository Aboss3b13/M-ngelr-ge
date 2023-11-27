using System.Reflection.Metadata;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Net.Mail;
using System.Net;
using Document = iTextSharp.text.Document;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Transactions;

namespace Maengelruege
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            accept = false;
            Frage.Text = Fragen[count];
            Antwort.Text = Antworten[count];
            option1.Visible = false;
            option2.Visible = false;
            option3.Visible = false;
            Antwort.Visible = false;
            Frage.Visible = false;
            nächste.Visible = false;
            Zurück.Visible = false;
            Abschicken.Visible = false;
            Username.Visible = true;
            enterun.Visible = true;
            Password.Visible = true;
            enterp.Visible = true;
            shippingnumber.Visible = true;
            entersh.Visible = true;
            email.Visible = true;
            emailtxt.Visible = true;


        }
        MailMessage mailMessage = new MailMessage();

        string username = "man";
        string password = "password";
        string sn;
        string[] account = new string[4];  // Increase array size to 3
        bool verification = false;
        private void email_Click(object sender, EventArgs e)
        {
            account[0] = emailtxt.Text;
            try
            {
                mailMessage.To.Add(new MailAddress(account[0]));

            }
            catch 
            {
                MessageBox.Show("Der Mail Address ist Falsch geschrieben oder existiert nicht");
            }
        }
        private void enterun_Click(object sender, EventArgs e)
        {
            account[1] = Username.Text;
        }

        private void enterp_Click(object sender, EventArgs e)
        {
            account[2] = Password.Text;
        }

        private void entersh_Click(object sender, EventArgs e)
        {
            account[3] = shippingnumber.Text;

            // Validate if username, password, and shipping number are not empty
            if (!string.IsNullOrEmpty(account[0]) && !string.IsNullOrEmpty(account[1]) && !string.IsNullOrEmpty(account[2]) && !string.IsNullOrEmpty(account[3]))
            {
                if (string.Equals(account[1], username) && string.Equals(account[2], password))
                {
                    MessageBox.Show("Account details are correct");
                    verification = true;

                    // Show the UI elements
                    ShowUIElements();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect");
                }
            }
            else
            {
                MessageBox.Show("Please enter all details");
            }
        }

        private void ShowUIElements()
        {
            // Show the UI elements
            option1.Visible = false;
            option2.Visible = false;
            option3.Visible = false;
            Antwort.Visible = true;
            Frage.Visible = true;
            nächste.Visible = true;
            Zurück.Visible = true;
            Abschicken.Visible = true;

            // Hide the input elements
            Username.Visible = false;
            enterun.Visible = false;
            Password.Visible = false;
            enterp.Visible = false;
            shippingnumber.Visible = false;
            entersh.Visible = false;
            email.Visible = false;
            emailtxt.Visible = false;
        }

        string[] Fragen = { "Was ist der Problem mit der Produkt? Beschreibe kurz", "Wann has" +
                "t du es gekauft?", "Was ist deine Name?" };
        string[] Antworten = new string[10];
        int count = 0;
        bool accept = false;
        bool TAC = false;
        private int originalWidth;
        private int originalHeight;

        private void txt1_TextChanged(object sender, EventArgs e)  // question field
        {
            Frage.Text = Fragen[count];

        }

        private void Antwort_TextChanged(object sender, EventArgs e)
        {
            Antworten[count] = Antwort.Text;
        }  //typing field

        private void Zurück_Click(object sender, EventArgs e)
        {
            count--;
            if (count == -1)
            {
                count = 2;
            }
            Frage.Text = Fragen[count];
            Antwort.Text = Antworten[count];
            Antworten[count] = Antwort.Text;
            if (count == 1)
            {
                Antwort.Visible = false;
                option1.Visible = true; option1.Text = "vor einem Monat";
                option2.Visible = true; option2.Text = "vor eine Woche";
                option3.Visible = true; option3.Text = "gestern";


            }
            if (count != 1)
            {
                Antwort.Visible = true;
                option1.Visible = false;
                option2.Visible = false;
                option3.Visible = false;
            }



        }  // back button

        private void nächste_Click(object sender, EventArgs e)
        {

            count++;
            if (count == 3)
            {
                count = 0;
            }
            Frage.Text = Fragen[count];
            Antwort.Text = Antworten[count];
            Antworten[count] = Antwort.Text;
            if (count == 1)
            {
                Antwort.Visible = false;
                option1.Visible = true; option1.Text = "vor einem Monat";
                option2.Visible = true; option2.Text = "vor eine Woche";
                option3.Visible = true; option3.Text = "gestern";



            }
            if (count != 1)
            {
                Antwort.Visible = true;
                option1.Visible = false;
                option2.Visible = false;
                option3.Visible = false;
            }


        } // next button
        private void tac_Click(object sender, EventArgs e)
        {
            TAC = true;
            MessageBox.Show("Rückgaberecht\r\n\r\nSie haben das Recht, die von Ihnen bestellte Ware innerhalb von 14 Tagen nach Erhalt ohne Angabe von Gründen zurückzugeben. Die Frist beginnt am Tag des Erhalts der Ware. Um von Ihrem Rückgaberecht Gebrauch zu machen, müssen Sie uns innerhalb der Frist schriftlich oder per E-Mail informieren. Die Rücksendung der Ware erfolgt auf Ihre Kosten.\r\n\r\nDie Ware muss in unbenutztem und originalverpacktem Zustand zurückgesandt werden. Andernfalls können wir die Rückgabe verweigern oder den Wertverlust der Ware in Rechnung stellen.\r\n\r\nSobald wir die zurückgesandte Ware erhalten haben, werden wir Ihnen den Kaufpreis innerhalb von 14 Tagen erstatten.\r\n\r\nAusnahmen vom Rückgaberecht\r\n\r\nDas Rückgaberecht gilt nicht für folgende Waren:\r\n\r\nIndividuelle Anfertigungen\r\nWaren, die nach Kundenspezifikation hergestellt wurden\r\nWaren, die schnell verderben können oder deren Verfallsdatum überschritten ist\r\nWaren, die versiegelt geliefert wurden und aus Gründen des Gesundheitsschutzes oder der Hygiene nicht zur Rückgabe geeignet sind, wenn ihre Versiegelung nach der Lieferung entfernt wurde\r\nTon- oder Videoaufnahmen oder Computersoftware, die in einer versiegelten Packung geliefert wurde, wenn die Versiegelung nach der Lieferung entfernt wurde\r\nZeitschriften, Zeitungen oder Illustrierte\r\nRücksendeverfahren\r\n\r\nUm ein Produkt zurückzusenden, folgen Sie bitte diesen Schritten:\r\n\r\nInformieren Sie uns innerhalb von 14 Tagen nach Erhalt der Ware schriftlich oder per E-Mail über Ihre Rückgabe.\r\nVerpacken Sie die Ware sicher in der Originalverpackung.\r\nSenden Sie die Ware an folgende Adresse:\r\n[Ihr Firmenname]\r\n[Ihre Adresse]\r\n\r\nLegen Sie dem Paket eine Kopie Ihrer Rechnung bei.\r\n\r\nSobald wir die zurückgesandte Ware erhalten haben, werden wir Ihnen den Kaufpreis innerhalb von 14 Tagen erstatten.\r\n\r\nBitte beachten Sie: Die Kosten für die Rücksendung der Ware tragen Sie.");
        }  // terms and conditions

        private void Abschicken_Click_1(object sender, EventArgs e)
        {

            if (accept == true)
            {
                string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";

                string filePath = Path.Combine(downloadsPath, "output.pdf");

                Document doc = new Document();

                try
                {
                    string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

                    doc.Open();
                    doc.Add(new Paragraph());
                    doc.Add(new Chunk("Am "));
                    doc.Add(new Chunk(date));
                    doc.Add(new Chunk(" habe ich bei Ihnen das Produkt mit der Bestellnummer  "));
                    doc.Add(new Chunk(account[3]));
                    doc.Add(new Chunk("erworben. Zunächst möchte ich meine Zufriedenheit mit Ihrem Unternehmen und dem reibungslosen Bestellprozess zum Ausdruck bringen."));
                    doc.Add(new Paragraph(""));
                    doc.Add(new Paragraph(""));
                    doc.Add(new Chunk("Leider muss ich jedoch mit Bedauern feststellen, dass das gelieferte Produkt nicht den Erwartungen entspricht und Mängel aufweist. Nach sorgfältiger Prüfung habe ich Folgendes festgestellt:"));
                    doc.Add(new Paragraph(Antworten[0]));
                    doc.Add(new Chunk("Ich vertraue darauf, dass Sie diesem Anliegen die gebührende Aufmerksamkeit schenken und wir gemeinsam eine zufriedenstellende Lösung finden können."));
                    doc.Add(new Paragraph());
                    doc.Add(new Chunk("Vielen Dank für Ihr Verständnis und Ihre rasche Bearbeitung."));
                    doc.Add(new Paragraph(""));
                    doc.Add(new Chunk("Mit freundlichen Grüßen,"));
                    doc.Add(new Paragraph(""));
                    doc.Add(new Paragraph(Antworten[2]));

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    doc.Close();
                }


                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential("maengelruege@gmail.com", "dgbk sjpr ssol oeyg\r\n");




                // Create a MailMessage object.

                // Set the From, To, Subject, and Body properties of the MailMessage object.
                mailMessage.From = new MailAddress("maengelruege@gmail.com");
                mailMessage.To.Add(new MailAddress(account[0]));
                mailMessage.Subject = "Mängelrüge";
                mailMessage.Body = "Hier ist meine Reklamation. I want a manager";

                // Create an Attachment object and add it to the Attachments collection of the MailMessage object.
                Attachment attachment = new Attachment(@"C:\Users\abbas\Downloads\output.pdf");
                mailMessage.Attachments.Add(attachment);

                // Send the email.
                smtpClient.Send(mailMessage);

                // Display a message to the user.
                MessageBox.Show("Email sent successfully!");
            }
            else
            {
                MessageBox.Show("Accept terms and conditions");
            }


        }  // send file

        private void accepttac_Click(object sender, EventArgs e)
        {
            if (TAC == true)
            {
                accept = true;

            }
            else
            {
                MessageBox.Show("You have to read the terms and conditions");
                accept = false;
            }

        }   // accept terms and conditions

        private void option1_Click(object sender, EventArgs e)
        {
            Antworten[count] = option1.Text;
        }

        private void option2_Click(object sender, EventArgs e)
        {
            Antworten[count] = option2.Text;

        }

        private void option3_Click(object sender, EventArgs e)
        {
            Antworten[count] = option3.Text;

        }

       
    }
}
