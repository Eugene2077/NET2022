
/* author : Hongju Shin
 * ID:  100844220
 * Date: 27 Mar 2022
 * Subject: Lab5
 * Purpose: simple text editor project
 */


using System;
using System.Windows.Forms;

namespace LAB5
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
