
namespace ICE4
{
    partial class ShowCars
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
            this.lblselectCar = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblColorlbl = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvShowCar = new System.Windows.Forms.DataGridView();
            this.dtpManufactured = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.nudSerial = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSerial)).BeginInit();
            this.SuspendLayout();
            // 
            // lblselectCar
            // 
            this.lblselectCar.AutoSize = true;
            this.lblselectCar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblselectCar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblselectCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblselectCar.Location = new System.Drawing.Point(186, 8);
            this.lblselectCar.Name = "lblselectCar";
            this.lblselectCar.Size = new System.Drawing.Size(173, 21);
            this.lblselectCar.TabIndex = 0;
            this.lblselectCar.Text = "Select the Cars to Show";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBrand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBrand.Location = new System.Drawing.Point(61, 92);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(38, 15);
            this.lblBrand.TabIndex = 3;
            this.lblBrand.Text = "Brand";
            this.toolTip1.SetToolTip(this.lblBrand, "Brand");
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(62, 155);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(163, 23);
            this.txtModel.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtModel, "input the model of the car");
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.Color.Maroon;
            this.lblModel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModel.Location = new System.Drawing.Point(61, 137);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(41, 15);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Model";
            this.toolTip1.SetToolTip(this.lblModel, "model");
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(357, 79);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(64, 54);
            this.btnColor.TabIndex = 11;
            this.btnColor.Text = "Set";
            this.toolTip1.SetToolTip(this.btnColor, "Click to select the color");
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Red;
            this.lblColor.Location = new System.Drawing.Point(275, 79);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(66, 54);
            this.lblColor.TabIndex = 10;
            this.toolTip1.SetToolTip(this.lblColor, "Selected color");
            // 
            // lblColorlbl
            // 
            this.lblColorlbl.AutoSize = true;
            this.lblColorlbl.BackColor = System.Drawing.Color.Black;
            this.lblColorlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColorlbl.Location = new System.Drawing.Point(268, 50);
            this.lblColorlbl.Name = "lblColorlbl";
            this.lblColorlbl.Size = new System.Drawing.Size(73, 15);
            this.lblColorlbl.TabIndex = 9;
            this.lblColorlbl.Text = "Model Color";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(275, 173);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 50);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.toolTip1.SetToolTip(this.btnSave, "Save the selection");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(357, 173);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(64, 50);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.toolTip1.SetToolTip(this.btnReset, "reset the input fields");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvShowCar
            // 
            this.dgvShowCar.AllowUserToAddRows = false;
            this.dgvShowCar.AllowUserToDeleteRows = false;
            this.dgvShowCar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowCar.BackgroundColor = System.Drawing.Color.Black;
            this.dgvShowCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowCar.Location = new System.Drawing.Point(45, 256);
            this.dgvShowCar.MultiSelect = false;
            this.dgvShowCar.Name = "dgvShowCar";
            this.dgvShowCar.ReadOnly = true;
            this.dgvShowCar.RowHeadersVisible = false;
            this.dgvShowCar.RowTemplate.Height = 25;
            this.dgvShowCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowCar.ShowEditingIcon = false;
            this.dgvShowCar.Size = new System.Drawing.Size(475, 267);
            this.dgvShowCar.TabIndex = 14;
            this.toolTip1.SetToolTip(this.dgvShowCar, "List of the selected cars");
            this.dgvShowCar.VirtualMode = true;
            this.dgvShowCar.SelectionChanged += new System.EventHandler(this.dgvShowCar_SelectionChanged);
            // 
            // dtpManufactured
            // 
            this.dtpManufactured.Location = new System.Drawing.Point(62, 200);
            this.dtpManufactured.Name = "dtpManufactured";
            this.dtpManufactured.Size = new System.Drawing.Size(164, 23);
            this.dtpManufactured.TabIndex = 8;
            this.toolTip1.SetToolTip(this.dtpManufactured, "Select the date of manufacture ");
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Maroon;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(62, 181);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(109, 15);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Manufactured Date";
            this.toolTip1.SetToolTip(this.lblDate, "manufactured date");
            // 
            // cboBrand
            // 
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(62, 110);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(163, 23);
            this.cboBrand.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cboBrand, "Select the brand of the car");
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSerialNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSerialNumber.Location = new System.Drawing.Point(61, 50);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(35, 15);
            this.lblSerialNumber.TabIndex = 1;
            this.lblSerialNumber.Text = "Serial";
            this.toolTip1.SetToolTip(this.lblSerialNumber, "Serial");
            // 
            // nudSerial
            // 
            this.nudSerial.Location = new System.Drawing.Point(62, 68);
            this.nudSerial.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudSerial.Name = "nudSerial";
            this.nudSerial.Size = new System.Drawing.Size(163, 23);
            this.nudSerial.TabIndex = 2;
            this.toolTip1.SetToolTip(this.nudSerial, "Select the Serial number");
            // 
            // ShowCars
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ICE4.Properties.Resources.Screen_Shot_2022_03_13_at_4_20_02_PM;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(569, 546);
            this.Controls.Add(this.nudSerial);
            this.Controls.Add(this.lblSerialNumber);
            this.Controls.Add(this.cboBrand);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpManufactured);
            this.Controls.Add(this.dgvShowCar);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblColorlbl);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblselectCar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(585, 585);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(585, 585);
            this.Name = "ShowCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ICE4 - Show Car List";
            this.Load += new System.EventHandler(this.ShowCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSerial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblselectCar;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblColorlbl;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvShowCar;
        private System.Windows.Forms.DateTimePicker dtpManufactured;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.NumericUpDown nudSerial;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

