namespace On_Screen_Clock
{
    public partial class ClockForm : Form
    {

        public ClockForm()
        {
            InitializeComponent();
        }

        private void secondTimer_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("HH:mm");
            lblTime.Text = time;
        }
    }
}
