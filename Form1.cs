using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        string operation = "";
        bool Is_operation=false;
        double celsius, fehrenheit;
        char radioCheck;
        public Form1()
        {
            InitializeComponent();
        }

        private void tempToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Width = 900;
            groupBox1.Visible = true;
            groupBox2.Visible =true;
            groupBox3.Visible =false;
            groupBox3.Location = new Point(600, 48);
            groupBox3.Width = 400;
            groupBox3.Height = 464;


        }

        private void button30_Click(object sender, EventArgs e)
        {

            double sq = double.Parse(textBox1.Text);
            label3.Text = System.Convert.ToString("Sqrt" + "(" + (textBox1.Text + ")"));
            sq = Math.Sqrt(sq);
            textBox1.Text = System.Convert.ToString(sq);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(num, 16);
        }

        private void button19_Click(object sender, EventArgs e)
        {

            double tan = double.Parse(textBox1.Text);
            label3.Text = System.Convert.ToString("Tan" + "(" + (textBox1.Text + ")"));
            tan = Math.Tan(tan);
            textBox1.Text = System.Convert.ToString(tan);
        }

        private void button20_Click(object sender, EventArgs e)
        {

            double tenh = double.Parse(textBox1.Text);
            label3.Text = System.Convert.ToString("Tenh" + "(" + (textBox1.Text + ")"));
            tenh = Math.Tanh(tenh);
            textBox1.Text = System.Convert.ToString(tenh);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox1.Text);
            label3.Text = System.Convert.ToString(("1 / "+textBox1.Text ));
            num = 1/num;
            textBox1.Text = System.Convert.ToString(num);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int num=int.Parse(textBox1.Text);   
            textBox1.Text=System.Convert.ToString(num,2);
        }

        private void button23_Click(object sender, EventArgs e)
        {

            double cos = double.Parse(textBox1.Text);
            label3.Text = System.Convert.ToString("Cos" + "(" + (textBox1.Text + ")"));
            cos = Math.Cos(cos);
            textBox1.Text = System.Convert.ToString(cos);
        }

        private void button24_Click(object sender, EventArgs e)
        {

            double cosh = double.Parse(textBox1.Text);
            label3.Text = System.Convert.ToString("cosh" + "(" + (textBox1.Text + ")"));
            cosh = Math.Cosh(cosh);
            textBox1.Text = System.Convert.ToString(cosh);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double cube = double.Parse(textBox1.Text);
            label3.Text = System.Convert.ToString((textBox1.Text + "^ 3"));
            cube = Math.Pow(cube, 3);
            textBox1.Text = System.Convert.ToString(cube);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(num);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double sin = double.Parse(textBox1.Text);
            label3.Text = System.Convert.ToString("sin" + "(" + (textBox1.Text + ")"));
            sin = Math.Sin(sin);
            textBox1.Text = System.Convert.ToString(sin);
        }

        private void button28_Click(object sender, EventArgs e)
        {

            double sinh = double.Parse(textBox1.Text);
            label3.Text = System.Convert.ToString("Sinh" + "(" + (textBox1.Text + ")"));
            sinh = Math.Sinh(sinh);
            textBox1.Text = System.Convert.ToString(sinh);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double quad= double.Parse(textBox1.Text);
            label3.Text = System.Convert.ToString(   (textBox1.Text + "^ 2"));
            quad = Math.Pow(quad,2);
            textBox1.Text = System.Convert.ToString(quad);
        }

      

        private void button31_Click(object sender, EventArgs e)
        {
            double log = double.Parse(textBox1.Text);
            label3.Text = System.Convert.ToString("log" + "(" + (textBox1.Text + ")"));
            log = Math.Log10(log);
            textBox1.Text=System.Convert.ToString(log); 

        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text=Math.PI.ToString();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 257;
           
        }

        private void scientaficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 540;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 257;
            
        }

        

        private void multiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 900;
            groupBox1.Visible=false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox3.Location =new Point( 600,48);
            groupBox3.Width= 324;
            groupBox3.Height = 464;




        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (Is_operation))
                textBox1.Text = "";
            Is_operation= false;    
            Button num = (Button)sender;
            if (num.Text==".")
            {
                if(!textBox1.Text.Contains("."))
                    textBox1.Text=textBox1.Text+num.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + num.Text;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length> 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1,1);
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button num= (Button)sender; 
            operation=num.Text;
            result=double.Parse(textBox1.Text);
            textBox1.Text = "";
            label3.Text=System.Convert.ToString(result)+""+operation;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            switch(operation)
            {
                case "+":
                    textBox1.Text=(result+double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result -double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;
                case "Mod":
                    textBox1.Text = (result % double.Parse(textBox1.Text)).ToString();
                    break;
                case "Exp":
                    double i=double.Parse(textBox1.Text);
                    double j= (result);
                    textBox1.Text=Math.Exp(i*Math.Log(j*4)).ToString();
                    break;

            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(num, 8);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            double a= double.Parse(textBox1.Text)/100;  
            textBox1.Text=a.ToString(); 
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double ln = double.Parse(textBox1.Text);
            label3.Text = System.Convert.ToString("ln" + "(" + (textBox1.Text + ")"));
            ln = Math.Log(ln);
            textBox1.Text = System.Convert.ToString(ln);
        }

        private void rdCelsius_CheckedChanged(object sender, EventArgs e)
        {
            radioCheck = 'C';
        }

        private void raFehrenheit_CheckedChanged(object sender, EventArgs e)
        {
            radioCheck = 'F';

        }

        private void button41_Click(object sender, EventArgs e)
        {
            switch (radioCheck)
            {
                case 'C':
                    fehrenheit=double.Parse(textBox2.Text);
                    textBox3.Text = ((((fehrenheit - 32) * 5) / 9).ToString());
                    break;
                case 'F':
                    celsius = double.Parse(textBox2.Text);
                    textBox3.Text = ((((9*celsius) / 5) +32).ToString());
                    break;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            raFehrenheit.Checked = false;   
            rdCelsius.Checked = false;  

        }

        private void button43_Click(object sender, EventArgs e)
        {
            int num=Convert.ToInt32(textBox4.Text);
            for(int i = 1; i < 13; i++)
            {
                listBox1.Items.Add(i+" x "+num+ " = "+(num*i));
            }

        }

        private void button44_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            listBox1.Items.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sign = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(-1 * sign);
        }
    }
}
