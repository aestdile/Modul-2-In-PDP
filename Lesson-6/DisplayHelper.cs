namespace Lesson6InModule2
{ 
    public static class DisplayHelper
    {
        public static void PrintSection(string title, Action testMethod)
        {
            string separator = new string('-', 140);
            GradientPrinter.PrintAnsiGradientText(separator);
            GradientPrinter.PrintAnsiGradientText(GradientPrinter.StringCentered(title));
            GradientPrinter.PrintAnsiGradientText(separator);
            testMethod.Invoke();
        }

        public static void PrintFooter()
        {
            string separator = new string('-', 140);
            GradientPrinter.PrintAnsiGradientText(separator);
            GradientPrinter.PrintAnsiGradientText(GradientPrinter.StringCentered("Program is finished!!!"));
            GradientPrinter.PrintAnsiGradientText(GradientPrinter.StringCentered("Created via Mukhtor Eshboyev"));
            GradientPrinter.PrintAnsiGradientText(separator);
            GradientPrinter.PrintAnsiGradientText(GradientPrinter.StringCentered("Social Networks:"));
            GradientPrinter.PrintAnsiGradientText(GradientPrinter.StringCentered("📌 Telegram: t.me/aestdile"));
            GradientPrinter.PrintAnsiGradientText(GradientPrinter.StringCentered("🐱 GitHub: github.com/aestdile"));
            GradientPrinter.PrintAnsiGradientText(GradientPrinter.StringCentered("💡 LeetCode: leetcode.com/aestdile"));
            GradientPrinter.PrintAnsiGradientText(GradientPrinter.StringCentered("🔗 LinkedIn: linkedin.com/in/aestdile"));
            GradientPrinter.PrintAnsiGradientText(GradientPrinter.StringCentered("▶ YouTube: youtube.com/@aestdile"));
            GradientPrinter.PrintAnsiGradientText(GradientPrinter.StringCentered("📷 Instagram: instagram.com/aestdile"));
            GradientPrinter.PrintAnsiGradientText(GradientPrinter.StringCentered("📘 Facebook: facebook.com/aestdile"));
            GradientPrinter.PrintAnsiGradientText(GradientPrinter.StringCentered("📧 E-mail: aestdile@gmail.com"));
        }
    }
}
