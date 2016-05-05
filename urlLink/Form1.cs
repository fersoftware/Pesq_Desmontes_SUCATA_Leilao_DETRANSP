using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace urlLink
{
    public partial class frm_TelaPrincioal : Form
    {
        public frm_TelaPrincioal()
        {
            InitializeComponent();
        }
        
        public static string url_ = "http://www.detran.sp.gov.br/wps/wcm/connect/9adf3162-279e-4d6b-8f2b-30e9ef0d4534/%28Situa%C3%A7%C3%A3o+de+Credenciamento+-+S%C3%A3o+Paulo+-+Site+-+29+abr+2016%29.pdf?MOD=AJPERES";

        public static string url2_ = "http://www.detran.sp.gov.br/wps/wcm/connect/606eff9b-5888-42e7-a1c0-ea238c8f97ed/%28Situa%C3%A7%C3%A3o+de+Credenciamento+-+Outros+Estados+-+Site+-+29+abr+2016%29.pdf?MOD=AJPERES";

        public void clic()
        {
            btn_Pesquisa.UseWaitCursor = true;
            var url = url_;
            var url2 = url2_;

            string[] dados = verifica(url, txt_CNPJ.Text).Split('§');
            string[] dados2 = verifica(url2, txt_CNPJ.Text).Split('§');

            rch_Descricao.Text = dados[0];
            int index = int.Parse(dados[1]);
            int index2 = int.Parse(dados2[1]);
            String searchString = "SIM";
            String searchStringnot = "NÃO";

            if (index < 0)
            {
                rch_Descricao.Text = "NADA ENCONTRADO";

                if (index2 < 0)
                {
                    rch_Descricao.Text = "NADA ENCONTRADO..";
                }
            }


            if (dados[0].ToString().IndexOf(searchString) != -1)
            {
                lbl_Status.Text = "LIBERADO";
                lbl_Status.ForeColor = System.Drawing.ColorTranslator.FromHtml("#22FF99");
                btn_Pesquisa.UseWaitCursor = false;
            }
            else
            {
                if (dados[0].ToString().IndexOf(searchStringnot) != -1)
                {

                    lbl_Status.Text = "BLOQUEADO";
                    lbl_Status.ForeColor = System.Drawing.ColorTranslator.FromHtml("#8B0000");
                    btn_Pesquisa.UseWaitCursor = false;
                }
                else
                {
                    lbl_Status.Text = "NADA ENCONTRADO";
                    lbl_Status.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");

                    if (dados2[0].ToString().IndexOf(searchString) != -1)
                    {
                        lbl_Status.Text = "LIBERADO";
                        lbl_Status.ForeColor = System.Drawing.ColorTranslator.FromHtml("#22FF99");
                        rch_Descricao.Text = dados2[0];
                        btn_Pesquisa.UseWaitCursor = false;
                    }
                    else
                    {
                        if (dados2[0].ToString().IndexOf(searchStringnot) != -1)
                        {
                            lbl_Status.Text = "BLOQUEADO";
                            btn_Pesquisa.UseWaitCursor = false;
                            lbl_Status.ForeColor = System.Drawing.ColorTranslator.FromHtml("#8B0000");
                        }
                        else
                        {
                            lbl_Status.Text = "NADA ENCONTRADO";
                            btn_Pesquisa.UseWaitCursor = false;
                            lbl_Status.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
                        }
                    }
                }
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            System.Threading.Thread.Sleep(2000);
            this.Cursor = Cursors.Default;
            clic();  
        }

        public static string verifica(string url, string txt)
        {
            string s = ExtractTextFromPdf(url);
            string[] words = Regex.Split(s, "\n|\r|\r\n");

            String searchString = txt;
            List<string> lst = new List<string>(words);

            int index = 0;
            int n = 0;
            foreach (var item in lst)
            {
                if (item.ToString().IndexOf(searchString) != -1) index = n;
                n++;
            }

            string[] valor = new string[2];
            return words[index] + "§" + index.ToString();            
        }

        public static string ExtractTextFromPdf(string path)
        {
            using (PdfReader reader = new PdfReader(path))
            {
                StringBuilder text = new StringBuilder();
                List<string> lista = new List<string>();
                string fer = "";

                

                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));

                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string currentText = PdfTextExtractor.GetTextFromPage(reader, i, strategy);

                    currentText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentText)));


                    fer += currentText;
                }

                return fer;
            }
        }
               

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            Process.Start(url_);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(url2_);
        }
    }


}
