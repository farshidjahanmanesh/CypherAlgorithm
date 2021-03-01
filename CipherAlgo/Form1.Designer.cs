
namespace CipherAlgo
{
    partial class Form1
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyInput = new System.Windows.Forms.NumericUpDown();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.EncodeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EncodeSubStitution = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DecodeKey = new System.Windows.Forms.Label();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.DecodeKeyTextBox = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CypherTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UseForEncodeSubStitution = new System.Windows.Forms.CheckBox();
            this.UseForDecodeSubStitution = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EncodeWithTranspositionLabel = new System.Windows.Forms.Label();
            this.TranspositionCheckBox = new System.Windows.Forms.CheckBox();
            this.UseForDecodeTransposition = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.KeyInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecodeKeyTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(101, 73);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(291, 22);
            this.inputTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "key";
            // 
            // KeyInput
            // 
            this.KeyInput.Location = new System.Drawing.Point(101, 116);
            this.KeyInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.KeyInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.KeyInput.Name = "KeyInput";
            this.KeyInput.Size = new System.Drawing.Size(120, 22);
            this.KeyInput.TabIndex = 4;
            this.KeyInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EncodeButton
            // 
            this.EncodeButton.Location = new System.Drawing.Point(101, 163);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(83, 23);
            this.EncodeButton.TabIndex = 5;
            this.EncodeButton.Text = "Encode";
            this.EncodeButton.UseVisualStyleBackColor = true;
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // EncodeLabel
            // 
            this.EncodeLabel.AutoSize = true;
            this.EncodeLabel.Location = new System.Drawing.Point(410, 78);
            this.EncodeLabel.Name = "EncodeLabel";
            this.EncodeLabel.Size = new System.Drawing.Size(56, 17);
            this.EncodeLabel.TabIndex = 6;
            this.EncodeLabel.Text = "Encode";
            this.EncodeLabel.Visible = false;
            this.EncodeLabel.Click += new System.EventHandler(this.EncodeLabel_Click);
            this.EncodeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EncodeLabel_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Encode With Key";
            // 
            // EncodeSubStitution
            // 
            this.EncodeSubStitution.AutoSize = true;
            this.EncodeSubStitution.Location = new System.Drawing.Point(410, 163);
            this.EncodeSubStitution.Name = "EncodeSubStitution";
            this.EncodeSubStitution.Size = new System.Drawing.Size(56, 17);
            this.EncodeSubStitution.TabIndex = 8;
            this.EncodeSubStitution.Text = "Encode";
            this.EncodeSubStitution.Visible = false;
            this.EncodeSubStitution.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EncodeSubStitution_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Encode With SubStitution";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Decode";
            // 
            // DecodeKey
            // 
            this.DecodeKey.AutoSize = true;
            this.DecodeKey.Location = new System.Drawing.Point(410, 414);
            this.DecodeKey.Name = "DecodeKey";
            this.DecodeKey.Size = new System.Drawing.Size(56, 17);
            this.DecodeKey.TabIndex = 16;
            this.DecodeKey.Text = "Encode";
            this.DecodeKey.Visible = false;
            // 
            // DecodeButton
            // 
            this.DecodeButton.Location = new System.Drawing.Point(101, 499);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(83, 23);
            this.DecodeButton.TabIndex = 15;
            this.DecodeButton.Text = "Decode";
            this.DecodeButton.UseVisualStyleBackColor = true;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // DecodeKeyTextBox
            // 
            this.DecodeKeyTextBox.Location = new System.Drawing.Point(101, 452);
            this.DecodeKeyTextBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DecodeKeyTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DecodeKeyTextBox.Name = "DecodeKeyTextBox";
            this.DecodeKeyTextBox.Size = new System.Drawing.Size(120, 22);
            this.DecodeKeyTextBox.TabIndex = 14;
            this.DecodeKeyTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "key";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 409);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "input";
            // 
            // CypherTextBox
            // 
            this.CypherTextBox.Location = new System.Drawing.Point(101, 409);
            this.CypherTextBox.Name = "CypherTextBox";
            this.CypherTextBox.Size = new System.Drawing.Size(291, 22);
            this.CypherTextBox.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(98, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Encoder";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(98, 349);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Decoder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(592, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "برای کپی کردن انکود ها ، روی آن ها کلیک کنید";
            // 
            // UseForEncodeSubStitution
            // 
            this.UseForEncodeSubStitution.AutoSize = true;
            this.UseForEncodeSubStitution.Location = new System.Drawing.Point(596, 132);
            this.UseForEncodeSubStitution.Name = "UseForEncodeSubStitution";
            this.UseForEncodeSubStitution.Size = new System.Drawing.Size(208, 21);
            this.UseForEncodeSubStitution.TabIndex = 25;
            this.UseForEncodeSubStitution.Text = "Use SubStitution for Encode";
            this.UseForEncodeSubStitution.UseVisualStyleBackColor = true;
            // 
            // UseForDecodeSubStitution
            // 
            this.UseForDecodeSubStitution.AutoSize = true;
            this.UseForDecodeSubStitution.Location = new System.Drawing.Point(584, 384);
            this.UseForDecodeSubStitution.Name = "UseForDecodeSubStitution";
            this.UseForDecodeSubStitution.Size = new System.Drawing.Size(209, 21);
            this.UseForDecodeSubStitution.TabIndex = 26;
            this.UseForDecodeSubStitution.Text = "Use SubStitution for Decode";
            this.UseForDecodeSubStitution.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Encode With Transposition";
            // 
            // EncodeWithTranspositionLabel
            // 
            this.EncodeWithTranspositionLabel.AutoSize = true;
            this.EncodeWithTranspositionLabel.Location = new System.Drawing.Point(410, 245);
            this.EncodeWithTranspositionLabel.Name = "EncodeWithTranspositionLabel";
            this.EncodeWithTranspositionLabel.Size = new System.Drawing.Size(56, 17);
            this.EncodeWithTranspositionLabel.TabIndex = 28;
            this.EncodeWithTranspositionLabel.Text = "Encode";
            this.EncodeWithTranspositionLabel.Visible = false;
            this.EncodeWithTranspositionLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EncodeWithTranspositionLabel_MouseDown);
            // 
            // TranspositionCheckBox
            // 
            this.TranspositionCheckBox.AutoSize = true;
            this.TranspositionCheckBox.Location = new System.Drawing.Point(596, 201);
            this.TranspositionCheckBox.Name = "TranspositionCheckBox";
            this.TranspositionCheckBox.Size = new System.Drawing.Size(218, 21);
            this.TranspositionCheckBox.TabIndex = 29;
            this.TranspositionCheckBox.Text = "Use Transposition for Encode";
            this.TranspositionCheckBox.UseVisualStyleBackColor = true;
            // 
            // UseForDecodeTransposition
            // 
            this.UseForDecodeTransposition.AutoSize = true;
            this.UseForDecodeTransposition.Location = new System.Drawing.Point(584, 432);
            this.UseForDecodeTransposition.Name = "UseForDecodeTransposition";
            this.UseForDecodeTransposition.Size = new System.Drawing.Size(219, 21);
            this.UseForDecodeTransposition.TabIndex = 30;
            this.UseForDecodeTransposition.Text = "Use Transposition for Decode";
            this.UseForDecodeTransposition.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 579);
            this.Controls.Add(this.UseForDecodeTransposition);
            this.Controls.Add(this.TranspositionCheckBox);
            this.Controls.Add(this.EncodeWithTranspositionLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UseForDecodeSubStitution);
            this.Controls.Add(this.UseForEncodeSubStitution);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DecodeKey);
            this.Controls.Add(this.DecodeButton);
            this.Controls.Add(this.DecodeKeyTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CypherTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EncodeSubStitution);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EncodeLabel);
            this.Controls.Add(this.EncodeButton);
            this.Controls.Add(this.KeyInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.KeyInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecodeKeyTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown KeyInput;
        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.Label EncodeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EncodeSubStitution;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label DecodeKey;
        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.NumericUpDown DecodeKeyTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CypherTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox UseForEncodeSubStitution;
        private System.Windows.Forms.CheckBox UseForDecodeSubStitution;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label EncodeWithTranspositionLabel;
        private System.Windows.Forms.CheckBox TranspositionCheckBox;
        private System.Windows.Forms.CheckBox UseForDecodeTransposition;
    }
}

