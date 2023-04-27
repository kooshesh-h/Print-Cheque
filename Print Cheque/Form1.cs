using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace PrintCheque15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Curr;
        string Cen;

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy"; 
            txtDate.Format = DateTimePickerFormat.Custom;
            txtDate.CustomFormat = "dd/MM/yyyy";

            rvMainViewer.Visible = false;
            rvMainViewerIS.Visible = false;
            rvMainViewerAL.Visible = false;
            rvMainViewerIK.Visible = false;
            //this.rvMainViewer.RefreshReport();

            //this.rvMainViewerIS.RefreshReport();

        }

        private void btnPrepare_Click(object sender, EventArgs e)
        {

            SpeechSynthesizer synth = new SpeechSynthesizer();
            var CD = txtDate.Text;
            var CV = txtValue.Text;
            var CC = txtCent.Text;
            //string chValFinal = (CV + "." + CC);
            string chValFinal =(CV + "." + CC);
            //string CT = NumberToText(float.Parse(chValFinal, System.Globalization.CultureInfo.InvariantCulture));

            //string CT = txtTextValueVal.Text;
            var CN = txtName.Text;

            var slBnk = cmbBank.Text;

            if (slBnk == "IS bank TL")
            {
                Curr = "lira";
                Cen = "kuruş";
                string CT = NumberToText(CV, CC);
                txtTextValueVal.Text = CT;
                rvMainViewer.Visible = true;
                rvMainViewerIS.Visible = false;
                rvMainViewerAL.Visible = false;
                rvMainViewerIK.Visible = false;
                this.rvMainViewer.LocalReport.SetParameters(new ReportParameter("chDate", CD));
                this.rvMainViewer.LocalReport.SetParameters(new ReportParameter("chValue", CV));
                this.rvMainViewer.LocalReport.SetParameters(new ReportParameter("chCent", CC));
                this.rvMainViewer.LocalReport.SetParameters(new ReportParameter("chTxtValue", CT));
                this.rvMainViewer.LocalReport.SetParameters(new ReportParameter("chName", CN));
                this.rvMainViewer.RefreshReport();
            }
            else if (slBnk == "IS bank GBP")
            {
                Curr = "pound";
                Cen = "penny";
                string CT = NumberToText(CV, CC);
                txtTextValueVal.Text = CT;
                rvMainViewerIS.Visible = true;
                rvMainViewer.Visible = false;
                rvMainViewerAL.Visible = false;
                rvMainViewerIK.Visible = false;
                this.rvMainViewerIS.LocalReport.SetParameters(new ReportParameter("chDateIS", CD));
                this.rvMainViewerIS.LocalReport.SetParameters(new ReportParameter("chValue", chValFinal.ToString()));
                this.rvMainViewerIS.LocalReport.SetParameters(new ReportParameter("chTxtValue", CT));
                this.rvMainViewerIS.LocalReport.SetParameters(new ReportParameter("chName", CN));
                this.rvMainViewerIS.RefreshReport();

            }
            else if (slBnk == "IS bank EUR")
            {
                Curr = "euro";
                Cen = "cents";
                string CT = NumberToText(CV, CC);
                txtTextValueVal.Text = CT;
                rvMainViewerIS.Visible = true;
                rvMainViewer.Visible = false;
                rvMainViewerAL.Visible = false;
                rvMainViewerIK.Visible = false;
                this.rvMainViewerIS.LocalReport.SetParameters(new ReportParameter("chDateIS", CD));
                this.rvMainViewerIS.LocalReport.SetParameters(new ReportParameter("chValue", chValFinal.ToString()));
                this.rvMainViewerIS.LocalReport.SetParameters(new ReportParameter("chTxtValue", CT));
                this.rvMainViewerIS.LocalReport.SetParameters(new ReportParameter("chName", CN));
                this.rvMainViewerIS.RefreshReport();

            }
            else if (slBnk == "IS bank USD")
            {
                Curr = "dollar";
                Cen = "cents";
                string CT = NumberToText(CV, CC);
                txtTextValueVal.Text = CT;
                rvMainViewerIS.Visible = true;
                rvMainViewer.Visible = false;
                rvMainViewerAL.Visible = false;
                rvMainViewerIK.Visible = false;
                this.rvMainViewerIS.LocalReport.SetParameters(new ReportParameter("chDateIS", CD));
                this.rvMainViewerIS.LocalReport.SetParameters(new ReportParameter("chValue", chValFinal.ToString()));
                this.rvMainViewerIS.LocalReport.SetParameters(new ReportParameter("chTxtValue", CT));
                this.rvMainViewerIS.LocalReport.SetParameters(new ReportParameter("chName", CN));
                this.rvMainViewerIS.RefreshReport();

            }
            else if (slBnk == "AL bank TL")
            {
                Curr = "lira";
                Cen = "kuruş";
                string CT = NumberToText(CV, CC);
                txtTextValueVal.Text = CT;
                rvMainViewerAL.Visible = true;
                rvMainViewer.Visible = false;
                rvMainViewerIS.Visible = false;
                rvMainViewerIK.Visible = false;
                this.rvMainViewerAL.LocalReport.SetParameters(new ReportParameter("chDateAL", CD));
                this.rvMainViewerAL.LocalReport.SetParameters(new ReportParameter("chValue", chValFinal.ToString()));
                this.rvMainViewerAL.LocalReport.SetParameters(new ReportParameter("chTxtValue", CT));
                this.rvMainViewerAL.LocalReport.SetParameters(new ReportParameter("chName", CN));
                this.rvMainViewerAL.RefreshReport();

            }
            else if (slBnk == "Al bank GBP")
            {
                Curr = "pound";
                Cen = "penny";
                string CT = NumberToText(CV, CC);
                txtTextValueVal.Text = CT;
                rvMainViewerAL.Visible = true;
                rvMainViewer.Visible = false;
                rvMainViewerIS.Visible = false;
                rvMainViewerIK.Visible = false;
                this.rvMainViewerAL.LocalReport.SetParameters(new ReportParameter("chDateAL", CD));
                this.rvMainViewerAL.LocalReport.SetParameters(new ReportParameter("chValue", chValFinal.ToString()));
                this.rvMainViewerAL.LocalReport.SetParameters(new ReportParameter("chTxtValue", CT));
                this.rvMainViewerAL.LocalReport.SetParameters(new ReportParameter("chName", CN));
                this.rvMainViewerAL.RefreshReport();

            }
            else if (slBnk == "Iktisat bank TL")
            {
                Curr = "lira";
                Cen = "kuruş";
                string CT = NumberToText(CV, CC);
                txtTextValueVal.Text = CT;
                rvMainViewerIK.Visible = true;
                rvMainViewer.Visible = false;
                rvMainViewerIS.Visible = false;
                rvMainViewerAL.Visible = false;
                this.rvMainViewerIK.LocalReport.SetParameters(new ReportParameter("chDateIK", CD));
                this.rvMainViewerIK.LocalReport.SetParameters(new ReportParameter("chValue", chValFinal.ToString()));
                this.rvMainViewerIK.LocalReport.SetParameters(new ReportParameter("chTxtValue", CT));
                this.rvMainViewerIK.LocalReport.SetParameters(new ReportParameter("chName", CN));
                this.rvMainViewerIK.RefreshReport();

            }
            else if (slBnk == "Iktisat bank USD")
            {
                Curr = "dollar";
                Cen = "cents";
                string CT = NumberToText(CV, CC);
                txtTextValueVal.Text = CT;
                rvMainViewerIK.Visible = true;
                rvMainViewer.Visible = false;
                rvMainViewerIS.Visible = false;
                rvMainViewerAL.Visible = false;
                this.rvMainViewerIK.LocalReport.SetParameters(new ReportParameter("chDateIK", CD));
                this.rvMainViewerIK.LocalReport.SetParameters(new ReportParameter("chValue", chValFinal.ToString()));
                this.rvMainViewerIK.LocalReport.SetParameters(new ReportParameter("chTxtValue", CT));
                this.rvMainViewerIK.LocalReport.SetParameters(new ReportParameter("chName", CN));
                this.rvMainViewerIK.RefreshReport();

            }

            
            




        }




        private string NumberToText(String n1, string n2)
        {
            int m1 = int.Parse(n1);
            int m2 = int.Parse(n2);

            if (m1 == 0)
                return "sıfır";

            string result = "";

            if (m1 < 0)
            {
                result += "eksi ";
                m1 = -m1;
            }

            int integerPart = m1;
            int decimalPart = m2;

            if (integerPart > 0)
            {
                result += NumberToText(integerPart) + " " + Curr + " ";
            }

            if (decimalPart > 0)
            {
                if (integerPart > 0)
                    result += "ve ";
                result += NumberToText(decimalPart) + " " + Cen + " ";
            }

            return result;
        }

        static string NumberToText(int number)
        {
            if (number == 0)
                return "sıfır";

            string[] ones = { "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] tens = { "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
            string[] teens = { "on bir", "on iki", "on üç", "on dört", "on beş", "on altı", "on yedi", "on sekiz", "on dokuz" };

            string result = "";

            if (number < 0)
            {
                result += "eksi ";
                number = -number;
            }

            if ((number / 1000000) > 0)
            {
                result += NumberToText(number / 1000000) + " milyon ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                result += NumberToText(number / 1000) + " bin ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                result += ones[number / 100 - 1] + " yüz ";
                number %= 100;
            }

            if (number > 0)
            {
                if (result != "")
                    result += "ve ";

                if (number < 10)
                    result += ones[number - 1];
                else if (number < 20)
                    result += teens[number - 11];
                else
                {
                    result += tens[number / 10 - 1] + " ";
                    if ((number % 10) > 0)
                        result += ones[number % 10 - 1];
                }
            }

            return result;
        }


        private void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            rvMainViewer.Visible = false;
            rvMainViewerIS.Visible = false;
            rvMainViewerAL.Visible = false;
            rvMainViewerIK.Visible = false;

            //MessageBox.Show(Curr);
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            this.rvMainViewer.LocalReport.SetParameters(new ReportParameter("chDate", " "));

            this.rvMainViewer.RefreshReport();
        }

        private void btnValue_Click(object sender, EventArgs e)
        {
            this.rvMainViewer.LocalReport.SetParameters(new ReportParameter("chValue", " "));

            this.rvMainViewer.RefreshReport();
        }

        private void btnFloat_Click(object sender, EventArgs e)
        {
            //this.rvMainViewer.LocalReport.SetParameters(new ReportParameter("chCent", " "));

            this.rvMainViewer.RefreshReport();
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            this.rvMainViewer.LocalReport.SetParameters(new ReportParameter("chTxtValue", " "));

            this.rvMainViewer.RefreshReport();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            this.rvMainViewer.LocalReport.SetParameters(new ReportParameter("chName", " "));

            this.rvMainViewer.RefreshReport();
        }
    }
}
