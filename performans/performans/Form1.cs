namespace performans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int y = 10;
        int x = 10;
        int a = 10;
        int sec = 0;

        Random rnd = new Random();
        Random rnd2 = new Random();
        Random rnd3 = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (y < 800)
            {
                y = y + 10;
            }
            else
            {
                timer3.Enabled = false;
                timer2.Enabled = false;
                timer1.Enabled = false;
                button4.Enabled = true;
                if (sec == 1)
                {
                    MessageBox.Show("FLASH KAZANDI");
                }
                else
                {
                    MessageBox.Show("Baþarýsýz Tahmin");
                }
            }

            pictureBox1.Location = new Point(y, 110);
            timer1.Interval = rnd.Next(1, 500);
            pictureBox1.Image = Properties.Resources.fl2;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (x < 800)
            {
                x = x + 10;
            }
            else
            {
                timer3.Enabled = false;
                timer2.Enabled = false;
                timer1.Enabled = false;
                button4.Enabled = true;
                if (sec == 2)
                {
                    MessageBox.Show("VENOM KAZANDI");
                }
                else
                {
                    MessageBox.Show("Baþarýsýz Tahmin");
                }
            }

            pictureBox2.Location = new Point(x, 260);
            timer2.Interval = rnd2.Next(1, 500);
            pictureBox2.Image = Properties.Resources.v2;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (a < 800)
            {
                a = a + 10;
            }
            else
            {
                timer3.Enabled = false;
                timer2.Enabled = false;
                timer1.Enabled = false;
                button4.Enabled = true;
                if (sec == 3)
                {
                    MessageBox.Show("JOKER KAZANDI");
                }
                else
                {
                    MessageBox.Show("Baþarýsýz Tahmin");
                }
            }

            pictureBox3.Location = new Point(a, 410);
            timer3.Interval = rnd3.Next(1, 500);
            pictureBox3.Image = Properties.Resources.j64;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer3.Enabled = true;
            timer2.Enabled = true;
            timer1.Enabled = true;
            sec = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer3.Enabled = true;
            timer2.Enabled = true;
            timer1.Enabled = true;
            sec = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = false;
            button4.Enabled = false;
            timer3.Enabled = true;
            timer2.Enabled = true;
            timer1.Enabled = true;
            sec = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            y = 10;
            x = 10;
            a = 10;
            sec = 0;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            pictureBox1.Image = Properties.Resources.fl1;
            pictureBox2.Image = Properties.Resources.v1;
            pictureBox3.Image = Properties.Resources.j63;
            pictureBox1.Location = new Point(y, 110);
            pictureBox2.Location = new Point(x, 250);
            pictureBox3.Location = new Point(a, 410);
        }

        
    }
}