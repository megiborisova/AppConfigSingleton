using System;

class Program
{
    static void Main(string[] args)
    {
        AppConfig config = AppConfig.Instance;

        config.Language = "bg";
        config.IsDebugMode = true;
        config.LogFilePath = "C:\\logs\\mainlog.txt";

        Console.WriteLine("Language: " + config.Language);
        Console.WriteLine("Debug mode: " + config.IsDebugMode);
        Console.WriteLine("Log file: " + config.LogFilePath);

        AppConfig.PrintDefaultLanguage();

        config.ShowInternalUsage();
    }
}
