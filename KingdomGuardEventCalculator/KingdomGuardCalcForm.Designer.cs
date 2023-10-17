namespace KingdomGuardEventCalculator
{
    partial class KingdomGuardCalcForm
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
            tabControl1 = new TabControl();
            Unit_Tab = new TabPage();
            Summon_Tab = new TabPage();
            Witch_Tab = new TabPage();
            Gear_Tab = new TabPage();
            Dragon_Tab = new TabPage();
            Hero_Tab = new TabPage();
            SSR_SumBox = new TextBox();
            SR_SumBox = new TextBox();
            R_SumBox = new TextBox();
            N_SumBox = new TextBox();
            SSR_NumericBox = new NumericUpDown();
            R_NumericBox = new NumericUpDown();
            SR_NumericBox = new NumericUpDown();
            N_NumericBox = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            calcBtn = new Button();
            sumAll_Box = new TextBox();
            tabControl1.SuspendLayout();
            Hero_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SSR_NumericBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)R_NumericBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SR_NumericBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)N_NumericBox).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Unit_Tab);
            tabControl1.Controls.Add(Summon_Tab);
            tabControl1.Controls.Add(Witch_Tab);
            tabControl1.Controls.Add(Gear_Tab);
            tabControl1.Controls.Add(Dragon_Tab);
            tabControl1.Controls.Add(Hero_Tab);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 397);
            tabControl1.TabIndex = 0;
            // 
            // Unit_Tab
            // 
            Unit_Tab.BackColor = SystemColors.ControlDark;
            Unit_Tab.Location = new Point(4, 24);
            Unit_Tab.Name = "Unit_Tab";
            Unit_Tab.Padding = new Padding(3);
            Unit_Tab.Size = new Size(768, 369);
            Unit_Tab.TabIndex = 0;
            Unit_Tab.Text = "Unit";
            // 
            // Summon_Tab
            // 
            Summon_Tab.BackColor = SystemColors.ControlDark;
            Summon_Tab.Location = new Point(4, 24);
            Summon_Tab.Name = "Summon_Tab";
            Summon_Tab.Padding = new Padding(3);
            Summon_Tab.RightToLeft = RightToLeft.Yes;
            Summon_Tab.Size = new Size(768, 369);
            Summon_Tab.TabIndex = 1;
            Summon_Tab.Text = "Summon";
            // 
            // Witch_Tab
            // 
            Witch_Tab.BackColor = SystemColors.ControlDark;
            Witch_Tab.Location = new Point(4, 24);
            Witch_Tab.Name = "Witch_Tab";
            Witch_Tab.Size = new Size(768, 369);
            Witch_Tab.TabIndex = 2;
            Witch_Tab.Text = "Witch";
            // 
            // Gear_Tab
            // 
            Gear_Tab.BackColor = SystemColors.ControlDark;
            Gear_Tab.Location = new Point(4, 24);
            Gear_Tab.Name = "Gear_Tab";
            Gear_Tab.Size = new Size(768, 369);
            Gear_Tab.TabIndex = 3;
            Gear_Tab.Text = "Gear";
            // 
            // Dragon_Tab
            // 
            Dragon_Tab.BackColor = SystemColors.ControlDark;
            Dragon_Tab.Location = new Point(4, 24);
            Dragon_Tab.Name = "Dragon_Tab";
            Dragon_Tab.Size = new Size(768, 369);
            Dragon_Tab.TabIndex = 4;
            Dragon_Tab.Text = "Dragon";
            // 
            // Hero_Tab
            // 
            Hero_Tab.BackColor = SystemColors.ControlDark;
            Hero_Tab.Controls.Add(SSR_SumBox);
            Hero_Tab.Controls.Add(SR_SumBox);
            Hero_Tab.Controls.Add(R_SumBox);
            Hero_Tab.Controls.Add(N_SumBox);
            Hero_Tab.Controls.Add(SSR_NumericBox);
            Hero_Tab.Controls.Add(R_NumericBox);
            Hero_Tab.Controls.Add(SR_NumericBox);
            Hero_Tab.Controls.Add(N_NumericBox);
            Hero_Tab.Controls.Add(label4);
            Hero_Tab.Controls.Add(label3);
            Hero_Tab.Controls.Add(label2);
            Hero_Tab.Controls.Add(label1);
            Hero_Tab.Location = new Point(4, 24);
            Hero_Tab.Name = "Hero_Tab";
            Hero_Tab.Size = new Size(768, 369);
            Hero_Tab.TabIndex = 5;
            Hero_Tab.Text = "Hero";
            // 
            // SSR_SumBox
            // 
            SSR_SumBox.Location = new Point(174, 130);
            SSR_SumBox.Name = "SSR_SumBox";
            SSR_SumBox.ReadOnly = true;
            SSR_SumBox.Size = new Size(100, 23);
            SSR_SumBox.TabIndex = 11;
            // 
            // SR_SumBox
            // 
            SR_SumBox.Location = new Point(174, 91);
            SR_SumBox.Name = "SR_SumBox";
            SR_SumBox.ReadOnly = true;
            SR_SumBox.Size = new Size(100, 23);
            SR_SumBox.TabIndex = 10;
            // 
            // R_SumBox
            // 
            R_SumBox.Location = new Point(174, 53);
            R_SumBox.Name = "R_SumBox";
            R_SumBox.ReadOnly = true;
            R_SumBox.Size = new Size(100, 23);
            R_SumBox.TabIndex = 9;
            // 
            // N_SumBox
            // 
            N_SumBox.Location = new Point(174, 13);
            N_SumBox.Name = "N_SumBox";
            N_SumBox.ReadOnly = true;
            N_SumBox.Size = new Size(100, 23);
            N_SumBox.TabIndex = 8;
            // 
            // SSR_NumericBox
            // 
            SSR_NumericBox.Location = new Point(48, 131);
            SSR_NumericBox.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            SSR_NumericBox.Name = "SSR_NumericBox";
            SSR_NumericBox.Size = new Size(120, 23);
            SSR_NumericBox.TabIndex = 7;
            SSR_NumericBox.ValueChanged += SSR_NumericBox_ValueChanged;
            // 
            // R_NumericBox
            // 
            R_NumericBox.Location = new Point(48, 53);
            R_NumericBox.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            R_NumericBox.Name = "R_NumericBox";
            R_NumericBox.Size = new Size(120, 23);
            R_NumericBox.TabIndex = 6;
            R_NumericBox.ValueChanged += R_NumericBox_ValueChanged;
            // 
            // SR_NumericBox
            // 
            SR_NumericBox.Location = new Point(48, 92);
            SR_NumericBox.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            SR_NumericBox.Name = "SR_NumericBox";
            SR_NumericBox.Size = new Size(120, 23);
            SR_NumericBox.TabIndex = 5;
            SR_NumericBox.ValueChanged += SR_NumericBox_ValueChanged;
            // 
            // N_NumericBox
            // 
            N_NumericBox.Location = new Point(48, 14);
            N_NumericBox.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            N_NumericBox.Name = "N_NumericBox";
            N_NumericBox.Size = new Size(120, 23);
            N_NumericBox.TabIndex = 4;
            N_NumericBox.ValueChanged += N_NumericBox_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 133);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 3;
            label4.Text = "SSR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 94);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 2;
            label3.Text = "SR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 55);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 1;
            label2.Text = "R";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 16);
            label1.Name = "label1";
            label1.Size = new Size(16, 15);
            label1.TabIndex = 0;
            label1.Text = "N";
            // 
            // calcBtn
            // 
            calcBtn.Location = new Point(713, 415);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(75, 23);
            calcBtn.TabIndex = 1;
            calcBtn.Text = "Calculate";
            calcBtn.UseVisualStyleBackColor = true;
            calcBtn.Click += calcBtn_Click;
            // 
            // sumAll_Box
            // 
            sumAll_Box.Location = new Point(564, 416);
            sumAll_Box.Name = "sumAll_Box";
            sumAll_Box.ReadOnly = true;
            sumAll_Box.Size = new Size(143, 23);
            sumAll_Box.TabIndex = 2;
            // 
            // KingdomGuardCalcForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(sumAll_Box);
            Controls.Add(calcBtn);
            Controls.Add(tabControl1);
            Name = "KingdomGuardCalcForm";
            Text = "KingdomGuardCalcForm";
            tabControl1.ResumeLayout(false);
            Hero_Tab.ResumeLayout(false);
            Hero_Tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SSR_NumericBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)R_NumericBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)SR_NumericBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)N_NumericBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Unit_Tab;
        private TabPage Summon_Tab;
        private Button calcBtn;
        private TabPage Witch_Tab;
        private TabPage Gear_Tab;
        private TabPage Dragon_Tab;
        private TabPage Hero_Tab;
        private TextBox sumAll_Box;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown SSR_NumericBox;
        private NumericUpDown R_NumericBox;
        private NumericUpDown SR_NumericBox;
        private NumericUpDown N_NumericBox;
        private TextBox SSR_SumBox;
        private TextBox SR_SumBox;
        private TextBox R_SumBox;
        private TextBox N_SumBox;
    }
}