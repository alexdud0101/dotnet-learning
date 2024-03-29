namespace WinFormApp;

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
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";

        TextBox textBox1 = new TextBox();
        textBox1.Text = "Type your name";
        textBox1.Name = "textBox";
        textBox1.KeyDown += Form_KeyDown;
        textBox1.Location = new Point(100, 60);
        textBox1.Width = 200;
        this.Controls.Add(textBox1);

        Label label1 = new Label();
        // Устанавливаем текст для отображения
        label1.Text = "";
        label1.Name = "label1";
        label1.Location = new Point(100,100);
        label1.AutoSize = true;
        // Добавляем label на нашу форму
        this.Controls.Add(label1);
    }

    #endregion
}
