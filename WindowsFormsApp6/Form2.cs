using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.WorkerReportsProgress = true;

            try
            {
                string html = File.ReadAllText("websitegermany.html");
                webBrowser1.DocumentText = html;
                vat.Text = "20%";
                currency.Text = "£";
                quan.Text = "1";
                regb.Text = "DE";
            }
            catch { }

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(01);
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            pb1.Value = e.ProgressPercentage;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try {
                if (regb.Text == "DE")
                {
                    backgroundWorker1.RunWorkerAsync();
                    string dateday = date.Value.ToString("dd"); //get day
                    string datemonth = date.Value.ToString("MMMM"); //get month
                    string dateyear = date.Value.ToString("yyyy"); //get year

                    int dayvalue = Convert.ToInt32(dateday); //
                    int answerSubtract = dayvalue - 1; //////// +1 day for invoice date

                    //////////////////////////////////////////////////////////////////////////
                    ///maths for vat 
                    Decimal dprice = decimal.Parse(price.Text, CultureInfo.InvariantCulture); // converts price string to decimal
                    string vatreplace = vat.Text.Replace("%", ""); //removes % from string so can converto decimal
                    Decimal dvat = decimal.Parse(vatreplace);
                    Decimal dquan = decimal.Parse(quan.Text, CultureInfo.InvariantCulture);
                    Decimal hun = 100; // 100
                    Decimal hunvat = decimal.Add(hun, dvat); // 120
                    Decimal TP = decimal.Multiply(dprice, dquan); // total price price X quantity
                    Decimal UPNV0 = Decimal.Divide(dprice, hunvat); // price divided by 100 + vat (e.g $25/120)
                    Decimal UPNV = Decimal.Multiply(UPNV0, hun); // multiply UPNV0 with 100 to get vat
                    Decimal SUB = Decimal.Multiply(UPNV, dquan); // multiply vat with quantity to get total vat for quantity
                    Decimal VT0 = Decimal.Divide(SUB, 10);
                    Decimal VT = Decimal.Multiply(VT0, dquan);

                    ////////////////////////////////////////////////////////////////////////////////////
                    /// Set random numbers for invoice id etc...
                    Random rnd = new Random();
                    int invoiceid = rnd.Next(106000000, 106700108);
                    int invoiceid1 = rnd.Next(0700000, 0799120);
                    int pur1 = rnd.Next(10, 99);
                    int pur2 = rnd.Next(0, 9);
                    int pur3 = rnd.Next(0, 9);
                    string pur4 = (pur1 + "FEN" + pur2 + "O" + pur3 + "VHKD");

                    ////////////////////////////////////////////////////////////////////////////////////
                    ///Get's website file
                    string text = File.ReadAllText("websitegermany.html");

                    ////////////////////////////////////////////////////////////////////////////////////
                    ///Replace placeholders in html with data from form
                    text = text.Replace("--name--", nameb.Text);
                    text = text.Replace("--nameup--", nameb.Text.ToUpper());
                    text = text.Replace("--sname--", surnb.Text);
                    text = text.Replace("--CountryCode--", regb.Text);
                    text = text.Replace("--currency--", currency.Text);
                    text = text.Replace("--day1--", dateday);
                    text = text.Replace("--day--", answerSubtract.ToString());
                    text = text.Replace("--month--", datemonth);
                    text = text.Replace("--year--", dateyear);
                    text = text.Replace("--TP--", String.Format("{0:0.00}", TP));
                    text = text.Replace("--UPNV--", String.Format("{0:0.00}", UPNV));
                    text = text.Replace("--VT--", String.Format("{0:0.00}", VT));
                    text = text.Replace("--SUB--", String.Format("{0:0.00}", SUB));
                    text = text.Replace("--VATSET--", vatreplace);
                    text = text.Replace("--quantity--", quan.Text);
                    text = text.Replace("--APrice--", price.Text);
                    text = text.Replace("--itemname1--", itemname1.Text);
                    text = text.Replace("--itemname2--", itemname2.Text);
                    text = text.Replace("--Housen--", Housen.Text);
                    text = text.Replace("--Streetn--", streetn.Text);
                    text = text.Replace("--inid--", invoiceid.ToString());
                    text = text.Replace("--PID--", url.Text.ToUpper());
                    text = text.Replace("--town--", town.Text.ToUpper());
                    text = text.Replace("--county--", county.Text.ToUpper());
                    text = text.Replace("--postcode--", postcode.Text.ToUpper());
                    text = text.Replace("--orderid--", invoiceid1.ToString());
                    text = text.Replace("--prid--", pur4.ToUpper());

                    /////////////////////////////////////////////////////////////////////////////////////////////
                    ///Save progress on desktop as html file alongside the background imge specific to the region
                    string getdesk = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string desk = getdesk + "\\website.html"; // set path desktop and filename html
                    string desk1 = desk.Replace("\\", "/"); // convert \ to /
                    File.WriteAllText(@desk1, text); //save website.html to desktop
                    HtmlDocument doc = webBrowser1.Document; //
                    doc.Body.InnerHtml = text; //////////////// move text to source in web browser
                    if (File.Exists(@getdesk + "\\backgroundgermany.jpg"))
                    {
                        //Console.WriteLine("The file exists.");
                    }
                    else
                    {
                        File.Copy(@"backgroundgermany.jpg", @getdesk + "\\backgroundgermany.jpg"); // copys background image to desktop too
                    }
                }

                if (regb.Text == "GB")
                {
                    backgroundWorker1.RunWorkerAsync();
                    string dateday = date.Value.ToString("dd"); //get day
                    string datemonth = date.Value.ToString("MM"); //get month
                    string dateyear = date.Value.ToString("yyyy"); //get year

                    int dayvalue = Convert.ToInt32(dateday); //
                    int answerSubtract = dayvalue - 1; //////// +1 day for invoice date

                    //////////////////////////////////////////////////////////////////////////
                    ///maths for vat 
                    Decimal dprice = decimal.Parse(price.Text, CultureInfo.InvariantCulture); // converts price string to decimal
                    string vatreplace = vat.Text.Replace("%", ""); //removes % from string so can converto decimal
                    Decimal dvat = decimal.Parse(vatreplace);
                    Decimal dquan = decimal.Parse(quan.Text, CultureInfo.InvariantCulture);
                    Decimal hun = 100; // 100
                    Decimal hunvat = decimal.Add(hun, dvat); // 120
                    Decimal TP = decimal.Multiply(dprice, dquan); // total price price X quantity
                    Decimal UPNV0 = Decimal.Divide(dprice, hunvat); // price divided by 100 + vat (e.g $25/120)
                    Decimal UPNV = Decimal.Multiply(UPNV0, hun); // multiply UPNV0 with 100 to get vat
                    Decimal SUB = Decimal.Multiply(UPNV, dquan); // multiply vat with quantity to get total vat for quantity
                    Decimal VT0 = Decimal.Divide(SUB, 10);
                    Decimal VT = Decimal.Multiply(VT0, dquan);

                    ////////////////////////////////////////////////////////////////////////////////////
                    /// Set random numbers for invoice id etc...
                    Random rnd = new Random();
                    int invoiceid = rnd.Next(106000000, 106700108);
                    int invoiceid1 = rnd.Next(0700000, 0799120);
                    int pur1 = rnd.Next(10, 99);
                    int pur2 = rnd.Next(0, 9);
                    int pur3 = rnd.Next(0, 9);
                    string pur4 = (pur1 + "FEN" + pur2 + "O" + pur3 + "VHKD");
                    ////////////////////////////////////////////////////////////////////////////////////
                    ///Get's website file
                    string text = File.ReadAllText("website.html"); //read source of html file
                                                                    ////////////////////////////////////////////////////////////////////////////////////
                                                                    ///Replace placeholders in html with data from form
                    text = text.Replace("--name--", nameb.Text);
                    text = text.Replace("--nameup--", nameb.Text.ToUpper());
                    text = text.Replace("--sname--", surnb.Text);
                    text = text.Replace("--CountryCode--", regb.Text);
                    text = text.Replace("--currency--", currency.Text);
                    text = text.Replace("--day1--", dateday);
                    text = text.Replace("--day--", answerSubtract.ToString());
                    text = text.Replace("--month--", datemonth);
                    text = text.Replace("--year--", dateyear);
                    text = text.Replace("--TP--", String.Format("{0:0.00}", TP));
                    text = text.Replace("--UPNV--", String.Format("{0:0.00}", UPNV));
                    text = text.Replace("--VT--", String.Format("{0:0.00}", VT));
                    text = text.Replace("--SUB--", String.Format("{0:0.00}", SUB));
                    text = text.Replace("--VATSET--", vatreplace);
                    text = text.Replace("--quantity--", quan.Text);
                    text = text.Replace("--APrice--", price.Text);
                    text = text.Replace("--itemname1--", itemname1.Text);
                    text = text.Replace("--itemname2--", itemname2.Text);
                    text = text.Replace("--Housen--", Housen.Text);
                    text = text.Replace("--Streetn--", streetn.Text);
                    text = text.Replace("--inid--", invoiceid.ToString());
                    text = text.Replace("--PID--", url.Text.ToUpper());
                    text = text.Replace("--town--", town.Text.ToUpper());
                    text = text.Replace("--county--", county.Text.ToUpper());
                    text = text.Replace("--postcode--", postcode.Text.ToUpper());
                    text = text.Replace("--orderid--", invoiceid1.ToString());
                    text = text.Replace("--prid--", pur4.ToUpper());
                    ////////////////////////////////////////////////////////////////////////////////////
                    ///Save progress on desktop as html file alongside the background imge specific to the region
                    string getdesk = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string desk = getdesk + "\\website.html"; // set path desktop and filename html
                    string desk1 = desk.Replace("\\", "/"); // convert \ to /
                    File.WriteAllText(@desk1, text); //save website.html to desktop
                    HtmlDocument doc = webBrowser1.Document; //
                    doc.Body.InnerHtml = text; //////////////// move text to source in web browser
                    if (File.Exists(@getdesk + "\\background.jpg"))
                    {
                        //Console.WriteLine("The file exists.");
                    }
                    else
                    {
                        File.Copy(@"backgroundgermany.jpg", @getdesk + "\\background.jpg"); // copys background image to desktop too
                    }
                }

                if (regb.Text == "ES")
                {
                    backgroundWorker1.RunWorkerAsync();
                    string dateday = date.Value.ToString("dd"); //get day
                    string datemonth = date.Value.ToString("MM"); //get month
                    string dateyear = date.Value.ToString("yyyy"); //get year

                    int dayvalue = Convert.ToInt32(dateday); //
                    int answerSubtract = dayvalue - 1; //////// +1 day for invoice date

                    //////////////////////////////////////////////////////////////////////////
                    ///maths for vat 
                    Decimal dprice = decimal.Parse(price.Text, CultureInfo.InvariantCulture); // converts price string to decimal
                    string vatreplace = vat.Text.Replace("%", ""); //removes % from string so can converto decimal
                    Decimal dvat = decimal.Parse(vatreplace);
                    Decimal dquan = decimal.Parse(quan.Text, CultureInfo.InvariantCulture);
                    Decimal hun = 100; // 100
                    Decimal hunvat = decimal.Add(hun, dvat); // 120
                    Decimal TP = decimal.Multiply(dprice, dquan); // total price price X quantity
                    Decimal UPNV0 = Decimal.Divide(dprice, hunvat); // price divided by 100 + vat (e.g $25/120)
                    Decimal UPNV = Decimal.Multiply(UPNV0, hun); // multiply UPNV0 with 100 to get vat
                    Decimal SUB = Decimal.Multiply(UPNV, dquan); // multiply vat with quantity to get total vat for quantity
                    Decimal VT0 = Decimal.Divide(SUB, 10);
                    Decimal VT = Decimal.Multiply(VT0, dquan);

                    ////////////////////////////////////////////////////////////////////////////////////
                    /// Set random numbers for invoice id etc...
                    Random rnd = new Random();
                    int invoiceid = rnd.Next(106000000, 106700108);
                    int invoiceid1 = rnd.Next(0700000, 0799120);
                    int pur1 = rnd.Next(10, 99);
                    int pur2 = rnd.Next(0, 9);
                    int pur3 = rnd.Next(0, 9);
                    string pur4 = (pur1 + "FEN" + pur2 + "O" + pur3 + "VHKD");
                    ////////////////////////////////////////////////////////////////////////////////////
                    ///Get's website file
                    string text = File.ReadAllText("websitespain.html"); //read source of html file
                                                                         ////////////////////////////////////////////////////////////////////////////////////
                                                                         ///Replace placeholders in html with data from form
                    text = text.Replace("--name--", nameb.Text);
                    text = text.Replace("--nameup--", nameb.Text.ToUpper());
                    text = text.Replace("--sname--", surnb.Text);
                    text = text.Replace("--CountryCode--", regb.Text);
                    text = text.Replace("--currency--", currency.Text);
                    text = text.Replace("--day1--", dateday);
                    text = text.Replace("--day--", answerSubtract.ToString());
                    text = text.Replace("--month--", datemonth);
                    text = text.Replace("--year--", dateyear);
                    text = text.Replace("--TP--", String.Format("{0:0.00}", TP));
                    text = text.Replace("--UPNV--", String.Format("{0:0.00}", UPNV));
                    text = text.Replace("--VT--", String.Format("{0:0.00}", VT));
                    text = text.Replace("--SUB--", String.Format("{0:0.00}", SUB));
                    text = text.Replace("--VATSET--", vatreplace);
                    text = text.Replace("--quantity--", quan.Text);
                    text = text.Replace("--APrice--", price.Text);
                    text = text.Replace("--itemname1--", itemname1.Text);
                    text = text.Replace("--itemname2--", itemname2.Text);
                    text = text.Replace("--Housen--", Housen.Text);
                    text = text.Replace("--Streetn--", streetn.Text);
                    text = text.Replace("--inid--", invoiceid.ToString());
                    text = text.Replace("--PID--", url.Text.ToUpper());
                    text = text.Replace("--town--", town.Text.ToUpper());
                    text = text.Replace("--county--", county.Text.ToUpper());
                    text = text.Replace("--postcode--", postcode.Text.ToUpper());
                    text = text.Replace("--orderid--", invoiceid1.ToString());
                    text = text.Replace("--prid--", pur4.ToUpper());
                    ////////////////////////////////////////////////////////////////////////////////////
                    ///Save progress on desktop as html file alongside the background imge specific to the region
                    string getdesk = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string desk = getdesk + "\\website.html"; // set path desktop and filename html
                    string desk1 = desk.Replace("\\", "/"); // convert \ to /
                    File.WriteAllText(@desk1, text); //save website.html to desktop
                    HtmlDocument doc = webBrowser1.Document; //
                    doc.Body.InnerHtml = text; //////////////// move text to source in web browser
                    if (File.Exists(@getdesk + "\\backgroundspain.jpg"))
                    {
                        //Console.WriteLine("The file exists.");
                    }
                    else
                    {
                        File.Copy(@"backgroundgermany.jpg", @getdesk + "\\backgroundspain.jpg"); // copys background image to desktop too
                    }
                }

                if (regb.Text == "FR")
                {
                    backgroundWorker1.RunWorkerAsync();
                    string dateday = date.Value.ToString("dd"); //get day
                    string datemonth = date.Value.ToString("MM"); //get month
                    string dateyear = date.Value.ToString("yyyy"); //get year

                    int dayvalue = Convert.ToInt32(dateday); //
                    int answerSubtract = dayvalue - 1; //////// +1 day for invoice date

                    //////////////////////////////////////////////////////////////////////////
                    ///maths for vat 
                    Decimal dprice = decimal.Parse(price.Text, CultureInfo.InvariantCulture); // converts price string to decimal
                    string vatreplace = vat.Text.Replace("%", ""); //removes % from string so can converto decimal
                    Decimal dvat = decimal.Parse(vatreplace);
                    Decimal dquan = decimal.Parse(quan.Text, CultureInfo.InvariantCulture);
                    Decimal hun = 100; // 100
                    Decimal hunvat = decimal.Add(hun, dvat); // 120
                    Decimal TP = decimal.Multiply(dprice, dquan); // total price price X quantity
                    Decimal UPNV0 = Decimal.Divide(dprice, hunvat); // price divided by 100 + vat (e.g $25/120)
                    Decimal UPNV = Decimal.Multiply(UPNV0, hun); // multiply UPNV0 with 100 to get vat
                    Decimal SUB = Decimal.Multiply(UPNV, dquan); // multiply vat with quantity to get total vat for quantity
                    Decimal VT0 = Decimal.Divide(SUB, 10);
                    Decimal VT = Decimal.Multiply(VT0, dquan);

                    ////////////////////////////////////////////////////////////////////////////////////
                    /// Set random numbers for invoice id etc...
                    Random rnd = new Random();
                    int invoiceid = rnd.Next(106000000, 106700108);
                    int invoiceid1 = rnd.Next(0700000, 0799120);
                    int pur1 = rnd.Next(10, 99);
                    int pur2 = rnd.Next(0, 9);
                    int pur3 = rnd.Next(0, 9);
                    string pur4 = (pur1 + "FEN" + pur2 + "O" + pur3 + "VHKD");
                    ////////////////////////////////////////////////////////////////////////////////////
                    ///Get's website file
                    string text = File.ReadAllText("websitefrance.html"); //read source of html file
                                                                          ////////////////////////////////////////////////////////////////////////////////////
                                                                          ///Replace placeholders in html with data from form
                    text = text.Replace("--name--", nameb.Text);
                    text = text.Replace("--nameup--", nameb.Text.ToUpper());
                    text = text.Replace("--sname--", surnb.Text);
                    text = text.Replace("--CountryCode--", regb.Text);
                    text = text.Replace("--currency--", currency.Text);
                    text = text.Replace("--day1--", dateday);
                    text = text.Replace("--day--", answerSubtract.ToString());
                    text = text.Replace("--month--", datemonth);
                    text = text.Replace("--year--", dateyear);
                    text = text.Replace("--TP--", String.Format("{0:0.00}", TP));
                    text = text.Replace("--UPNV--", String.Format("{0:0.00}", UPNV));
                    text = text.Replace("--VT--", String.Format("{0:0.00}", VT));
                    text = text.Replace("--SUB--", String.Format("{0:0.00}", SUB));
                    text = text.Replace("--VATSET--", vatreplace);
                    text = text.Replace("--quantity--", quan.Text);
                    text = text.Replace("--APrice--", price.Text);
                    text = text.Replace("--itemname1--", itemname1.Text);
                    text = text.Replace("--itemname2--", itemname2.Text);
                    text = text.Replace("--Housen--", Housen.Text);
                    text = text.Replace("--Streetn--", streetn.Text);
                    text = text.Replace("--inid--", invoiceid.ToString());
                    text = text.Replace("--PID--", url.Text.ToUpper());
                    text = text.Replace("--town--", town.Text.ToUpper());
                    text = text.Replace("--county--", county.Text.ToUpper());
                    text = text.Replace("--postcode--", postcode.Text.ToUpper());
                    text = text.Replace("--orderid--", invoiceid1.ToString());
                    text = text.Replace("--prid--", pur4.ToUpper());
                    ////////////////////////////////////////////////////////////////////////////////////
                    ///Save progress on desktop as html file alongside the background imge specific to the region
                    string getdesk = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string desk = getdesk + "\\website.html"; // set path desktop and filename html
                    string desk1 = desk.Replace("\\", "/"); // convert \ to /
                    File.WriteAllText(@desk1, text); //save website.html to desktop
                    HtmlDocument doc = webBrowser1.Document; //
                    doc.Body.InnerHtml = text; //////////////// move text to source in web browser
                    if (File.Exists(@getdesk + "\\backgroundfrance.jpg"))
                    {
                        //Console.WriteLine("The file exists.");
                    }
                    else
                    {
                        File.Copy(@"backgroundgermany.jpg", @getdesk + "\\backgroundfrance.jpg"); // copys background image to desktop too
                    }
                }
            }
            catch{ MessageBox.Show("Somthing went wrong!"); }
         }

        private void regb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;
            if (count == 0)
            {
                count = 1;
            }
            if (count == 1)
            {
                count = 2;
            }
            if (regb.Text == "DE" && count == 2)
            {
                string html = File.ReadAllText("websitegermany.html");
                HtmlDocument doc = webBrowser1.Document;
                doc.Body.InnerHtml = html;
            }
            if (regb.Text == "GB" && count == 2)
            {
                string html = File.ReadAllText("website.html");
                HtmlDocument doc = webBrowser1.Document;
                doc.Body.InnerHtml = html;
            }
            if (regb.Text == "FR" && count == 2)
            {
                string html = File.ReadAllText("websitefrance.html");
                HtmlDocument doc = webBrowser1.Document;
                doc.Body.InnerHtml = html;
            }
            if (regb.Text == "ES" && count == 2)
            {
                string html = File.ReadAllText("websitespain.html");
                HtmlDocument doc = webBrowser1.Document;
                doc.Body.InnerHtml = html;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            try
            {
                string saveall = ("[name]" + nameb.Text + "[name/]" + "[surname]" + surnb.Text + "[surname/]" + "[Region]" + regb.Text + "[Region/]" + "[HouseNumber]" + Housen.Text + "[HouseNumber/]" + "[StreetName]" + streetn.Text + "[StreetName/]" + "[Town]" + town.Text + "[Town/]" + "[County]" + county.Text + "[County/]" + "[Postcode]" + postcode.Text + "[Postcode/]" + "[Itemname1]" + itemname1.Text + "[Itemname1/]" + "[Itemname2]" + itemname2.Text + "[Itemname2/]" + "[Url]" + url.Text + "[Url/]" + "[Date]" + date.Value.ToString() + "[Date/]" + "[Currency]" + currency.Text + "[Currency/]" + "[Price]" + price.Text + "[Price/]" + "[Quantity]" + quan.Text + "[Quantity/]" + "[Vat]" + vat.Text + "[Vat/]");
                string text = saveall.Replace("/]", "/]" + System.Environment.NewLine);

                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "Invoice";
                save.Filter = "Text File | *.txt";
                if (save.ShowDialog() == DialogResult.OK)
                {

                    StreamWriter writer = new StreamWriter(save.OpenFile());
                    writer.WriteLine(text.ToString());
                    writer.Dispose();
                    writer.Close();

                }
            }
            catch
            {
                MessageBox.Show("Try running as admin");
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    InitialDirectory = @"D:\",
                  Title = "Browse Text Files",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "txt",
                    Filter = "txt files (*.txt)|*.txt",
                    FilterIndex = 2,
                    RestoreDirectory = true,

                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog1.FileName;
                    //string path = @"info.File";
                    string readText = File.ReadAllText(path);

                    string St = readText;
                    //name
                    int pFromname = St.IndexOf("[name]") + "[name]".Length;
                    int pToname = St.LastIndexOf("[name/]");
                    nameb.Text = St.Substring(pFromname, pToname - pFromname);
                    //surname
                    int pFromsurname = St.IndexOf("[surname]") + "[surname]".Length;
                    int pTosurname = St.LastIndexOf("[surname/]");
                    surnb.Text = St.Substring(pFromsurname, pTosurname - pFromsurname);
                    //Region
                    int pFromRegion = St.IndexOf("[Region]") + "[Region]".Length;
                    int pToRegion = St.LastIndexOf("[Region/]");
                    regb.Text = St.Substring(pFromRegion, pToRegion - pFromRegion);
                    //House Number
                    int pFromHouseNumber = St.IndexOf("[HouseNumber]") + "[HouseNumber]".Length;
                    int pToHouseNumber = St.LastIndexOf("[HouseNumber/]");
                    Housen.Text = St.Substring(pFromHouseNumber, pToHouseNumber - pFromHouseNumber);
                    //Street Name
                    int pFromStreetName = St.IndexOf("[StreetName]") + "[StreetName]".Length;
                    int pToStreetName = St.LastIndexOf("[StreetName/]");
                    streetn.Text = St.Substring(pFromStreetName, pToStreetName - pFromStreetName);
                    //Town
                    int pFromTown = St.IndexOf("[Town]") + "[Town]".Length;
                    int pToTown = St.LastIndexOf("[Town/]");
                    town.Text = St.Substring(pFromTown, pToTown - pFromTown);
                    //County
                    int pFromCounty = St.IndexOf("[County]") + "[County]".Length;
                    int pToCounty = St.LastIndexOf("[County/]");
                    county.Text = St.Substring(pFromCounty, pToCounty - pFromCounty);
                    // post code
                    int pFromPostcode = St.IndexOf("[Postcode]") + "[Postcode]".Length;
                    int pToPostcode = St.LastIndexOf("[Postcode/]");
                    postcode.Text = St.Substring(pFromPostcode, pToPostcode - pFromPostcode);
                    // item name 1
                    int pFromItemname1 = St.IndexOf("[Itemname1]") + "[Itemname1]".Length;
                    int pToItemname1 = St.LastIndexOf("[Itemname1/]");
                    itemname1.Text = St.Substring(pFromItemname1, pToItemname1 - pFromItemname1);
                    // item name 2
                    int pFromItemname2 = St.IndexOf("[Itemname2]") + "[Itemname2]".Length;
                    int pToItemname2 = St.LastIndexOf("[Itemname2/]");
                    itemname2.Text = St.Substring(pFromItemname2, pToItemname2 - pFromItemname2);
                    //Url
                    int pFromUrl = St.IndexOf("[Url]") + "[Url]".Length;
                    int pToUrl = St.LastIndexOf("[Url/]");
                    url.Text = St.Substring(pFromUrl, pToUrl - pFromUrl);
                    //Date
                    int pFromDay = St.IndexOf("[Date]") + "[Date]".Length;
                    int pToDay = St.LastIndexOf("[Date/]");
                    date.Value = DateTime.Parse(St.Substring(pFromDay, pToDay - pFromDay));
                    //curency
                    int pFromCurrency = St.IndexOf("[Currency]") + "[Currency]".Length;
                    int pToCurrency = St.LastIndexOf("[Currency/]");
                    currency.Text = St.Substring(pFromCurrency, pToCurrency - pFromCurrency);
                    //Item Price
                    int pFromPrice = St.IndexOf("[Price]") + "[Price]".Length;
                    int pToPrice = St.LastIndexOf("[Price/]");
                    price.Text = St.Substring(pFromPrice, pToPrice - pFromPrice);
                    //quantity
                    int pFromQuantity = St.IndexOf("[Quantity]") + "[Quantity]".Length;
                    int pToQuantity = St.LastIndexOf("[Quantity/]");
                    quan.Text = St.Substring(pFromQuantity, pToQuantity - pFromQuantity);
                    //vat
                    int pFromVat = St.IndexOf("[Vat]") + "[Vat]".Length;
                    int pToVat = St.LastIndexOf("[Vat/]");
                    vat.Text = St.Substring(pFromVat, pToVat - pFromVat);
                }

            }
            catch
            {
                MessageBox.Show("Could not find Backup");
            }
        }
    }
}