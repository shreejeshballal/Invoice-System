namespace SHRBA.Invoicing.WinClient.Products
{
    partial class ProductEditForm
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
            label5 = new Label();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(459, 71);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 34;
            label5.Text = "Category";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(561, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 33;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(184, 267);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(201, 31);
            textBox4.TabIndex = 32;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 267);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 31;
            label4.Text = "Price";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 31);
            textBox2.TabIndex = 30;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 124);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 29;
            label2.Text = "Description";
            // 
            // button1
            // 
            button1.Location = new Point(207, 351);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 28;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(184, 201);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(201, 31);
            textBox3.TabIndex = 27;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 31);
            textBox1.TabIndex = 26;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 201);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 25;
            label3.Text = "Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 65);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 24;
            label1.Text = "Name";
            // 
            // button2
            // 
            button2.Location = new Point(58, 351);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 35;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ProductEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "ProductEditForm";
            Text = "ProductEditForm";
            Load += ProductEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label3;
        private Label label1;
        private Button button2;
    }
}