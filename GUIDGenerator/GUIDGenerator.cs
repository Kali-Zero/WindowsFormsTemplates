
namespace GUIDGenerator
{
    public partial class GUIDGenerator : Form
    {
        string braket1 = "";
        string braket2 = "";
        string quotes = "";
        string commas = "";
        List<string> List_o_GUIDS = new List<string>();

        public GUIDGenerator()
        {
            InitializeComponent();
        }

        //Base64 cannot have hyphens
        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox6.Checked = false;
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            List_o_GUIDS.Clear();
            if (checkBox2.Checked) //Brackets
            {
                braket1 = "{";
                braket2 = "}";
            }
            else
            {
                braket1 = "";
                braket2 = "";
            }
            if (checkBox4.Checked) //Quotes
            {
                quotes = "\"";
            }
            else
            {
                quotes = "";
            }
            if (checkBox5.Checked) //Commas
            {
                commas = ",";
            }
            else
            {
                commas = "";
            }

            //Make sure there are only numbers in the GUID count selector
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                textBox1.Text = "Invalid Selection - Numbers only please.";
            }
            else
            {
                int GUIDcount = int.Parse(textBox2.Text);
                if (GUIDcount <= 1000)
                {
                    for (int i = 0; i < GUIDcount; i++)
                    {

                        if (checkBox6.Checked) //Base64
                        {
                            List_o_GUIDS.Add(quotes + braket1 + Convert.ToBase64String﻿﻿﻿(Guid.NewGuid﻿﻿﻿()
                                .ToByteArray﻿﻿﻿()).Substring﻿﻿﻿(0, 22).Replace﻿﻿﻿("﻿/﻿", "﻿_﻿").Replace﻿﻿﻿("﻿+﻿", "﻿-﻿") + "=="
                                + braket2 + quotes + commas);
                        }
                        else if (checkBox1.Checked) //Hyphens
                        {
                            checkBox1.Checked = !checkBox6.Checked;
                            List_o_GUIDS.Add(quotes + braket1 + Guid.NewGuid().ToString() + braket2 + quotes + commas);
                        }
                        else
                        {
                            List_o_GUIDS.Add(quotes + braket1 + Guid.NewGuid().ToString("N") + braket2 + quotes + commas);
                        }

                        if (checkBox3.Checked) //Uppercase
                        {
                            textBox1.Text = string.Join(Environment.NewLine, List_o_GUIDS).ToUpper();
                        }
                        else
                        {
                            textBox1.Text = string.Join(Environment.NewLine, List_o_GUIDS);
                        }
                    }
                }
                //I could probably make this bigger, 1000 is purely arbitary.
                else if (GUIDcount > 1000)
                {
                    textBox1.Text = "Invalid Selection - Too many GUIDS!";
                }
            }
        }

        //Does not work? But....why?
        public void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBox1.Text);
        }
    }
}