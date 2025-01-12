
namespace YourBasicCalculator
{
    public partial class YourBasicCalculator : Form
    {
        public string operation = "";
        public float numberOne = 0;
        public float numberTwo = 0;
        public float answer = 0;
        public int numberClicked = 0;

        public void numberClicker()
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = numberClicked.ToString();
            }
            else
            {
                textBox1.Text = textBox1.Text + numberClicked.ToString();
            }
        }

        public void mathingPartOne() 
        {
            numberOne = float.Parse(textBox1.Text);
            textBox1.Text = "0";
            label1.Text = "In Memory: ";
            label2.Text = numberOne.ToString();
        }

        public YourBasicCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //CE
            textBox1.Text = "0";
            label1.Text = "";
            label2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {   //C
            textBox1.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {   //Back (delete)
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text.Length <= 0)
            {
                textBox1.Text = "0";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {   //0
            numberClicked = 0;
            numberClicker();
        }

        private void button13_Click(object sender, EventArgs e)
        {   //1
            numberClicked = 1;
            numberClicker();
        }

        private void button14_Click(object sender, EventArgs e)
        {   //2
            numberClicked = 2;
            numberClicker();
        }

        private void button15_Click(object sender, EventArgs e)
        {   //3
            numberClicked = 3;
            numberClicker();
        }

        private void button9_Click(object sender, EventArgs e)
        {   //4
            numberClicked = 4;
            numberClicker();
        }

        private void button10_Click(object sender, EventArgs e)
        {   //5
            numberClicked = 5;
            numberClicker();
        }

        private void button11_Click(object sender, EventArgs e)
        {   //6
            numberClicked = 6;
            numberClicker();
        }

        private void button5_Click(object sender, EventArgs e)
        {   //7
            numberClicked = 7;
            numberClicker();
        }

        private void button6_Click(object sender, EventArgs e)
        {   //8
            numberClicked = 8;
            numberClicker();
        }

        private void button7_Click(object sender, EventArgs e)
        {   //9
            numberClicked = 9;
            numberClicker();
        }

        private void button19_Click(object sender, EventArgs e)
        {   //.
            textBox1.Text = textBox1.Text + ".";
        }

        //=====DO SOME MATH!======================================

        private void button16_Click(object sender, EventArgs e)
        {   //Add
            mathingPartOne();
            operation = "Add";
        }
        private void button12_Click(object sender, EventArgs e)
        {   //Subtract
            mathingPartOne();
            operation = "Subtract";
        }
        private void button8_Click(object sender, EventArgs e)
        {   //Multiply
            mathingPartOne();
            operation = "Multiply";
        }
        private void button4_Click(object sender, EventArgs e)
        {   //Divide
            mathingPartOne();
            operation = "Divide";
        }
        private void button17_Click(object sender, EventArgs e)
        {   //+- (change sign: positive/negative)
            if (textBox1.Text[0] == '-') 
            {
                textBox1.Text = textBox1.Text.Remove(0, 1);
            }
            else
            {
                textBox1.Text = "-" + textBox1.Text;
            }
        }

        //DO THE MATH!
        private void button20_Click(object sender, EventArgs e)
        {   //Equals

            numberTwo = float.Parse(textBox1.Text);

            switch (operation) 
            {
                case "Add":
                    answer = numberOne + numberTwo;
                    break;

                case "Subtract":
                    answer = numberOne - numberTwo;
                    break;

                case "Multiply":
                    answer = numberOne * numberTwo;
                    break;

                case "Divide":
                    answer = numberOne / numberTwo;
                    break;
            }

            textBox1.Text = answer.ToString();

        }
    }
}
