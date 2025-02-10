namespace WinFormsApp1;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        textBox1 = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        checkBox1 = new System.Windows.Forms.CheckBox();
        checkBox2 = new System.Windows.Forms.CheckBox();
        checkBox3 = new System.Windows.Forms.CheckBox();
        contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
        radioButton1 = new System.Windows.Forms.RadioButton();
        radioButton2 = new System.Windows.Forms.RadioButton();
        listBox1 = new System.Windows.Forms.ListBox();
        textBox2 = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        comboBox1 = new System.Windows.Forms.ComboBox();
        label4 = new System.Windows.Forms.Label();
        textBox3 = new System.Windows.Forms.TextBox();
        textBox4 = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(132, 44);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(155, 23);
        textBox1.TabIndex = 0;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
        label1.Location = new System.Drawing.Point(37, 44);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(89, 23);
        label1.TabIndex = 1;
        label1.Text = "Full Name";
        label1.Click += label1_Click;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
        label2.Location = new System.Drawing.Point(37, 95);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(89, 25);
        label2.TabIndex = 2;
        label2.Text = "Address";
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(119, 351);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(155, 33);
        button1.TabIndex = 4;
        button1.Text = "Submit";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // checkBox1
        // 
        checkBox1.Location = new System.Drawing.Point(315, 48);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new System.Drawing.Size(132, 19);
        checkBox1.TabIndex = 5;
        checkBox1.Text = "SPA - 500";
        checkBox1.UseVisualStyleBackColor = true;
        checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        // 
        // checkBox2
        // 
        checkBox2.Location = new System.Drawing.Point(315, 73);
        checkBox2.Name = "checkBox2";
        checkBox2.Size = new System.Drawing.Size(132, 19);
        checkBox2.TabIndex = 6;
        checkBox2.Text = "Massage - 300 ";
        checkBox2.UseVisualStyleBackColor = true;
        checkBox2.CheckedChanged += checkBox2_CheckedChanged;
        // 
        // checkBox3
        // 
        checkBox3.Location = new System.Drawing.Point(315, 99);
        checkBox3.Name = "checkBox3";
        checkBox3.Size = new System.Drawing.Size(132, 19);
        checkBox3.TabIndex = 7;
        checkBox3.Text = "Breakfast - 300";
        checkBox3.UseVisualStyleBackColor = true;
        checkBox3.CheckedChanged += checkBox3_CheckedChanged;
        // 
        // contextMenuStrip1
        // 
        contextMenuStrip1.Name = "contextMenuStrip1";
        contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
        // 
        // radioButton1
        // 
        radioButton1.Location = new System.Drawing.Point(469, 48);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new System.Drawing.Size(89, 31);
        radioButton1.TabIndex = 9;
        radioButton1.TabStop = true;
        radioButton1.Text = "Regular";
        radioButton1.UseVisualStyleBackColor = true;
        radioButton1.CheckedChanged += radioButton1_CheckedChanged;
        // 
        // radioButton2
        // 
        radioButton2.Location = new System.Drawing.Point(469, 85);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new System.Drawing.Size(89, 31);
        radioButton2.TabIndex = 10;
        radioButton2.TabStop = true;
        radioButton2.Text = "Senior 30%";
        radioButton2.UseVisualStyleBackColor = true;
        radioButton2.CheckedChanged += radioButton2_CheckedChanged;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 15;
        listBox1.Location = new System.Drawing.Point(315, 147);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(278, 109);
        listBox1.TabIndex = 11;
        listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(132, 95);
        textBox2.Multiline = true;
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(155, 57);
        textBox2.TabIndex = 12;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(442, 23);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(116, 22);
        label3.TabIndex = 13;
        label3.Text = "Type of Customer";
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "Economy - 1000", "Business - 2000", "Presidential - 3000" });
        comboBox1.Location = new System.Drawing.Point(132, 199);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(155, 23);
        comboBox1.TabIndex = 14;
        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(50, 174);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(196, 22);
        label4.TabIndex = 15;
        label4.Text = "Type of Accomodation";
        // 
        // textBox3
        // 
        textBox3.Location = new System.Drawing.Point(132, 244);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(155, 23);
        textBox3.TabIndex = 16;
        textBox3.TextChanged += textBox3_TextChanged;
        // 
        // textBox4
        // 
        textBox4.Location = new System.Drawing.Point(132, 284);
        textBox4.Name = "textBox4";
        textBox4.Size = new System.Drawing.Size(155, 23);
        textBox4.TabIndex = 17;
        textBox4.TextChanged += textBox4_TextChanged;
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
        label5.Location = new System.Drawing.Point(37, 242);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(89, 23);
        label5.TabIndex = 18;
        label5.Text = "# of days";
        label5.Click += label5_Click;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
        label6.Location = new System.Drawing.Point(13, 284);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(113, 23);
        label6.TabIndex = 19;
        label6.Text = "Downpayment";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(643, 574);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(textBox4);
        Controls.Add(textBox3);
        Controls.Add(label4);
        Controls.Add(comboBox1);
        Controls.Add(label3);
        Controls.Add(textBox2);
        Controls.Add(listBox1);
        Controls.Add(radioButton2);
        Controls.Add(radioButton1);
        Controls.Add(checkBox3);
        Controls.Add(checkBox2);
        Controls.Add(checkBox1);
        Controls.Add(button1);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(textBox1);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.ListBox listBox1;

    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton2;

    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox3;

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;

    #endregion
}