namespace KanjiDifferenceHunt
{
    public partial class FormGame : Form
    {
        //string correctText = "¬";
        //string mistakeText = "";
        string correctText = "θ";
        string mistakeText = "ϊ±";
        double nowTime;

        public FormGame()
        {
            InitializeComponent();
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == correctText)
            {
                timer1.Stop();
            }
            else
            {
                nowTime = nowTime + 10; // yieB[
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            textHunt.Text = correctText;    // T·Άπ\¦
            Random rnd = new Random();  // πΆ¬·ι½ίΜCX^XπΆ¬
            int randomResult = rnd.Next(25);    // 0`24ΜπζΎ

            // splitContainerΜΜPanel2ΙζΑΔ’ι
            // ButtonΜTextπ·ΧΔΤα’ΜΆΙ·ι
            for (int i = 0; i < splitContainer1.Panel2.Controls.Count; i++)
            {
                splitContainer1.Panel2.Controls[i].Text = mistakeText;
            }

            // _Ε1ΒΎ―³πΜΆΙ·ι
            splitContainer1.Panel2.Controls[randomResult].Text = correctText;

            // ^C}[X^[g
            nowTime = 0;    // ^C}[Μϊ»
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nowTime = nowTime + 0.02;
            textTimer.Text = nowTime.ToString("0.00");
        }
    }
}
