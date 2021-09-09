using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            setRssTitle(tbUrl.Text);

            //  リンク先のList[lbTitles.SelectedIndex];


        }

        // 指定したURL先からXMLデータを取得しtitle要素を取得し、リストボックスへセットする
        private void setRssTitle(string uri)
        {
            
                using (var wc = new WebClient())
                {
                    wc.Headers.Add("Content-type", "charset=UTF-8");
                   
                    var stream = wc.OpenRead(Uri)

                    XDocument xdoc = XDocument.Load(stream);
                    var nodes = xdoc.Root.Descendants("title");
                    foreach (var node in nodes)
                    {
                        
                }
   　        }
        }

        private void tbUrl_TextChanged(object sender, EventArgs e)
        {
            List<string> = new List<string>();
            link.Add();

        }
    }        
}
