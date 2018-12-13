using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingParameters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pgSqlConnection1.Open();
            MessageBox.Show(pgSqlConnection1.ServerVersion);
            pgSqlConnection1.Close();
        }
    }
}
