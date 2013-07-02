using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Magic8
{
    public partial class _Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void fortuneButton_Click(object sender, EventArgs e)
        {
            FortuneGenerator.generateFortune(fortuneTextBox, countLabel);
        }
    }

    public class FortuneGenerator
    {
        static string[] fortunes = {
                                "It is certain",
                                "It is decidedly so",
                                "Without a doubt",
                                "Yes definitely",
                                "You may rely on it",
                                "As I see it yes",
                                "Most likely",
                                "Outlook good",
                                "Yes",
                                "Signs point to yes",
                                "Reply hazy try again",
                                "Ask again later",
                                "Better not tell you now",
                                "Cannot predict now",
                                "Concentrate and ask again",
                                "Don't count on it",
                                "My reply is no",
                                "My sources say no",
                                "Outlook not so good",
                                "Very doubtful"};
        static Random generator;
        static int fortuneCount;

        public static void generateFortune(TextBox fortuneTextBox, Label countLabel)
        {
            generator = new Random();
            int fortune = generator.Next(0, 20);
            fortuneTextBox.Text = fortunes[fortune].ToString();
            fortuneCount++;
            countLabel.Text = String.Format("Fortunes given: {0}", fortuneCount);
        }
    }
}
