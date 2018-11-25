using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegat3
{
    public partial class Form1 : Form
    {
        Amy amy = new Amy();
        Suz suz = new Suz();
        GetSecretIngredient secret = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void UseIngrediens_Click(object sender, EventArgs e)
        {
            if (secret != null)
                Console.WriteLine("Dodam " + secret((int)amount.Value));
            else
                Console.WriteLine("Brak sekretnego składnika");
        }

        private void getSuz_Click(object sender, EventArgs e)
        {
            secret = new GetSecretIngredient(suz.MySecretIngredient);
        }

        private void getAmy_Click(object sender, EventArgs e)
        {
            secret = new GetSecretIngredient(amy.MySecretIngredient);
        }
    }
}
