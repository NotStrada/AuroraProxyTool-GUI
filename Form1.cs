using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leaf.xNet;
using System.Net;
using System.Threading;
using System.IO;

namespace Aurora_Proxy_Tool
{
    public partial class Form1 : Form
    {

        int goodProxy;
        int badProxy;
        int remaining;
        string curProxy = "";
        int aliveThreads = 0;

        Point lastPoint;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minBtt_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void scrapeBtt_Click(object sender, EventArgs e)
        {
            string proxyURL = "";
            if (comboBox1.SelectedIndex == 0) // HTTP/HTTPs
            {
                proxyURL = "https://api.proxyscrape.com/v2/?request=getproxies&protocol=http&timeout=10000&country=all&ssl=all&anonymity=all";
            } else if (comboBox1.SelectedIndex == 1)  // Socks4
            {
                proxyURL = "https://api.proxyscrape.com/v2/?request=getproxies&protocol=socks4&timeout=10000&country=all";
            }
            else // socks5
            {
                proxyURL = "https://api.proxyscrape.com/v2/?request=getproxies&protocol=socks5&timeout=10000&country=all";
            }
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            try
            {
                proxies.Text = wc.DownloadString(proxyURL);
                string proxiesNum = proxies.Lines.Count().ToString();
                label1.Text = $"Scraped proxies: {proxiesNum}";
            } catch
            {
                label1.Text = "Scraped proxies:     0";
                MessageBox.Show("Error!!"); 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBtt_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Scraped proxies:     0")
            {
                MessageBox.Show("You need to scrape proxies before start checking");
            }
            else
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                Thread t = new Thread(new ThreadStart(proxyChecker));
                t.Start();
            }               
        }
        private void proxyChecker()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            foreach(string line in proxies.Lines)
            {
                line1:
                if(aliveThreads < threadsInp.Value)
                {
                    curProxy = line;
                    Thread t = new Thread(new ThreadStart(checkCurProxy));
                    t.Start();
                    aliveThreads++;
                    threadsLbl.Text = aliveThreads.ToString();
                    threadsLbl.Refresh();
                } else
                {
                    for(int i = 0; i < 100; i++)
                    {
                        System.Threading.Thread.Sleep(10);
                        Application.DoEvents();
                    }
                    goto line1;
                }
                
            }
            do
            {
                System.Threading.Thread.Sleep(50);
                Application.DoEvents();
            } while(aliveThreads > 0);
            MessageBox.Show("Finished!");
        }

        private void checkCurProxy()
        {
            checkProxy(curProxy);
        }
        private void checkProxy(string line)
        {
            HttpRequest req = new HttpRequest();
            req.UserAgent = Http.ChromeUserAgent();
            req.ConnectTimeout = Convert.ToInt32(timeoutInp.Text);
            try
            {
                if (comboBox1.Text == "HTTP / HTTPs")
                {
                    req.Proxy = HttpProxyClient.Parse(line);
                }
                else if (comboBox1.Text == "Socks4")
                {
                    req.Proxy = Socks4ProxyClient.Parse(line);
                }
                else if (comboBox1.Text == "Socks5")
                {
                    req.Proxy = Socks5ProxyClient.Parse(line);
                }
            } catch(Exception ex)
            {
                badProxy++;
                deadLbl.Text = $"Dead Proxies: {badProxy.ToString()}";
                deadLbl.Refresh();
                aliveThreads--;
                threadsLbl.Text = aliveThreads.ToString();
                threadsLbl.Refresh();
            }
            

            try
            {
                var req1 = req.Get("https://www.lagado.com/tools/proxy-test");
                goodProxy++;
                aliveTxt.AppendText(line + Environment.NewLine);
                validLbl.Text = $"Valid Proxies: {goodProxy.ToString()}";
                validLbl.Refresh();
                aliveThreads--;
                threadsLbl.Text = aliveThreads.ToString();
                threadsLbl.Refresh();
            }
            catch
            {
                badProxy++;
                deadLbl.Text = $"Dead Proxies: {badProxy.ToString()}";
                deadLbl.Refresh();
                aliveThreads--;
                threadsLbl.Text = aliveThreads.ToString();
                threadsLbl.Refresh();
            }    
        }

        private void aliveTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBtt_Click(object sender, EventArgs e)
        {
            var svf = new SaveFileDialog();
            svf.FileName = "output";
            svf.Filter = "Text Files|*.txt";
            if (svf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(svf.FileName, aliveTxt.Text);
                } catch
                {

                }
            }
        }

        private void proxies_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

