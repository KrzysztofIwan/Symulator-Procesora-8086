using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace symulator_procesora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // RANDOM VALUE
        private void button1_Click(object sender, EventArgs e)
        {
            DaneAL.Text = RandomValueGenerator();
            DaneAH.Text = RandomValueGenerator();
            DaneBL.Text = RandomValueGenerator();
            DaneBH.Text = RandomValueGenerator();
            DaneCL.Text = RandomValueGenerator();
            DaneCH.Text = RandomValueGenerator();
            DaneDL.Text = RandomValueGenerator();
            DaneDH.Text = RandomValueGenerator();
        }
        // CLEAN
        private void button2_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        // SYMULATOR
        private void button3_Click(object sender, EventArgs e)
        {
            string hex1 = BinToHex(DaneAL.Text);
            string hex2 = BinToHex(DaneAH.Text);
            string hex3 = BinToHex(DaneBL.Text);
            string hex4 = BinToHex(DaneBH.Text);
            string hex5 = BinToHex(DaneCL.Text);
            string hex6 = BinToHex(DaneCH.Text);
            string hex7 = BinToHex(DaneDL.Text);
            string hex8 = BinToHex(DaneDH.Text);
            WynikAL.Text = hex1;
            WynikAH.Text = hex2;
            WynikBL.Text = hex3;
            WynikBH.Text = hex4;
            WynikCL.Text = hex5;
            WynikCH.Text = hex6;
            WynikDL.Text = hex7;
            WynikDH.Text = hex8;
        }
        // EXECUTE
        private void button5_Click(object sender, EventArgs e)
        {
            // INC ---------------------------------
            if (comboBoxOperation.Text == "INC")
            {
                if (comboBoxFrom.Text == "AL")
                {
                    WynikAL.Text = INC(WynikAL.Text);
                }
                else if (comboBoxFrom.Text == "AH")
                {
                    WynikAH.Text = INC(WynikAH.Text);
                }
                else if (comboBoxFrom.Text == "BL")
                {
                    WynikBL.Text = INC(WynikBL.Text);
                }
                else if (comboBoxFrom.Text == "BH")
                {
                    WynikBH.Text = INC(WynikBH.Text);
                }
                else if (comboBoxFrom.Text == "CL")
                {
                    WynikCL.Text = INC(WynikCL.Text);
                }
                else if (comboBoxFrom.Text == "CH")
                {
                    WynikCH.Text = INC(WynikCH.Text);
                }
                else if (comboBoxFrom.Text == "DL")
                {
                    WynikDL.Text = INC(WynikDL.Text);
                }
                else if (comboBoxFrom.Text == "DH")
                {
                    WynikDH.Text = INC(WynikDH.Text);
                }
                    
            }
            // DEC --------------------------------------
            else if (comboBoxOperation.Text == "DEC")
            {
                if (comboBoxFrom.Text == "AL")
                {
                    WynikAL.Text = DEC(WynikAL.Text);
                }
                else if (comboBoxFrom.Text == "AH")
                {
                    WynikAH.Text =DEC(WynikAH.Text);
                }
                else if (comboBoxFrom.Text == "BL")
                {
                    WynikBL.Text = DEC(WynikBL.Text);
                }
                else if (comboBoxFrom.Text == "BH")
                {
                    WynikBH.Text = DEC(WynikBH.Text);
                }
                else if (comboBoxFrom.Text == "CL")
                {
                    WynikCL.Text = DEC(WynikCL.Text);
                }
                else if (comboBoxFrom.Text == "CH")
                {
                    WynikCH.Text = DEC(WynikCH.Text);
                }
                else if (comboBoxFrom.Text == "DL")
                {
                    WynikDL.Text = DEC(WynikDL.Text);
                }
                else if (comboBoxFrom.Text == "DH")
                {
                    WynikDH.Text = DEC(WynikDH.Text);
                }
            }
            // NOT ---------------------------------------
            else if (comboBoxOperation.Text == "NOT")
            {
                if (comboBoxFrom.Text == "AL")
                {
                    WynikAL.Text = NOT(WynikAL.Text);
                }
                else if (comboBoxFrom.Text == "AH")
                {
                    WynikAH.Text = NOT(WynikAH.Text);
                }
                else if (comboBoxFrom.Text == "BL")
                {
                    WynikBL.Text = NOT(WynikBL.Text);
                }
                else if (comboBoxFrom.Text == "BH")
                {
                    WynikBH.Text = NOT(WynikBH.Text);
                }
                else if (comboBoxFrom.Text == "CL")
                {
                    WynikCL.Text = NOT(WynikCL.Text);
                }
                else if (comboBoxFrom.Text == "CH")
                {
                    WynikCH.Text = NOT(WynikCH.Text);
                }
                else if (comboBoxFrom.Text == "DL")
                {
                    WynikDL.Text = NOT(WynikDL.Text);
                }
                else if (comboBoxFrom.Text == "DH")
                {
                    WynikDH.Text = NOT(WynikDH.Text);
                }
            }
            // NEG -------------------------------------
            else if (comboBoxOperation.Text == "NEG")
            {
                if (comboBoxFrom.Text == "AL")
                {
                    
                    WynikAL.Text =NEG(WynikAL.Text);
                }
                else if (comboBoxFrom.Text == "AH")
                {
                    WynikAH.Text = NEG(WynikAH.Text);
                }
                else if (comboBoxFrom.Text == "BL")
                {
                    WynikBL.Text = NEG(WynikBL.Text);
                }
                else if (comboBoxFrom.Text == "BH")
                {
                    WynikBH.Text = NEG(WynikBH.Text);
                }
                else if (comboBoxFrom.Text == "CL")
                {
                    WynikCL.Text = NEG(WynikCL.Text);
                }
                else if (comboBoxFrom.Text == "CH")
                {
                    WynikCH.Text = NEG(WynikCH.Text);
                }
                else if (comboBoxFrom.Text == "DL")
                {
                    WynikDL.Text = NEG(WynikDL.Text);
                }
                else if (comboBoxFrom.Text == "DH")
                {
                    WynikDH.Text = NEG(WynikDH.Text);
                }
            }
        }
        //-----------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            // idk what it is XD
        }
        //-----------------------------------
        public string BinToHex(string value)
        {
            int _decimal = 0;
            int base1 = 1;
            int binary = int.Parse(value);
            while (binary > 0)
            {
                int reminder = binary % 10;
                binary = binary / 10;
                _decimal += reminder * base1;
                base1 = base1 * 2;
            }
            string done = String.Format("{0:X}", _decimal);
            return done;
        }
        public string RandomValueGenerator()
        {
            Random rand = new Random();
            string wynik = Convert.ToString(rand.Next(0, 2)) + Convert.ToString(rand.Next(0, 2)) + Convert.ToString(rand.Next(0, 2)) + Convert.ToString(rand.Next(0, 2));
            return wynik;
        }
        public string INC(string value)
        {
            int decValue = Convert.ToInt32(value, 16) + 1;
            string inc = String.Format("{0:X}", decValue);
            return inc;
        }
        public string DEC(string value)
        {
            int decValue = Convert.ToInt32(value, 16) - 1;
            string dec = String.Format("{0:X}", decValue);
            return dec;
        }
        public string NOT(string value)
        {
            string decimal_ = Convert.ToString(Convert.ToInt32(value, 16), 10);
            string binary = Convert.ToString(Convert.ToInt32(decimal_, 10), 2);
            int pom = binary.Length;
            int x = 0;
            char[] arr = new char[pom];
            foreach(char c in binary)
            {
                if(c == '0')
                {
                    arr[x] = '1';
                }
                else
                {
                    arr[x] = '0';
                }
                x++;
            }
            string bin_number = "";
            foreach(char b in arr)
            {
                bin_number += b;
            }
            return Convert.ToString(Convert.ToInt32(bin_number,2),16);

        }
        public string NEG(string value)
        {
            string not = NOT(value);
            string decimal_ = Convert.ToString(Convert.ToInt32(not, 16), 10);
            string neg = INC(decimal_);
            return neg;
        }
    }
}
