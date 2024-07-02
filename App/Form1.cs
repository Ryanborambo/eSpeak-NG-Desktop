using System.Diagnostics;
using System.Reflection.Metadata;
using System.Windows.Forms;




namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Success!");
            // Eventually have this say "Speaking..." while eSpeak is active

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Program loaded. CHECK IF ESPEAK IS VALID HERE EVENTUALLY!
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 box1 = new AboutBox1();
            box1.ShowDialog();

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/espeak-ng/espeak-ng") { UseShellExecute = true });
            MessageBox.Show("Opened eSpeak-NG's repo in browser. Remove this later.");
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/Ryanborambo/eSpeak-NG-desktop") { UseShellExecute = true });
            MessageBox.Show("Opened this repo in browser. Remove this later.");
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
