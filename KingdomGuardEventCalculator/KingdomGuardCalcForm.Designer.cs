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
            button1 = new Button();
            textBox1 = new TextBox();
            tabControl1.SuspendLayout();
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
            Hero_Tab.Location = new Point(4, 24);
            Hero_Tab.Name = "Hero_Tab";
            Hero_Tab.Size = new Size(768, 369);
            Hero_Tab.TabIndex = 5;
            Hero_Tab.Text = "Hero";
            // 
            // button1
            // 
            button1.Location = new Point(713, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(564, 416);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 2;
            // 
            // KingdomGuardCalcForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Name = "KingdomGuardCalcForm";
            Text = "KingdomGuardCalcForm";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Unit_Tab;
        private TabPage Summon_Tab;
        private Button button1;
        private TabPage Witch_Tab;
        private TabPage Gear_Tab;
        private TabPage Dragon_Tab;
        private TabPage Hero_Tab;
        private TextBox textBox1;
    }
}