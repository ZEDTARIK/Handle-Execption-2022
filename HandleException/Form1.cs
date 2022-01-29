namespace HandleException
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = 0;
            try
            {
                 result = Convert.ToInt16(textBox1.Text) / Convert.ToInt16(textBox2.Text);

            }
            catch (Exception ex)
            {
                throw new Exception("Can divide by Zero ! " +  ex.Message);

                // MessageBox.Show(ex.Message);
            } 
            finally 
            {
                MessageBox.Show(result.ToString());
            }
        }
    }
}