using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class GeneratePasswordForm : Form
    {
        public GeneratePasswordForm()
        {
            InitializeComponent();
        }


        public int GetNbChar()
        {
            return (int)numUDNbChar.Value;
        }

        public int GetNbNum()
        {
            return (int)numUDNbNum.Value;
        }

        public int GetNbSym()
        {
            return (int)numUDNbSym.Value;
        }

    }
}
