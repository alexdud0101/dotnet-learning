using Lib;

namespace WinFormApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            var text = Controls.Find("textBox", true).FirstOrDefault() as TextBox;
            Label? label = Controls.Find("label1", true).FirstOrDefault() as Label;
            if (label != null && text != null)
            {
                label.Text = Time.AddTime("Hello " + text.Text);
            }
        }
    }
}
