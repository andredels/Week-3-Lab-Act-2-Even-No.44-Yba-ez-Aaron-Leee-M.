namespace Week_3_Lab_Act_2__Even_No._44__Ybañez__Aaron_Leee_M_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Panel> listpanel = new List<Panel>();
        int index;

        private void Form1_Load(object sender, EventArgs e)
        {
            listpanel.Add(panel1);
            listpanel.Add(panel2);
            listpanel[index].BringToFront();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            if (index < listpanel.Count - 1)
            {
                listpanel[++index].BringToFront();
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                listpanel[--index].BringToFront();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index < listpanel.Count - 1)
            {
                listpanel[++index].BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                listpanel[--index].BringToFront();
            }
        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
