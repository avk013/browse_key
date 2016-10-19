using Gecko;
using Gecko.DOM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string file_path = @"F:\brows123\1\";
        string[][] tab_array_in_double = null;
        int ch = 0;
        string regions = "garden";
        public Form1()
        {
            InitializeComponent();
            Gecko.Xpcom.Initialize(@"F:\brows123\xulrunner\bin");
        }
        public void WriteQuery(string query)
        {
            // получаем все элементы с тегом input
            var inputsElements = this.geckoWebBrowser1.Document.GetElementsByTagName("input");
            // получаем первый input, имя (атрибут "name") которого равно q
            var queryElement = inputsElements.First(i => i.GetAttribute("name") == "q");
            // "плавный" набор поискового запроса
            Random random = new Random();
            for (int i = 0; i < query.Length; i++)
            {
                queryElement.SetAttribute("value", query.Substring(0, i + 1));
                //await TaskEx.Delay(random.Next(100, 350));
            }
            // получаем все элементы с тегом button
            var buttonsElements = this.geckoWebBrowser1.Document.GetElementsByTagName("button");
            // указываем, что началась загрузка, кликаем по первой кнопке с именем "btnG, запускаем таймер и ждем загрузки страницы
            //this._loading = true;
            //buttonsElements.First(i => i.GetAttribute("name") == "btnG").Click();
            //this._loadingTimer.Start();
            //await this.WaitForLoading();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //geckoWebBrowser1.Navigate("ya.ru");
            //geckoWebBrowser1.
            //WriteQuery("lalala");
            /*  GeckoHtmlElement element = null;

              var geckoDomElement = WebBrowser1.Document.DocumentElement;
              if (geckoDomElement is GeckoHtmlElement)
              {
                  element = (GeckoHtmlElement)geckoDomElement;
                  var innerHtml = element.InnerHtml;
              }*/
            GeckoHtmlElement element = null;
            //string innerHtml = element.InnerHtml;
            //var innerHtml;
            string s="";
            var geckoDomElement = geckoWebBrowser1.Document.DocumentElement;
            if (geckoDomElement is GeckoHtmlElement)
            {
                element = (GeckoHtmlElement)geckoDomElement;
            var    innerHtml = element.InnerHtml;
                s=s+ innerHtml.ToString();

            }
            
            
            textBox1.Text = s;
            geckoWebBrowser1.Navigate("https://www.yandex.ru/search/?text=время&lr=213&clid=9582");
        }
        //string[] word = { "123","asfsa","asfdfsa"};
        //int nom = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            
            geckoWebBrowser1.Navigate("https://www.yandex.ru/search/?text=boom&lr=213&clid=9582&rstr=-213");
          //  nom += 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
 

            // получаем все элементы с тегом input
            var inputsElements = geckoWebBrowser1.Document.GetElementsByTagName("input");
            // получаем первый input, имя (атрибут "name") которого равно q
            //string b = "";
            //for (int i = 0; i < inputsElements.Length; i++) b = b + inputsElements.ToString();
            var queryElement = inputsElements.First(i => i.GetAttribute("name") == "text");
            textBox1.Text = queryElement.GetAttribute("value") ;

            var buttonsElements = geckoWebBrowser1.Document.GetElementsByTagName("button");
            ///
            string query = "dsfdsfdsfsdgd111";
            for (int i = 0; i < query.Length; i++)
            {
                queryElement.SetAttribute("value", query.Substring(0, i + 1));
                //await TaskEx.Delay(random.Next(100, 350));
            }
            ///

            //queryElement.SetAttribute("value", "66666");
            buttonsElements.First(i => i.GetAttribute("role") == "button").Click();
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {

          

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
         
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
           
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            geckoWebBrowser1.Width = this.Width - 15;
            geckoWebBrowser1.Height = this.Height - 15;
            button6.Top = 70;
            button4.Top = 100;
            button5.Top = 200;
            button6.Left=button5.Left=button4.Left = geckoWebBrowser1.Width - 180;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button4.Enabled = button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.csv";
            openFileDialog1.Title = "фал после для обработки";
            openFileDialog1.FileName = "1.csv";
            openFileDialog1.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\1.csv";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                path = openFileDialog1.FileName;
            
            string[] tab0 = File.ReadAllLines(path, Encoding.Default);
            string[] tab_array_in;
            tab_array_in_double = new string[tab0.Length][];
            
            for (int i = 0; i < tab0.Length; i++)
            {
                tab_array_in_double[i] = new string[2];
                if (!String.IsNullOrEmpty(tab0[i]))
                {
                    tab_array_in = tab0[i].Split(';');
                    for (int j = 0; j < 2; j++)
                    { tab_array_in_double[i][j] = tab_array_in[j]; }
                }
            }
            geckoWebBrowser1.Navigate("https://www.yandex.ru/search/?text=" + tab_array_in_double[ch][1] + " " + regions + " &lr=213&clid=9582&rstr=-213");
            ch++;
            button4.Enabled = button5.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            geckoWebBrowser1.Navigate("https://www.yandex.ru/search/?text=" + tab_array_in_double[ch][1] + " "+regions+" &lr=213&clid=9582&rstr=-213");
            File.AppendAllText(file_path+"2.csv", tab_array_in_double[ch - 1][0]+";"+tab_array_in_double[ch-1][1]+Environment.NewLine);
            ch++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            geckoWebBrowser1.Navigate("https://www.yandex.ru/search/?text=" + tab_array_in_double[ch][1] + " " + regions + " &lr=213&clid=9582&rstr=-213");
            ch++;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            regions = textBox1.Text;
           // textBox1.Text = regions + "+";
        }
    }
}
