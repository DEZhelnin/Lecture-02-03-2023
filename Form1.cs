using _02._023._23_lecture;
using System.Diagnostics.Eventing.Reader;

namespace _02._023._23_lect
{
    public partial class Form1 : Form
    {
        private const int maxVal = 2000000;
        private ParSummator ps = new ParSummator(maxVal);
        private SeqSummator ss = new SeqSummator(maxVal);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ShowResult()
        {
            if (label1.InvokeRequired)
            {
                label1.Invoke(ShowResult); //вызывает функцию из основного класса сюда
            }
            else
            {

                label1.Text = ps.Result.ToString();
            }
        }

        public void onProgress()
        {
            if (InvokeRequired)
                Invoke(onProgress);
            
            else 
                progressBar1.Value++;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ss.Sum();
            label2.Text = ss.Result.ToString();
            ps.Sum();
            ps.Progress += onProgress;
            label1.Text = ss.Result.ToString();
        }
    }
}