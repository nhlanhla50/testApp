using ClassLibrary1;

namespace WinFormsApp3;

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
        lbel1 = new Label();
        FirstNameText = new TextBox();
        LastNameText = new TextBox();
        label1 = new Label();
        IDnumberText = new TextBox();
        label2 = new Label();
        CourseNameText = new TextBox();
        label3 = new Label();
        CellPhoneNumText = new TextBox();
        label4 = new Label();
        button1 = new Button();
        SuspendLayout();
        // 
        // lbel1
        // 
        lbel1.AutoSize = true;
        lbel1.Location = new Point(6, 13);
        lbel1.Name = "lbel1";
        lbel1.Size = new Size(60, 13);
        lbel1.TabIndex = 0;
        lbel1.Text = "First name";
        lbel1.Click += label1_Click;
        // 
        // FirstNameText
        // 
        FirstNameText.Location = new Point(93, 10);
        FirstNameText.Name = "FirstNameText";
        FirstNameText.Size = new Size(176, 22);
        FirstNameText.TabIndex = 1;
        FirstNameText.TextChanged += FirstNameText_TextChanged;
        // 
        // LastNameText
        // 
        LastNameText.Location = new Point(93, 50);
        LastNameText.Name = "LastNameText";
        LastNameText.Size = new Size(176, 22);
        LastNameText.TabIndex = 3;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(6, 53);
        label1.Name = "label1";
        label1.Size = new Size(62, 13);
        label1.TabIndex = 2;
        label1.Text = "Last Name ";
        label1.UseMnemonic = false;
        // 
        // IDnumberText
        // 
        IDnumberText.Location = new Point(93, 109);
        IDnumberText.Name = "IDnumberText";
        IDnumberText.Size = new Size(176, 22);
        IDnumberText.TabIndex = 5;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(6, 112);
        label2.Name = "label2";
        label2.Size = new Size(62, 13);
        label2.TabIndex = 4;
        label2.Text = "ID Number";
        label2.UseMnemonic = false;
        // 
        // CourseNameText
        // 
        CourseNameText.Location = new Point(93, 164);
        CourseNameText.Name = "CourseNameText";
        CourseNameText.Size = new Size(176, 22);
        CourseNameText.TabIndex = 7;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(6, 166);
        label3.Name = "label3";
        label3.Size = new Size(43, 13);
        label3.TabIndex = 6;
        label3.Text = "Course";
        label3.UseMnemonic = false;
        // 
        // CellPhoneNumText
        // 
        CellPhoneNumText.Location = new Point(93, 228);
        CellPhoneNumText.Name = "CellPhoneNumText";
        CellPhoneNumText.Size = new Size(176, 22);
        CellPhoneNumText.TabIndex = 10;
        CellPhoneNumText.TextChanged += CellPhoneNumText_TextChanged;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(6, 231);
        label4.Name = "label4";
        label4.Size = new Size(89, 13);
        label4.TabIndex = 10;
        label4.Text = "Cell Phone Num";
        label4.UseMnemonic = false;
        // 
        // button1
        // 
        button1.Location = new Point(139, 328);
        button1.Name = "button1";
        button1.Size = new Size(155, 31);
        button1.TabIndex = 10;
        button1.Tag = "combineName";
        button1.Text = "CombainName";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(578, 424);
        Controls.Add(button1);
        Controls.Add(CellPhoneNumText);
        Controls.Add(label4);
        Controls.Add(CourseNameText);
        Controls.Add(label3);
        Controls.Add(IDnumberText);
        Controls.Add(label2);
        Controls.Add(LastNameText);
        Controls.Add(label1);
        Controls.Add(FirstNameText);
        Controls.Add(lbel1);
        Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbel1;
    private TextBox FirstNameText;
    private TextBox LastNameText;
    private Label label1;
    private TextBox IDnumberText;
    private Label label2;
    private TextBox CourseNameText;
    private Label label3;
    private TextBox CellPhoneNumText;
    private Label label4;
    private Button button1;

}
