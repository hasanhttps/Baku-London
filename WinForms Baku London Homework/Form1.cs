using WinForms_Baku_London_Homework.Properties;

namespace WinForms_Baku_London_Homework {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        System.Windows.Forms.Timer timer1 = new();
        System.Windows.Forms.Timer timer2 = new();

        private void button1_Click(object sender, EventArgs e) {
            timer2.Stop();
            BackgroundImage = Resources.Azerbaijan;
            Icon = Resources.azerbaijan1;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e) {
            timer1.Stop();
            BackgroundImage = Resources.London;
            Icon = Resources.united_kingdom;
            timer2.Tick += timer2_Tick;
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            Text = DateTime.Now.ToLongTimeString();
        }
        private void timer2_Tick(object sender, EventArgs e) {
            Text = DateTime.Now.AddHours(-3).ToLongTimeString();
        }
    }
}