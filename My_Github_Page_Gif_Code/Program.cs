namespace My_Github_Page_Gif_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            // Starter Sleep
            Thread.Sleep(3000);

            LoadingScreen("Loading");

            IntroText(" Hello, My Name is Mohamed Hamed.\n I am a DotNet Developer.\n WELCOME TO MY GITHUB PROFILE.", 200);

            // Print a new line at the end
            Thread.Sleep(200);
            Console.WriteLine();
            LoadingScreen("Press Start To Continue");
        }
        static void LoadingScreen(string word)
        {
            Console.Write(word);
            Console.CursorVisible = false;
            // Loop for three times
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(200);
                }
                // reset dots
                Console.Write("\x1B[3D");
                Console.Write("\x1B[3P");
                Thread.Sleep(300);
            }
            // reset the whole console
            Console.Write($"\x1B[{word.Length}D");
            Console.Write($"\x1B[{word.Length}7P");
        }
        public static void IntroText(string text, int latency)
        {
            latency = 100;
            // Loop through each character in the text
            foreach (char c in text)
            {
                // Print the character to the console
                Console.Write(c);

                // Wait for the latency duration
                Thread.Sleep(latency);
            }
        }
    }
}