using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcClient
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool success = int.TryParse(input.Text, out int number);
            if (success)
            {
                CalcServiceReference.CalcServiceClient obj = new CalcServiceReference.CalcServiceClient("NetTcpBinding_ICalcService");
                string res = obj.DecimalToBinary(number);
                result.Text = $"Result: {res}";
            }
        }
    }
}
