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
            n�chste.Visible = false;
            Zur�ck.Visible = false;
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
            n�chste.Visible = true;
            Zur�ck.Visible = true;
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
                "t du es gekauft?","Wie m�chten Sie aufgrund der reklamierten M�ngel gem�� dem B�rgerlichen Gesetzbuch vorgehen? ",  "Was ist deine Name?" };
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

        private void Zur�ck_Click(object sender, EventArgs e)
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
                option1.Visible = true; option1.Text = "Ich bitte um einen Gutschein, welcher mir den Verkaufspreis meines Produktes entsch�digt.";
                option2.Visible = true; option2.Text = "Ich w�re bereit, ein einwandfreies Ersatzprodukt zu erhalten.";
                option3.Visible = true; option3.Text = "Ich erw�ge die R�ckerstattung des Kaufpreises.";


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

        private void n�chste_Click(object sender, EventArgs e)
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
                option1.Visible = true; option1.Text = "Ich bitte um einen Gutschein, welcher mir den Verkaufspreis meines Produktes entsch�digt.";
                option2.Visible = true; option2.Text = "Ich w�re bereit, ein einwandfreies Ersatzprodukt zu erhalten.";
                option3.Visible = true; option3.Text = "Ich erw�ge die R�ckerstattung des Kaufpreises.";


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
                    option1.Visible = true; option1.Text = "Ich bitte um einen Gutschein, welcher mir den Verkaufspreis meines Produktes entsch�digt.";
                    option2.Visible = true; option2.Text = "Ich w�re bereit, ein einwandfreies Ersatzprodukt zu erhalten.";
                    option3.Visible = true; option3.Text = "Ich erw�ge die R�ckerstattung des Kaufpreises.";
                }
            }



        } // next button
        private void tac_Click(object sender, EventArgs e)
        {
            TAC = true;
            MessageBox.Show("---\r\n\r\n*Allgemeine Gesch�ftsbedingungen (AGB)*\r\n\r\n*1. Anwendungsbereich*\r\nDiese Allgemeinen Gesch�ftsbedingungen gelten f�r s�mtliche Vertr�ge, Angebote und Lieferungen zwischen Ihre Firma und ihren Kunden, sofern nicht schriftlich Abweichendes vereinbart wurde.\r\n\r\n*2. Vertragsabschluss*\r\nVertr�ge kommen durch schriftliche oder m�ndliche Vereinbarungen, Angebote und Bestellungen zustande. Alle Angebote sind freibleibend und unverbindlich.\r\n\r\n*3. Gew�hrleistung und M�ngelr�gen*\r\n3.1. Die Gew�hrleistungsfrist betr�gt 14 Tage ab Erhalt der Ware oder Leistung und richtet sich nach den gesetzlichen Bestimmungen des Schweizerischen Obligationenrechts (OR).\r\n\r\n3.2. Der Kunde hat offensichtliche M�ngel unverz�glich, sp�testens jedoch innerhalb von 7 Tagen nach Erhalt der Ware oder Leistung, schriftlich zu r�gen. Andernfalls gilt die Ware als genehmigt.\r\n\r\n3.3. Versteckte M�ngel sind unverz�glich nach Entdeckung, sp�testens jedoch innerhalb einer Frist von 7 Tagen nach Entdeckung, schriftlich zu r�gen.\r\n\r\n3.4. M�ngelr�gen m�ssen eine detaillierte Beschreibung des Mangels sowie Angaben �ber den Zeitpunkt der Feststellung enthalten.\r\n\r\n*4. Haftungsausschluss*\r\nF�r Sch�den, die nicht auf grober Fahrl�ssigkeit oder Vorsatz beruhen, wird jegliche Haftung ausgeschlossen.\r\n\r\n*5. Schlussbestimmungen*\r\nEs gilt das Schweizer Recht. Gerichtsstand f�r alle Streitigkeiten. Sollten einzelne Bestimmungen dieser AGB unwirksam sein oder werden, bleibt die Wirksamkeit der �brigen Bestimmungen unber�hrt.\r\n\r\n---");
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
                    doc.Add(new Chunk("erworben. Zun�chst m�chte ich meine Zufriedenheit mit Ihrem Unternehmen und dem reibungslosen Bestellprozess zum Ausdruck bringen."));
                    doc.Add(new Paragraph(""));
                    doc.Add(new Paragraph(""));
                    doc.Add(new Chunk("Leider muss ich jedoch mit Bedauern feststellen, dass das gelieferte Produkt nicht den Erwartungen entspricht und M�ngel aufweist. Nach sorgf�ltiger Pr�fung habe ich Folgendes festgestellt:"));
                    doc.Add(new Paragraph(Antworten[0]));
                    doc.Add(new Chunk("Ich vertraue darauf, dass Sie diesem Anliegen die geb�hrende Aufmerksamkeit schenken und wir gemeinsam eine zufriedenstellende L�sung finden k�nnen."));
                    doc.Add(new Paragraph(""));
                    doc.Add(new Paragraph(""));
                    doc.Add(new Chunk("Da es sich bei meinem Kauf um eine Reklame handelte und ich aufgrund der gesetzlichen Gew�hrleistungsfrist berechtigt bin, M�ngel zu r�gen, m�chte ich gem�� � [entsprechende Paragrafen im B�rgerlichen Gesetzbuch (BGB)] meine Rechte geltend machen."));
                    doc.Add(new Paragraph(Antworten[2]));
                    doc.Add(new Paragraph(""));
                    doc.Add(new Paragraph(""));

                    doc.Add(new Chunk("Vielen Dank f�r Ihr Verst�ndnis und Ihre rasche Bearbeitung."));
                    doc.Add(new Paragraph(""));
                    doc.Add(new Chunk("Mit freundlichen Gr��en,"));
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
                mailMessage.Subject = "M�ngelr�ge";
                mailMessage.Body = "Liebes Team der Firma,\r\n\r\nich hoffe, es geht euch gut.\r\n\r\nIm Anhang findet ihr eine Liste mit Dingen, die ich bemerkt habe und die verbessert werden k�nnten. Ich schicke das, damit wir gemeinsam L�sungen finden k�nnen.\r\n\r\nDanke, dass ihr euch das anschaut. Ich freue mich darauf, von euch zu h�ren.\r\n\r\nMit freundlichen Gr��en,\r\n\r\n" + Antworten[3]; ;

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
