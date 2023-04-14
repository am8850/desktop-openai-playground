namespace DavinciWF
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            chkSensitive = new CheckBox();
            button2 = new Button();
            button1 = new Button();
            txtContext = new TextBox();
            txtPrompt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            chkGPT = new CheckBox();
            txtN = new TextBox();
            label11 = new Label();
            txtMaxTokens = new TextBox();
            label10 = new Label();
            txtTemperature = new TextBox();
            label9 = new Label();
            groupBox3 = new GroupBox();
            lblCompletionTokens = new Label();
            label8 = new Label();
            lblPrompTokens = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtFullPrompt = new TextBox();
            txtCompletion = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(chkSensitive);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtContext);
            groupBox1.Controls.Add(txtPrompt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(621, 225);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input";
            // 
            // chkSensitive
            // 
            chkSensitive.AutoSize = true;
            chkSensitive.Location = new Point(166, 194);
            chkSensitive.Name = "chkSensitive";
            chkSensitive.Size = new Size(72, 19);
            chkSensitive.TabIndex = 8;
            chkSensitive.Text = "Sensitive";
            chkSensitive.UseVisualStyleBackColor = true;
            chkSensitive.CheckedChanged += ChkSensitive_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(85, 190);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 190);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Ask";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtContext
            // 
            txtContext.AcceptsReturn = true;
            txtContext.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtContext.Location = new Point(85, 109);
            txtContext.Multiline = true;
            txtContext.Name = "txtContext";
            txtContext.ScrollBars = ScrollBars.Vertical;
            txtContext.Size = new Size(521, 75);
            txtContext.TabIndex = 5;
            // 
            // txtPrompt
            // 
            txtPrompt.AcceptsReturn = true;
            txtPrompt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrompt.Location = new Point(85, 28);
            txtPrompt.Multiline = true;
            txtPrompt.Name = "txtPrompt";
            txtPrompt.ScrollBars = ScrollBars.Vertical;
            txtPrompt.Size = new Size(521, 75);
            txtPrompt.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 112);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Context";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Prompt";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(chkGPT);
            groupBox2.Controls.Add(txtN);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtMaxTokens);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtTemperature);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(639, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(135, 225);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Settings";
            // 
            // chkGPT
            // 
            chkGPT.AutoSize = true;
            chkGPT.Checked = true;
            chkGPT.CheckState = CheckState.Checked;
            chkGPT.Location = new Point(17, 190);
            chkGPT.Name = "chkGPT";
            chkGPT.Size = new Size(47, 19);
            chkGPT.TabIndex = 11;
            chkGPT.Text = "GPT";
            chkGPT.UseVisualStyleBackColor = true;
            // 
            // txtN
            // 
            txtN.Location = new Point(17, 144);
            txtN.Name = "txtN";
            txtN.ReadOnly = true;
            txtN.Size = new Size(100, 23);
            txtN.TabIndex = 10;
            txtN.Text = "1";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 126);
            label11.Name = "label11";
            label11.Size = new Size(16, 15);
            label11.TabIndex = 9;
            label11.Text = "N";
            // 
            // txtMaxTokens
            // 
            txtMaxTokens.Location = new Point(17, 96);
            txtMaxTokens.Name = "txtMaxTokens";
            txtMaxTokens.Size = new Size(100, 23);
            txtMaxTokens.TabIndex = 8;
            txtMaxTokens.Text = "1000";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 78);
            label10.Name = "label10";
            label10.Size = new Size(69, 15);
            label10.TabIndex = 7;
            label10.Text = "Max Tokens";
            // 
            // txtTemperature
            // 
            txtTemperature.Location = new Point(17, 49);
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(100, 23);
            txtTemperature.TabIndex = 6;
            txtTemperature.Text = "0.5";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 31);
            label9.Name = "label9";
            label9.Size = new Size(73, 15);
            label9.TabIndex = 5;
            label9.Text = "Temperature";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(lblCompletionTokens);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(lblPrompTokens);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtFullPrompt);
            groupBox3.Controls.Add(txtCompletion);
            groupBox3.Location = new Point(12, 243);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(762, 365);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Output";
            // 
            // lblCompletionTokens
            // 
            lblCompletionTokens.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCompletionTokens.AutoSize = true;
            lblCompletionTokens.Location = new Point(377, 338);
            lblCompletionTokens.Name = "lblCompletionTokens";
            lblCompletionTokens.Size = new Size(43, 15);
            lblCompletionTokens.TabIndex = 7;
            lblCompletionTokens.Text = "Tokens";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(328, 338);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 6;
            label8.Text = "Tokens";
            // 
            // lblPrompTokens
            // 
            lblPrompTokens.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPrompTokens.AutoSize = true;
            lblPrompTokens.Location = new Point(55, 338);
            lblPrompTokens.Name = "lblPrompTokens";
            lblPrompTokens.Size = new Size(43, 15);
            lblPrompTokens.TabIndex = 5;
            lblPrompTokens.Text = "Tokens";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(6, 338);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "Tokens";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(328, 19);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Completion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "Full Request";
            // 
            // txtFullPrompt
            // 
            txtFullPrompt.AcceptsReturn = true;
            txtFullPrompt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtFullPrompt.Location = new Point(6, 37);
            txtFullPrompt.Multiline = true;
            txtFullPrompt.Name = "txtFullPrompt";
            txtFullPrompt.ReadOnly = true;
            txtFullPrompt.ScrollBars = ScrollBars.Vertical;
            txtFullPrompt.Size = new Size(316, 298);
            txtFullPrompt.TabIndex = 1;
            // 
            // txtCompletion
            // 
            txtCompletion.AcceptsReturn = true;
            txtCompletion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCompletion.Location = new Point(328, 37);
            txtCompletion.Multiline = true;
            txtCompletion.Name = "txtCompletion";
            txtCompletion.ScrollBars = ScrollBars.Vertical;
            txtCompletion.Size = new Size(428, 298);
            txtCompletion.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 620);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Davinci Playground";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private TextBox txtContext;
        private TextBox txtPrompt;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtCompletion;
        private TextBox txtN;
        private Label label11;
        private TextBox txtMaxTokens;
        private Label label10;
        private TextBox txtTemperature;
        private Label label9;
        private Label lblCompletionTokens;
        private Label label8;
        private Label lblPrompTokens;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtFullPrompt;
        private CheckBox chkSensitive;
        private CheckBox chkGPT;
    }
}