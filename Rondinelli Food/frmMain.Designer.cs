namespace Rondinelli_Food
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.listOrder = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkMus = new System.Windows.Forms.CheckBox();
            this.chkMayo = new System.Windows.Forms.CheckBox();
            this.chkKet = new System.Windows.Forms.CheckBox();
            this.radChick = new System.Windows.Forms.RadioButton();
            this.radFish = new System.Windows.Forms.RadioButton();
            this.radHam = new System.Windows.Forms.RadioButton();
            this.btnSandwich = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkIce = new System.Windows.Forms.CheckBox();
            this.chkSalad = new System.Windows.Forms.CheckBox();
            this.chkChili = new System.Windows.Forms.CheckBox();
            this.chkFry = new System.Windows.Forms.CheckBox();
            this.btnSide = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.radWater = new System.Windows.Forms.RadioButton();
            this.btnDrink = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // listOrder
            // 
            this.listOrder.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOrder.FormattingEnabled = true;
            this.listOrder.ItemHeight = 21;
            this.listOrder.Items.AddRange(new object[] {
            "Your order:",
            "========================================================="});
            this.listOrder.Location = new System.Drawing.Point(651, 48);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(471, 550);
            this.listOrder.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(27, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(404, 587);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnSandwich);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(396, 561);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sandwiches";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkMus
            // 
            this.chkMus.AutoSize = true;
            this.chkMus.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMus.Location = new System.Drawing.Point(12, 131);
            this.chkMus.Name = "chkMus";
            this.chkMus.Size = new System.Drawing.Size(76, 21);
            this.chkMus.TabIndex = 6;
            this.chkMus.Text = "Mustard";
            this.chkMus.UseVisualStyleBackColor = true;
            // 
            // chkMayo
            // 
            this.chkMayo.AutoSize = true;
            this.chkMayo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMayo.Location = new System.Drawing.Point(12, 83);
            this.chkMayo.Name = "chkMayo";
            this.chkMayo.Size = new System.Drawing.Size(97, 21);
            this.chkMayo.TabIndex = 5;
            this.chkMayo.Text = "Mayonnaise";
            this.chkMayo.UseVisualStyleBackColor = true;
            // 
            // chkKet
            // 
            this.chkKet.AutoSize = true;
            this.chkKet.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKet.Location = new System.Drawing.Point(12, 35);
            this.chkKet.Name = "chkKet";
            this.chkKet.Size = new System.Drawing.Size(74, 21);
            this.chkKet.TabIndex = 4;
            this.chkKet.Text = "Ketchup";
            this.chkKet.UseVisualStyleBackColor = true;
            // 
            // radChick
            // 
            this.radChick.AutoSize = true;
            this.radChick.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radChick.Location = new System.Drawing.Point(12, 72);
            this.radChick.Name = "radChick";
            this.radChick.Size = new System.Drawing.Size(70, 21);
            this.radChick.TabIndex = 3;
            this.radChick.Text = "Chicken";
            this.radChick.UseVisualStyleBackColor = true;
            // 
            // radFish
            // 
            this.radFish.AutoSize = true;
            this.radFish.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFish.Location = new System.Drawing.Point(12, 113);
            this.radFish.Name = "radFish";
            this.radFish.Size = new System.Drawing.Size(48, 21);
            this.radFish.TabIndex = 2;
            this.radFish.Text = "Fish";
            this.radFish.UseVisualStyleBackColor = true;
            // 
            // radHam
            // 
            this.radHam.AutoSize = true;
            this.radHam.Checked = true;
            this.radHam.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHam.Location = new System.Drawing.Point(12, 31);
            this.radHam.Name = "radHam";
            this.radHam.Size = new System.Drawing.Size(93, 21);
            this.radHam.TabIndex = 1;
            this.radHam.TabStop = true;
            this.radHam.Text = "Hamburger";
            this.radHam.UseVisualStyleBackColor = true;
            // 
            // btnSandwich
            // 
            this.btnSandwich.BackColor = System.Drawing.Color.SeaShell;
            this.btnSandwich.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSandwich.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSandwich.Location = new System.Drawing.Point(31, 427);
            this.btnSandwich.Name = "btnSandwich";
            this.btnSandwich.Size = new System.Drawing.Size(290, 92);
            this.btnSandwich.TabIndex = 0;
            this.btnSandwich.Text = "Order Sandwich";
            this.btnSandwich.UseVisualStyleBackColor = false;
            this.btnSandwich.Click += new System.EventHandler(this.btnSandwich_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.chkIce);
            this.tabPage2.Controls.Add(this.chkSalad);
            this.tabPage2.Controls.Add(this.chkChili);
            this.tabPage2.Controls.Add(this.chkFry);
            this.tabPage2.Controls.Add(this.btnSide);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(396, 561);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sides";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkIce
            // 
            this.chkIce.AutoSize = true;
            this.chkIce.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIce.Location = new System.Drawing.Point(226, 135);
            this.chkIce.Name = "chkIce";
            this.chkIce.Size = new System.Drawing.Size(85, 21);
            this.chkIce.TabIndex = 4;
            this.chkIce.Text = "Ice Cream";
            this.chkIce.UseVisualStyleBackColor = true;
            // 
            // chkSalad
            // 
            this.chkSalad.AutoSize = true;
            this.chkSalad.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSalad.Location = new System.Drawing.Point(20, 135);
            this.chkSalad.Name = "chkSalad";
            this.chkSalad.Size = new System.Drawing.Size(59, 21);
            this.chkSalad.TabIndex = 3;
            this.chkSalad.Text = "Salad";
            this.chkSalad.UseVisualStyleBackColor = true;
            // 
            // chkChili
            // 
            this.chkChili.AutoSize = true;
            this.chkChili.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChili.Location = new System.Drawing.Point(226, 78);
            this.chkChili.Name = "chkChili";
            this.chkChili.Size = new System.Drawing.Size(51, 21);
            this.chkChili.TabIndex = 2;
            this.chkChili.Text = "Chili";
            this.chkChili.UseVisualStyleBackColor = true;
            // 
            // chkFry
            // 
            this.chkFry.AutoSize = true;
            this.chkFry.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFry.Location = new System.Drawing.Point(20, 78);
            this.chkFry.Name = "chkFry";
            this.chkFry.Size = new System.Drawing.Size(54, 21);
            this.chkFry.TabIndex = 1;
            this.chkFry.Text = "Fries";
            this.chkFry.UseVisualStyleBackColor = true;
            // 
            // btnSide
            // 
            this.btnSide.BackColor = System.Drawing.Color.SeaShell;
            this.btnSide.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSide.Location = new System.Drawing.Point(20, 423);
            this.btnSide.Name = "btnSide";
            this.btnSide.Size = new System.Drawing.Size(339, 93);
            this.btnSide.TabIndex = 0;
            this.btnSide.Text = "Order Side";
            this.btnSide.UseVisualStyleBackColor = false;
            this.btnSide.Click += new System.EventHandler(this.btnSide_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.radWater);
            this.tabPage3.Controls.Add(this.btnDrink);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(396, 561);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Drinks";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // radWater
            // 
            this.radWater.AutoSize = true;
            this.radWater.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWater.Location = new System.Drawing.Point(35, 33);
            this.radWater.Name = "radWater";
            this.radWater.Size = new System.Drawing.Size(61, 21);
            this.radWater.TabIndex = 1;
            this.radWater.TabStop = true;
            this.radWater.Text = "Water";
            this.radWater.UseVisualStyleBackColor = true;
            // 
            // btnDrink
            // 
            this.btnDrink.BackColor = System.Drawing.Color.SeaShell;
            this.btnDrink.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrink.Location = new System.Drawing.Point(30, 438);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(314, 78);
            this.btnDrink.TabIndex = 0;
            this.btnDrink.Text = "Order Drink";
            this.btnDrink.UseVisualStyleBackColor = false;
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Khaki;
            this.btnReset.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(39, 681);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 59);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1056, 628);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 24);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "$0.00";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnOrder.Enabled = false;
            this.btnOrder.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(418, 646);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(238, 94);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Complete Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Brown;
            this.btnExit.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1000, 684);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 59);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkKet);
            this.groupBox1.Controls.Add(this.chkMus);
            this.groupBox1.Controls.Add(this.chkMayo);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 172);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condinments";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radChick);
            this.groupBox2.Controls.Add(this.radFish);
            this.groupBox2.Controls.Add(this.radHam);
            this.groupBox2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 161);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sandwiches";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(492, 740);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(92, 24);
            this.lblOrder.TabIndex = 6;
            this.lblOrder.Text = "Order #1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 256);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(337, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-38, 112);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(449, 253);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1157, 765);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listOrder);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listOrder;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkMus;
        private System.Windows.Forms.CheckBox chkMayo;
        private System.Windows.Forms.CheckBox chkKet;
        private System.Windows.Forms.RadioButton radChick;
        private System.Windows.Forms.RadioButton radFish;
        private System.Windows.Forms.RadioButton radHam;
        private System.Windows.Forms.Button btnSandwich;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkIce;
        private System.Windows.Forms.CheckBox chkSalad;
        private System.Windows.Forms.CheckBox chkChili;
        private System.Windows.Forms.CheckBox chkFry;
        private System.Windows.Forms.Button btnSide;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton radWater;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

