using System;
using System.Web.UI;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        this.PageLabel.Text = $"2 + 2 = {MathClass.Add(2, 2)}";
    }
}