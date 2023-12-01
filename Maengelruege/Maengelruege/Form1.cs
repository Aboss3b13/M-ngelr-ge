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
                "t du es gekauft?","Wie möchten Sie aufgrund der reklamierten Mängel gemäß dem Bürgerlichen Gesetzbuch vorgehen? ",  "Was ist deine Name?" };
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
                count = 3;
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
            if (count == 2)
            {
                Antwort.Visible = false;
                option1.Visible = true; option1.Text = "Ich bitte um einen Gutschein, welcher mir den Verkaufspreis meines Produktes entschädigt.";
                option2.Visible = true; option2.Text = "Ich wäre bereit, ein einwandfreies Ersatzprodukt zu erhalten.";
                option3.Visible = true; option3.Text = "Ich erwäge die Rückerstattung des Kaufpreises.";


            }

            if (count != 2)
            {
                Antwort.Visible = true;
                option1.Visible = false;
                option2.Visible = false;
                option3.Visible = false;
                if (count != 1)
                {
                    Antwort.Visible = true;
                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                }
                else
                {
                    Antwort.Visible = false;
                    option1.Visible = true; option1.Text = "vor einem Monat";
                    option2.Visible = true; option2.Text = "vor eine Woche";
                    option3.Visible = true; option3.Text = "gestern";
                }
            }



        }  // back button

        private void nächste_Click(object sender, EventArgs e)
        {

            count++;
            if (count == 4)
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
            if (count == 2)
            {
                Antwort.Visible = false;
                option1.Visible = true; option1.Text = "Ich bitte um einen Gutschein, welcher mir den Verkaufspreis meines Produktes entschädigt.";
                option2.Visible = true; option2.Text = "Ich wäre bereit, ein einwandfreies Ersatzprodukt zu erhalten.";
                option3.Visible = true; option3.Text = "Ich erwäge die Rückerstattung des Kaufpreises.";


            }
            if (count != 1)
            {
                Antwort.Visible = true;
                option1.Visible = false;
                option2.Visible = false;
                option3.Visible = false;
                if (count != 2)
                {
                    Antwort.Visible = true;
                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                }
                else
                {
                    Antwort.Visible = false;
                    option1.Visible = true; option1.Text = "Ich bitte um einen Gutschein, welcher mir den Verkaufspreis meines Produktes entschädigt.";
                    option2.Visible = true; option2.Text = "Ich wäre bereit, ein einwandfreies Ersatzprodukt zu erhalten.";
                    option3.Visible = true; option3.Text = "Ich erwäge die Rückerstattung des Kaufpreises.";
                }
            }



        } // next button
        private void tac_Click(object sender, EventArgs e)
        {
            TAC = true;
            MessageBox.Show("---\r\n\r\n*Allgemeine Geschäftsbedingungen (AGB)*\r\n\r\n*1. Anwendungsbereich*\r\nDiese Allgemeinen Geschäftsbedingungen gelten für sämtliche Verträge, Angebote und Lieferungen zwischen Ihre Firma und ihren Kunden, sofern nicht schriftlich Abweichendes vereinbart wurde.\r\n\r\n*2. Vertragsabschluss*\r\nVerträge kommen durch schriftliche oder mündliche Vereinbarungen, Angebote und Bestellungen zustande. Alle Angebote sind freibleibend und unverbindlich.\r\n\r\n*3. Gewährleistung und Mängelrügen*\r\n3.1. Die Gewährleistungsfrist beträgt 14 Tage ab Erhalt der Ware oder Leistung und richtet sich nach den gesetzlichen Bestimmungen des Schweizerischen Obligationenrechts (OR).\r\n\r\n3.2. Der Kunde hat offensichtliche Mängel unverzüglich, spätestens jedoch innerhalb von 7 Tagen nach Erhalt der Ware oder Leistung, schriftlich zu rügen. Andernfalls gilt die Ware als genehmigt.\r\n\r\n3.3. Versteckte Mängel sind unverzüglich nach Entdeckung, spätestens jedoch innerhalb einer Frist von 7 Tagen nach Entdeckung, schriftlich zu rügen.\r\n\r\n3.4. Mängelrügen müssen eine detaillierte Beschreibung des Mangels sowie Angaben über den Zeitpunkt der Feststellung enthalten.\r\n\r\n*4. Haftungsausschluss*\r\nFür Schäden, die nicht auf grober Fahrlässigkeit oder Vorsatz beruhen, wird jegliche Haftung ausgeschlossen.\r\n\r\n*5. Schlussbestimmungen*\r\nEs gilt das Schweizer Recht. Gerichtsstand für alle Streitigkeiten. Sollten einzelne Bestimmungen dieser AGB unwirksam sein oder werden, bleibt die Wirksamkeit der übrigen Bestimmungen unberührt.\r\n\r\n---");
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
                    doc.Add(new Paragraph(""));
                    doc.Add(new Paragraph(""));
                    doc.Add(new Chunk("Da es sich bei meinem Kauf um eine Reklame handelte und ich aufgrund der gesetzlichen Gewährleistungsfrist berechtigt bin, Mängel zu rügen, möchte ich gemäß § [entsprechende Paragrafen im Bürgerlichen Gesetzbuch (BGB)] meine Rechte geltend machen."));
                    doc.Add(new Paragraph(Antworten[2]));
                    doc.Add(new Paragraph(""));
                    doc.Add(new Paragraph(""));

                    doc.Add(new Chunk("Vielen Dank für Ihr Verständnis und Ihre rasche Bearbeitung."));
                    doc.Add(new Paragraph(""));
                    doc.Add(new Chunk("Mit freundlichen Grüßen,"));
                    doc.Add(new Paragraph(""));
                    doc.Add(new Paragraph(Antworten[3]));

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
                mailMessage.Body = "Liebes Team der Firma,\r\n\r\nich hoffe, es geht euch gut.\r\n\r\nIm Anhang findet ihr eine Liste mit Dingen, die ich bemerkt habe und die verbessert werden könnten. Ich schicke das, damit wir gemeinsam Lösungen finden können.\r\n\r\nDanke, dass ihr euch das anschaut. Ich freue mich darauf, von euch zu hören.\r\n\r\nMit freundlichen Grüßen,\r\n\r\n" + Antworten[3]; ;

                // Create an Attachment object and add it to the Attachments collection of the MailMessage object.
                Attachment attachment = new Attachment(Path.Combine(downloadsPath, "output.pdf"));
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
