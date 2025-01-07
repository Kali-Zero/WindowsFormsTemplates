namespace WindowsFormsTemplates
{
    public partial class PercentageCalculator : Form
    {
        public PercentageCalculator()
        {
            InitializeComponent();
        }

        //What is _ % of _ ?
        public void button1_Click(object sender, EventArgs e) 
        {
            float answer1 = 0;
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]") ||
                System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
            {
                textBox1.Text = "Invalid Entries";
            }
            else 
            {
                float box4 = float.Parse(textBox4.Text);
                float box5 = float.Parse(textBox5.Text);
                answer1 = box5 / 100;
                answer1 = answer1 * box4;
                textBox1.Text = answer1.ToString();
            }
        }

        // _ is what percentage of _ ?
        public void button2_Click(object sender, EventArgs e) 
        {
            float answer2 = 0;
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "[^0-9]") ||
                System.Text.RegularExpressions.Regex.IsMatch(textBox7.Text, "[^0-9]"))
            {
                textBox2.Text = "Invalid Entries";
            }
            else
            {
                float box6 = float.Parse(textBox6.Text);
                float box7 = float.Parse(textBox7.Text);
                answer2 = box6 / box7;
                answer2 = answer2 * 100;
                textBox2.Text = answer2.ToString();
            }
        }

        // What is the percentage increase/decrease from _ to _ ?
        public void button3_Click(object sender, EventArgs e)
        {
            float answer3 = 0;
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "[^0-9]") ||
                System.Text.RegularExpressions.Regex.IsMatch(textBox7.Text, "[^0-9]"))
            {
                textBox3.Text = "Invalid Entries";
            }
            else 
            {
                float box8 = float.Parse(textBox8.Text);
                float box9 = float.Parse(textBox9.Text);

                //If it's an increase
                if (box8 > box9) 
                {
                    answer3 = box8 - box9;
                }
                //If it's a decrease
                else 
                {
                    answer3 = box9 - box8;
                }
                answer3 = answer3 / box8;
                answer3 = answer3 * 100;
                textBox3.Text = "-" + answer3.ToString();
            }
        }

        //Clear All Button
        public void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }
    }
}
