namespace SummatorWebForms
{
    using System;
    
    public partial class Summator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ButtonSum_Click(object sender, EventArgs e)
        {
            var firstNumber = double.Parse(this.TextBoxFirstNumber.Text);
            var secondNumber = double.Parse(this.TextBoxSecondNumber.Text);

            var sum = firstNumber + secondNumber;

            this.TextBoxSum.Text = sum.ToString();
        }
    }
}