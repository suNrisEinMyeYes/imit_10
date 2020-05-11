using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class Form1 : Form
    {
        List<float> values = new List<float>();
        Random rnd;
        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
            generate();
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            var A = rnd.NextDouble();
            var k = 1;
            foreach (var value in values)
            {
                A -= value;
                if (A<=0)
                {
                    valueTxt.Text = k.ToString();
                    break;
                }
                k += 1;
            }
        }

        void generate()
        {
            values.Add(0.1f);
            values.Add(0.3f);
            values.Add(0.2f);
            values.Add(0.1f);
            values.Add(0.1f);
            values.Add(0.2f);

        }
    }
}
