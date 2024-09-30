namespace On_Screen_Clock
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        int xPosition = 1800;
        int yPosition = 0;

        Form clockForm = new ClockForm();

        bool clockVisible = false;

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (clockVisible == false)
            {
                clockForm.Show();
                clockVisible = true;
                clockForm.Left = xPosition;
                clockForm.Top = yPosition;
                return;
            }

            clockForm.Hide();
            clockVisible = false;
        }

        private void btnSetX_Click(object sender, EventArgs e)
        {
            string xPositionInput = txtXPosition.Text;

            int parsedValue;
            bool parseSuccessful = int.TryParse(xPositionInput, out parsedValue);

            if (parseSuccessful == true)
            {
                if (parsedValue < 0 || parsedValue > 3840)
                {
                    return;
                }

                xPosition = parsedValue;
                clockForm.Left = xPosition;
                clockForm.Top = yPosition;
            }
        }

        private void btnSetY_Click(object sender, EventArgs e)
        {
            string yPositionInput = txtYPosition.Text;
            
            int parsedValue;
            bool parseSuccessful = int.TryParse(yPositionInput, out parsedValue);

            if (parseSuccessful == true)
            {
                if (parsedValue < 0 || parsedValue > 2160)
                {
                    return;
                }

                yPosition = parsedValue;
                clockForm.Left = xPosition;
                clockForm.Top = yPosition;
            }
        }
    }
}
