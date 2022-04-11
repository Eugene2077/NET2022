/*
 * Name: Hongju(Eugene) Shin
 * Program: NETD-2202-05
 * Created on January 20, 2022, 7:22 PM
 * Description: simple app for practicing windows forms
*/
using System;
using System.Windows.Forms;

namespace ICE01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yes, Hongju Shin is awesome, aren't they!");
            System.Windows.Forms.Application.Exit();
        }

        private void mouse_hover(object sender, EventArgs e)
        {

            var mousecursor = this.PointToClient(Cursor.Position);  // get the mouse position in the app
    
            if (mousecursor.X > 100 && mousecursor.X <175)  // if the mouse is the original location of the button
            {
                btnNo.Left = btnNo.Left + 100;  // move the button
        
            }
            else                                // if the button is not there
            { 
                btnNo.Left = btnNo.Left - 100;  // back to original location
               
            }
            
        }

    }
}
