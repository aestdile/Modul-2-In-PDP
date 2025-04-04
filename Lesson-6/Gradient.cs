
namespace Lesson6InModule2
{
    public static class GradientPrinter
    {
        public static void PrintAnsiGradientText(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                int r = 255 - (i * 10) % 255;
                int g = (i * 5) % 255;
                int b = (i * 15) % 255;

                Console.Write($"\u001b[38;2;{r};{g};{b}m{text[i]}");
            }
            Console.WriteLine("\u001b[0m");
        }

        public static void PrintGradientResult(string result)
        {
            PrintAnsiGradientText("➝ " + result);
        }

        public static string StringCentered(string text)
        {
            int width = Console.WindowWidth;
            int padding = (width - text.Length) / 2;
            return new string(' ', Math.Max(padding, 0)) + text;
        }
    }
}
