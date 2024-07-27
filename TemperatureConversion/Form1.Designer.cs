namespace TemperatureConversion
{
    partial class fnformTemperatureConversions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fnformTemperatureConversions));
            this.fnpicboxThermometor = new System.Windows.Forms.PictureBox();
            this.fnlblinitaltemperature = new System.Windows.Forms.Label();
            this.fntxtinitialTemp = new System.Windows.Forms.TextBox();
            this.fnbtncalculate = new System.Windows.Forms.Button();
            this.fnbtnExit = new System.Windows.Forms.Button();
            this.fnlblFinalTemp = new System.Windows.Forms.Label();
            this.fnpanelinitialunits = new System.Windows.Forms.Panel();
            this.fnrdoinitalfahrenheit = new System.Windows.Forms.RadioButton();
            this.fnrdoinitalkelvin = new System.Windows.Forms.RadioButton();
            this.fnrdoinitalcelsius = new System.Windows.Forms.RadioButton();
            this.fnlblinitialunits = new System.Windows.Forms.Label();
            this.fnpanelconvertedunits = new System.Windows.Forms.Panel();
            this.fnrdofinalfahrenheit = new System.Windows.Forms.RadioButton();
            this.fnrdofinalkelvin = new System.Windows.Forms.RadioButton();
            this.fnrdofinalcelsius = new System.Windows.Forms.RadioButton();
            this.fnlblconvertedunit = new System.Windows.Forms.Label();
            this.fnlblAns = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fnpicboxThermometor)).BeginInit();
            this.fnpanelinitialunits.SuspendLayout();
            this.fnpanelconvertedunits.SuspendLayout();
            this.SuspendLayout();
            // 
            // fnpicboxThermometor
            // 
            this.fnpicboxThermometor.Image = ((System.Drawing.Image)(resources.GetObject("fnpicboxThermometor.Image")));
            this.fnpicboxThermometor.Location = new System.Drawing.Point(504, 31);
            this.fnpicboxThermometor.Name = "fnpicboxThermometor";
            this.fnpicboxThermometor.Size = new System.Drawing.Size(96, 297);
            this.fnpicboxThermometor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fnpicboxThermometor.TabIndex = 0;
            this.fnpicboxThermometor.TabStop = false;
            // 
            // fnlblinitaltemperature
            // 
            this.fnlblinitaltemperature.AutoSize = true;
            this.fnlblinitaltemperature.BackColor = System.Drawing.Color.White;
            this.fnlblinitaltemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fnlblinitaltemperature.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnlblinitaltemperature.ForeColor = System.Drawing.Color.Black;
            this.fnlblinitaltemperature.Location = new System.Drawing.Point(12, 31);
            this.fnlblinitaltemperature.Name = "fnlblinitaltemperature";
            this.fnlblinitaltemperature.Size = new System.Drawing.Size(231, 20);
            this.fnlblinitaltemperature.TabIndex = 1;
            this.fnlblinitaltemperature.Text = "Input Inital temperature:";
            this.fnlblinitaltemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fntxtinitialTemp
            // 
            this.fntxtinitialTemp.Location = new System.Drawing.Point(249, 31);
            this.fntxtinitialTemp.Name = "fntxtinitialTemp";
            this.fntxtinitialTemp.Size = new System.Drawing.Size(161, 20);
            this.fntxtinitialTemp.TabIndex = 2;
            // 
            // fnbtncalculate
            // 
            this.fnbtncalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.fnbtncalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fnbtncalculate.Location = new System.Drawing.Point(350, 231);
            this.fnbtncalculate.Name = "fnbtncalculate";
            this.fnbtncalculate.Size = new System.Drawing.Size(128, 49);
            this.fnbtncalculate.TabIndex = 3;
            this.fnbtncalculate.Text = "Calculate";
            this.fnbtncalculate.UseVisualStyleBackColor = false;
            this.fnbtncalculate.Click += new System.EventHandler(this.fnbtncalculate_Click);
            // 
            // fnbtnExit
            // 
            this.fnbtnExit.BackColor = System.Drawing.Color.Red;
            this.fnbtnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fnbtnExit.Location = new System.Drawing.Point(350, 286);
            this.fnbtnExit.Name = "fnbtnExit";
            this.fnbtnExit.Size = new System.Drawing.Size(128, 49);
            this.fnbtnExit.TabIndex = 4;
            this.fnbtnExit.Text = "Exit";
            this.fnbtnExit.UseVisualStyleBackColor = false;
            this.fnbtnExit.Click += new System.EventHandler(this.fnbtnExit_Click);
            // 
            // fnlblFinalTemp
            // 
            this.fnlblFinalTemp.AutoSize = true;
            this.fnlblFinalTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fnlblFinalTemp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnlblFinalTemp.Location = new System.Drawing.Point(12, 227);
            this.fnlblFinalTemp.Name = "fnlblFinalTemp";
            this.fnlblFinalTemp.Size = new System.Drawing.Size(273, 20);
            this.fnlblFinalTemp.TabIndex = 5;
            this.fnlblFinalTemp.Text = "The converted temperature is";
            this.fnlblFinalTemp.Click += new System.EventHandler(this.fnlblFinalTemp_Click);
            // 
            // fnpanelinitialunits
            // 
            this.fnpanelinitialunits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fnpanelinitialunits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fnpanelinitialunits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fnpanelinitialunits.Controls.Add(this.fnrdoinitalfahrenheit);
            this.fnpanelinitialunits.Controls.Add(this.fnrdoinitalkelvin);
            this.fnpanelinitialunits.Controls.Add(this.fnrdoinitalcelsius);
            this.fnpanelinitialunits.Controls.Add(this.fnlblinitialunits);
            this.fnpanelinitialunits.Location = new System.Drawing.Point(12, 70);
            this.fnpanelinitialunits.Name = "fnpanelinitialunits";
            this.fnpanelinitialunits.Size = new System.Drawing.Size(182, 152);
            this.fnpanelinitialunits.TabIndex = 6;
            // 
            // fnrdoinitalfahrenheit
            // 
            this.fnrdoinitalfahrenheit.AutoSize = true;
            this.fnrdoinitalfahrenheit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fnrdoinitalfahrenheit.Location = new System.Drawing.Point(14, 117);
            this.fnrdoinitalfahrenheit.Name = "fnrdoinitalfahrenheit";
            this.fnrdoinitalfahrenheit.Size = new System.Drawing.Size(85, 17);
            this.fnrdoinitalfahrenheit.TabIndex = 3;
            this.fnrdoinitalfahrenheit.TabStop = true;
            this.fnrdoinitalfahrenheit.Text = "Fahrenheit";
            this.fnrdoinitalfahrenheit.UseVisualStyleBackColor = false;
            this.fnrdoinitalfahrenheit.CheckedChanged += new System.EventHandler(this.fnradiobtninitalfahrenheit_CheckedChanged);
            // 
            // fnrdoinitalkelvin
            // 
            this.fnrdoinitalkelvin.AutoSize = true;
            this.fnrdoinitalkelvin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fnrdoinitalkelvin.Location = new System.Drawing.Point(14, 81);
            this.fnrdoinitalkelvin.Name = "fnrdoinitalkelvin";
            this.fnrdoinitalkelvin.Size = new System.Drawing.Size(60, 17);
            this.fnrdoinitalkelvin.TabIndex = 2;
            this.fnrdoinitalkelvin.TabStop = true;
            this.fnrdoinitalkelvin.Text = "Kelvin";
            this.fnrdoinitalkelvin.UseVisualStyleBackColor = false;
            this.fnrdoinitalkelvin.CheckedChanged += new System.EventHandler(this.fnradiobtninitalkelvin_CheckedChanged);
            // 
            // fnrdoinitalcelsius
            // 
            this.fnrdoinitalcelsius.AutoSize = true;
            this.fnrdoinitalcelsius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fnrdoinitalcelsius.Location = new System.Drawing.Point(14, 48);
            this.fnrdoinitalcelsius.Name = "fnrdoinitalcelsius";
            this.fnrdoinitalcelsius.Size = new System.Drawing.Size(65, 17);
            this.fnrdoinitalcelsius.TabIndex = 1;
            this.fnrdoinitalcelsius.TabStop = true;
            this.fnrdoinitalcelsius.Text = "Celsius";
            this.fnrdoinitalcelsius.UseVisualStyleBackColor = false;
            this.fnrdoinitalcelsius.CheckedChanged += new System.EventHandler(this.fnradiobtninitalcelsius_CheckedChanged);
            // 
            // fnlblinitialunits
            // 
            this.fnlblinitialunits.AutoSize = true;
            this.fnlblinitialunits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.fnlblinitialunits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fnlblinitialunits.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnlblinitialunits.Location = new System.Drawing.Point(14, 9);
            this.fnlblinitialunits.Name = "fnlblinitialunits";
            this.fnlblinitialunits.Size = new System.Drawing.Size(140, 19);
            this.fnlblinitialunits.TabIndex = 0;
            this.fnlblinitialunits.Text = "Choose the Initial Unit:";
            // 
            // fnpanelconvertedunits
            // 
            this.fnpanelconvertedunits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.fnpanelconvertedunits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fnpanelconvertedunits.Controls.Add(this.fnrdofinalfahrenheit);
            this.fnpanelconvertedunits.Controls.Add(this.fnrdofinalkelvin);
            this.fnpanelconvertedunits.Controls.Add(this.fnrdofinalcelsius);
            this.fnpanelconvertedunits.Controls.Add(this.fnlblconvertedunit);
            this.fnpanelconvertedunits.Location = new System.Drawing.Point(212, 70);
            this.fnpanelconvertedunits.Name = "fnpanelconvertedunits";
            this.fnpanelconvertedunits.Size = new System.Drawing.Size(198, 152);
            this.fnpanelconvertedunits.TabIndex = 7;
            // 
            // fnrdofinalfahrenheit
            // 
            this.fnrdofinalfahrenheit.AutoSize = true;
            this.fnrdofinalfahrenheit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.fnrdofinalfahrenheit.Location = new System.Drawing.Point(15, 116);
            this.fnrdofinalfahrenheit.Name = "fnrdofinalfahrenheit";
            this.fnrdofinalfahrenheit.Size = new System.Drawing.Size(85, 17);
            this.fnrdofinalfahrenheit.TabIndex = 11;
            this.fnrdofinalfahrenheit.TabStop = true;
            this.fnrdofinalfahrenheit.Text = "Fahrenheit";
            this.fnrdofinalfahrenheit.UseVisualStyleBackColor = false;
            // 
            // fnrdofinalkelvin
            // 
            this.fnrdofinalkelvin.AutoSize = true;
            this.fnrdofinalkelvin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.fnrdofinalkelvin.Location = new System.Drawing.Point(15, 80);
            this.fnrdofinalkelvin.Name = "fnrdofinalkelvin";
            this.fnrdofinalkelvin.Size = new System.Drawing.Size(60, 17);
            this.fnrdofinalkelvin.TabIndex = 10;
            this.fnrdofinalkelvin.TabStop = true;
            this.fnrdofinalkelvin.Text = "Kelvin";
            this.fnrdofinalkelvin.UseVisualStyleBackColor = false;
            // 
            // fnrdofinalcelsius
            // 
            this.fnrdofinalcelsius.AutoSize = true;
            this.fnrdofinalcelsius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.fnrdofinalcelsius.Location = new System.Drawing.Point(15, 47);
            this.fnrdofinalcelsius.Name = "fnrdofinalcelsius";
            this.fnrdofinalcelsius.Size = new System.Drawing.Size(65, 17);
            this.fnrdofinalcelsius.TabIndex = 9;
            this.fnrdofinalcelsius.TabStop = true;
            this.fnrdofinalcelsius.Text = "Celsius";
            this.fnrdofinalcelsius.UseVisualStyleBackColor = false;
            // 
            // fnlblconvertedunit
            // 
            this.fnlblconvertedunit.AutoSize = true;
            this.fnlblconvertedunit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.fnlblconvertedunit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fnlblconvertedunit.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnlblconvertedunit.Location = new System.Drawing.Point(15, 9);
            this.fnlblconvertedunit.Name = "fnlblconvertedunit";
            this.fnlblconvertedunit.Size = new System.Drawing.Size(166, 19);
            this.fnlblconvertedunit.TabIndex = 8;
            this.fnlblconvertedunit.Text = "Choose the converted unit:";
            // 
            // fnlblAns
            // 
            this.fnlblAns.AutoSize = true;
            this.fnlblAns.BackColor = System.Drawing.Color.White;
            this.fnlblAns.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnlblAns.ForeColor = System.Drawing.Color.Blue;
            this.fnlblAns.Location = new System.Drawing.Point(27, 286);
            this.fnlblAns.Name = "fnlblAns";
            this.fnlblAns.Size = new System.Drawing.Size(0, 26);
            this.fnlblAns.TabIndex = 8;
            this.fnlblAns.Click += new System.EventHandler(this.fnlblAns_Click);
            // 
            // fnformTemperatureConversions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(626, 340);
            this.Controls.Add(this.fnlblAns);
            this.Controls.Add(this.fnpanelconvertedunits);
            this.Controls.Add(this.fnlblFinalTemp);
            this.Controls.Add(this.fnbtnExit);
            this.Controls.Add(this.fnbtncalculate);
            this.Controls.Add(this.fntxtinitialTemp);
            this.Controls.Add(this.fnlblinitaltemperature);
            this.Controls.Add(this.fnpicboxThermometor);
            this.Controls.Add(this.fnpanelinitialunits);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fnformTemperatureConversions";
            this.Text = "Temperature Conversions";
            this.Load += new System.EventHandler(this.fnformTemperatureConversions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fnpicboxThermometor)).EndInit();
            this.fnpanelinitialunits.ResumeLayout(false);
            this.fnpanelinitialunits.PerformLayout();
            this.fnpanelconvertedunits.ResumeLayout(false);
            this.fnpanelconvertedunits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fnpicboxThermometor;
        private System.Windows.Forms.Label fnlblinitaltemperature;
        private System.Windows.Forms.TextBox fntxtinitialTemp;
        private System.Windows.Forms.Button fnbtncalculate;
        private System.Windows.Forms.Button fnbtnExit;
        private System.Windows.Forms.Label fnlblFinalTemp;
        private System.Windows.Forms.Panel fnpanelinitialunits;
        private System.Windows.Forms.Panel fnpanelconvertedunits;
        private System.Windows.Forms.Label fnlblinitialunits;
        private System.Windows.Forms.Label fnlblconvertedunit;
        private System.Windows.Forms.RadioButton fnrdoinitalcelsius;
        private System.Windows.Forms.RadioButton fnrdoinitalfahrenheit;
        private System.Windows.Forms.RadioButton fnrdoinitalkelvin;
        private System.Windows.Forms.RadioButton fnrdofinalfahrenheit;
        private System.Windows.Forms.RadioButton fnrdofinalkelvin;
        private System.Windows.Forms.RadioButton fnrdofinalcelsius;
        private System.Windows.Forms.Label fnlblAns;
    }
}

