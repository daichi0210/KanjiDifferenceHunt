namespace KanjiDifferenceHunt
{
    public partial class FormGame : Form
    {
        //string correctText = "荻";
        //string mistakeText = "萩";
        string correctText = "崎";
        string mistakeText = "﨑";
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
                nowTime = nowTime + 10; // ペナルティー
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            textHunt.Text = correctText;    // 探す文字を表示
            Random rnd = new Random();  // 乱数を生成するためのインスタンスを生成
            int randomResult = rnd.Next(25);    // 0～24の乱数を取得

            // splitContainerの株のPanel2に乗っている
            // ButtonのTextをすべて間違いの文字にする
            for (int i = 0; i < splitContainer1.Panel2.Controls.Count; i++)
            {
                splitContainer1.Panel2.Controls[i].Text = mistakeText;
            }

            // ランダムで1つだけ正解の文字にする
            splitContainer1.Panel2.Controls[randomResult].Text = correctText;

            // タイマースタート
            nowTime = 0;    // タイマーの初期化
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nowTime = nowTime + 0.02;
            textTimer.Text = nowTime.ToString("0.00");
        }
    }
}
