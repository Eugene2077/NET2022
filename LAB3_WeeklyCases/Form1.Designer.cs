
namespace LAB3_WeeklyCases
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCases = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblRegion1 = new System.Windows.Forms.Label();
            this.lblRegion2 = new System.Windows.Forms.Label();
            this.lblRegion3 = new System.Windows.Forms.Label();
            this.lblOut1 = new System.Windows.Forms.Label();
            this.lblOut2 = new System.Windows.Forms.Label();
            this.lblOut3 = new System.Windows.Forms.Label();
            this.lblOutTotal = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtRegion1 = new System.Windows.Forms.TextBox();
            this.txtRegion2 = new System.Windows.Forms.TextBox();
            this.txtRegion3 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblCases
            // 
            this.lblCases.AutoSize = true;
            this.lblCases.Location = new System.Drawing.Point(12, 18);
            this.lblCases.Name = "lblCases";
            this.lblCases.Size = new System.Drawing.Size(40, 15);
            this.lblCases.TabIndex = 0;
            this.lblCases.Text = "Cases:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(58, 14);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(87, 23);
            this.txtInput.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtInput, "Daily cases input textbox");
            // 
            // lblRegion1
            // 
            this.lblRegion1.AutoSize = true;
            this.lblRegion1.Location = new System.Drawing.Point(47, 57);
            this.lblRegion1.Name = "lblRegion1";
            this.lblRegion1.Size = new System.Drawing.Size(53, 15);
            this.lblRegion1.TabIndex = 2;
            this.lblRegion1.Text = "Region 1";
            this.toolTip1.SetToolTip(this.lblRegion1, "Daily cases lable in Region1");
            // 
            // lblRegion2
            // 
            this.lblRegion2.AutoSize = true;
            this.lblRegion2.Location = new System.Drawing.Point(172, 57);
            this.lblRegion2.Name = "lblRegion2";
            this.lblRegion2.Size = new System.Drawing.Size(50, 15);
            this.lblRegion2.TabIndex = 4;
            this.lblRegion2.Text = "Region2";
            this.toolTip1.SetToolTip(this.lblRegion2, "Daily cases lable in Region2");
            // 
            // lblRegion3
            // 
            this.lblRegion3.AutoSize = true;
            this.lblRegion3.Location = new System.Drawing.Point(294, 57);
            this.lblRegion3.Name = "lblRegion3";
            this.lblRegion3.Size = new System.Drawing.Size(50, 15);
            this.lblRegion3.TabIndex = 6;
            this.lblRegion3.Text = "Region3";
            this.toolTip1.SetToolTip(this.lblRegion3, "Daily cases lable in Region3");
            // 
            // lblOut1
            // 
            this.lblOut1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOut1.Location = new System.Drawing.Point(19, 224);
            this.lblOut1.Name = "lblOut1";
            this.lblOut1.Size = new System.Drawing.Size(115, 27);
            this.lblOut1.TabIndex = 8;
            this.lblOut1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblOut1, "Weekly Average Region1");
            // 
            // lblOut2
            // 
            this.lblOut2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOut2.Location = new System.Drawing.Point(144, 224);
            this.lblOut2.Name = "lblOut2";
            this.lblOut2.Size = new System.Drawing.Size(115, 27);
            this.lblOut2.TabIndex = 9;
            this.lblOut2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblOut2, "Weekly Average Region2");
            // 
            // lblOut3
            // 
            this.lblOut3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOut3.Location = new System.Drawing.Point(269, 224);
            this.lblOut3.Name = "lblOut3";
            this.lblOut3.Size = new System.Drawing.Size(116, 27);
            this.lblOut3.TabIndex = 10;
            this.lblOut3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblOut3, "Weekly Average Region3");
            // 
            // lblOutTotal
            // 
            this.lblOutTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutTotal.Location = new System.Drawing.Point(19, 263);
            this.lblOutTotal.Name = "lblOutTotal";
            this.lblOutTotal.Size = new System.Drawing.Size(366, 29);
            this.lblOutTotal.TabIndex = 11;
            this.lblOutTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblOutTotal, "Total Average cases in this week");
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(19, 306);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(115, 28);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.btnEnter, "Enter button");
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(144, 306);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(115, 28);
            this.BtnReset.TabIndex = 13;
            this.BtnReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.BtnReset, "Reset button");
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(269, 306);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 28);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit button");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtRegion1
            // 
            this.txtRegion1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtRegion1.Location = new System.Drawing.Point(30, 81);
            this.txtRegion1.Multiline = true;
            this.txtRegion1.Name = "txtRegion1";
            this.txtRegion1.ReadOnly = true;
            this.txtRegion1.Size = new System.Drawing.Size(90, 130);
            this.txtRegion1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtRegion1, "Daily cases in Region 1");
            // 
            // txtRegion2
            // 
            this.txtRegion2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtRegion2.Location = new System.Drawing.Point(155, 81);
            this.txtRegion2.Multiline = true;
            this.txtRegion2.Name = "txtRegion2";
            this.txtRegion2.ReadOnly = true;
            this.txtRegion2.Size = new System.Drawing.Size(90, 130);
            this.txtRegion2.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtRegion2, "Daily cases in Region2");
            // 
            // txtRegion3
            // 
            this.txtRegion3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRegion3.Location = new System.Drawing.Point(280, 81);
            this.txtRegion3.Multiline = true;
            this.txtRegion3.Name = "txtRegion3";
            this.txtRegion3.ReadOnly = true;
            this.txtRegion3.Size = new System.Drawing.Size(90, 130);
            this.txtRegion3.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtRegion3, "Daily cases in Region3");
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnReset;
            this.ClientSize = new System.Drawing.Size(404, 354);
            this.Controls.Add(this.txtRegion3);
            this.Controls.Add(this.txtRegion2);
            this.Controls.Add(this.txtRegion1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblOutTotal);
            this.Controls.Add(this.lblOut3);
            this.Controls.Add(this.lblOut2);
            this.Controls.Add(this.lblOut1);
            this.Controls.Add(this.lblRegion3);
            this.Controls.Add(this.lblRegion2);
            this.Controls.Add(this.lblRegion1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblCases);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Weekly Units by Region";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCases;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblRegion1;
        private System.Windows.Forms.Label lblRegion2;
        private System.Windows.Forms.Label lblRegion3;
        private System.Windows.Forms.Label lblOut1;
        private System.Windows.Forms.Label lblOut2;
        private System.Windows.Forms.Label lblOut3;
        private System.Windows.Forms.Label lblOutTotal;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtRegion1;
        private System.Windows.Forms.TextBox txtRegion2;
        private System.Windows.Forms.TextBox txtRegion3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

