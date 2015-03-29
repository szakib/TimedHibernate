using System.Windows.Forms;
using System;
namespace TimedHibernate
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.ActionButton = new System.Windows.Forms.Button();
            this.RBHibernate = new System.Windows.Forms.RadioButton();
            this.RBStandby = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ForceBox = new System.Windows.Forms.CheckBox();
            this.CountDown = new System.Windows.Forms.Timer(this.components);
            this.DayUD = new System.Windows.Forms.NumericUpDown();
            this.HourUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.SecUD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.MinUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.DisplayClock = new System.Windows.Forms.Timer(this.components);
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DayUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinUD)).BeginInit();
            this.SuspendLayout();
            // 
            // ActionButton
            // 
            this.ActionButton.Location = new System.Drawing.Point(12, 101);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(75, 23);
            this.ActionButton.TabIndex = 0;
            this.ActionButton.Text = "Action!";
            this.ActionButton.UseVisualStyleBackColor = true;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // RBHibernate
            // 
            this.RBHibernate.AutoSize = true;
            this.RBHibernate.Checked = true;
            this.RBHibernate.Location = new System.Drawing.Point(12, 12);
            this.RBHibernate.Name = "RBHibernate";
            this.RBHibernate.Size = new System.Drawing.Size(71, 17);
            this.RBHibernate.TabIndex = 1;
            this.RBHibernate.TabStop = true;
            this.RBHibernate.Text = "Hibernate";
            this.RBHibernate.UseVisualStyleBackColor = true;
            // 
            // RBStandby
            // 
            this.RBStandby.AutoSize = true;
            this.RBStandby.Location = new System.Drawing.Point(12, 36);
            this.RBStandby.Name = "RBStandby";
            this.RBStandby.Size = new System.Drawing.Size(64, 17);
            this.RBStandby.TabIndex = 2;
            this.RBStandby.TabStop = true;
            this.RBStandby.Text = "Standby";
            this.RBStandby.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "in";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "days";
            // 
            // ForceBox
            // 
            this.ForceBox.AutoSize = true;
            this.ForceBox.Location = new System.Drawing.Point(12, 63);
            this.ForceBox.Name = "ForceBox";
            this.ForceBox.Size = new System.Drawing.Size(53, 17);
            this.ForceBox.TabIndex = 6;
            this.ForceBox.Text = "Force";
            this.ForceBox.UseVisualStyleBackColor = true;
            // 
            // CountDown
            // 
            this.CountDown.Tick += new System.EventHandler(this.CountDown_Tick);
            // 
            // DayUD
            // 
            this.DayUD.Location = new System.Drawing.Point(105, 19);
            this.DayUD.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.DayUD.Name = "DayUD";
            this.DayUD.Size = new System.Drawing.Size(40, 20);
            this.DayUD.TabIndex = 7;
            this.DayUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HourUD
            // 
            this.HourUD.Location = new System.Drawing.Point(193, 19);
            this.HourUD.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.HourUD.Name = "HourUD";
            this.HourUD.Size = new System.Drawing.Size(40, 20);
            this.HourUD.TabIndex = 9;
            this.HourUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "hours";
            // 
            // SecUD
            // 
            this.SecUD.Location = new System.Drawing.Point(193, 63);
            this.SecUD.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.SecUD.Name = "SecUD";
            this.SecUD.Size = new System.Drawing.Size(40, 20);
            this.SecUD.TabIndex = 13;
            this.SecUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "seconds";
            // 
            // MinUD
            // 
            this.MinUD.Location = new System.Drawing.Point(105, 63);
            this.MinUD.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinUD.Name = "MinUD";
            this.MinUD.Size = new System.Drawing.Size(40, 20);
            this.MinUD.TabIndex = 11;
            this.MinUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "minutes";
            // 
            // DisplayClock
            // 
            this.DisplayClock.Interval = 1000;
            this.DisplayClock.Tick += new System.EventHandler(this.DisplayClock_Tick);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(204, 101);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 14;
            this.ResetButton.Text = "Chicken Out";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 134);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SecUD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MinUD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HourUD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DayUD);
            this.Controls.Add(this.ForceBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RBStandby);
            this.Controls.Add(this.RBHibernate);
            this.Controls.Add(this.ActionButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.9;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I can haz timed hibernationz";
            ((System.ComponentModel.ISupportInitialize)(this.DayUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void ResetButton_Click(object sender, EventArgs e)
        {
            if (CountDown.Enabled)
            {
                CountDown.Stop();
                CountDown.Enabled = false;
                DisplayClock.Enabled = false;
                DisplayClock.Stop();
                DayUD.Value = 0;
                HourUD.Value = 0;
                MinUD.Value = 0;
                SecUD.Value = 0;
                RBHibernate.Enabled = true;
                RBStandby.Enabled = true;
                ForceBox.Enabled = true;
                DayUD.Enabled = true;
                HourUD.Enabled = true;
                MinUD.Enabled = true;
                SecUD.Enabled = true;
            }
        }

        void DisplayClock_Tick(object sender, EventArgs e)
        {
            if (SecUD.Value > 0)
                SecUD.Value = SecUD.Value - 1;
            else
            {
                if (MinUD.Value > 0)
                    MinUD.Value = MinUD.Value - 1;
                else
                {
                    if (HourUD.Value > 0)
                        HourUD.Value = HourUD.Value - 1;
                    else
                    {
                        if (DayUD.Value > 0)
                            DayUD.Value = DayUD.Value - 1;
                        else
                        {
                            DisplayClock.Stop();
                            DisplayClock.Enabled = false;
                            return;
                        }
                        HourUD.Value = 23;
                    }
                    MinUD.Value = 59;
                }
                SecUD.Value = 59;
            }
        }

        void CountDown_Tick(object sender, EventArgs e)
        {
            try
            {
                CountDown.Stop();
                CountDown.Enabled = false;

                PowerState ps = PowerState.Hibernate;

                if (RBStandby.Checked)
                    ps = PowerState.Suspend;

                Application.SetSuspendState(ps, ForceBox.Checked, false);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CountDown_Tick Error:" + ex.ToString());
            }
        }

        void ActionButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (DayUD.Value + HourUD.Value + MinUD.Value + SecUD.Value != 0)
                {
                    CountDown.Interval = (86400 * (int)DayUD.Value
                                        + 3600 * (int)HourUD.Value
                                        + 60 * (int)MinUD.Value
                                        + (int)SecUD.Value) * 1000; //D:H:M:S->ms
                    CountDown.Enabled = true;
                    CountDown.Start();
                    DisplayClock.Enabled = true;
                    DisplayClock.Start();
                    RBHibernate.Enabled = false;
                    RBStandby.Enabled = false;
                    ForceBox.Enabled = false;
                    DayUD.Enabled = false;
                    HourUD.Enabled = false;
                    MinUD.Enabled = false;
                    SecUD.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ActionButton_Click Error:" + ex.ToString());
            }
        }

        #endregion

        private System.Windows.Forms.Button ActionButton;
        private RadioButton RBHibernate;
        private RadioButton RBStandby;
        private Label label1;
        private Label label2;
        private CheckBox ForceBox;
        private Timer CountDown;
        private NumericUpDown DayUD;
        private NumericUpDown HourUD;
        private Label label3;
        private NumericUpDown SecUD;
        private Label label4;
        private NumericUpDown MinUD;
        private Label label5;
        private Timer DisplayClock;
        private Button ResetButton;
    }
}

