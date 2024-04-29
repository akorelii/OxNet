namespace OxNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void stockMarketCryptoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void binanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.binance.com/");
        }

        private void httpswwwbinancecomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void marketWatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.marketwatch.com/");
        }

        private void globalNewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://globalnews.ca/");

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://edition.cnn.com/");
        }

        private void httpswwwtheguardiancomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void theGuardianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.theguardian.com/");
        }

        private void linkedlnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.linkedin.com/");
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://medium.com/");
        }

        private void gitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://github.com/");
        }

        private void ınstagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.instagram.com/");
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.facebook.com/");
        }

        private void twitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://twitter.com/");
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.youtube.com/");
        }
    }
}
