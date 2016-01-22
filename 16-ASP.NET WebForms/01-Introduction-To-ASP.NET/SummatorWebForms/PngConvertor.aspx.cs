namespace SummatorWebForms
{
    using System;
    using System.Web;

    public partial class PngConvertor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var text = this.GetTextToConvert(this.Request.Params["text"]);
            this.SetConvertedImage(text);
        }

        protected void ButtonConvert_Click(object sender, EventArgs e)
        {
            string text = this.GetTextToConvert(this.TextBoxInput.Text);
            this.SetConvertedImage(text);
        }

        private string GetTextToConvert(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return "Text As Image";
            }
            else
            {
                return text;
            }
        }

        private void SetConvertedImage(string text)
        {
            this.ImageResult.ImageUrl = "ConvertTextToImage.ashx?text=" + HttpContext.Current.Server.UrlEncode(text);
        }
    }
}