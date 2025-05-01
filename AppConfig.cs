using System;

public class AppConfig
{
    private static AppConfig? instance;
    private static readonly object lockObj = new object();

    private AppConfig()
    {
        Language = DefaultLanguage;
        IsDebugMode = false;
        LogFilePath = "log.txt";
    }

    public const string DefaultLanguage = "en";

    public string Language { get; set; }
    public bool IsDebugMode { get; set; }
    public string LogFilePath { get; set; }

    public static AppConfig Instance
    {
        get
        {
            lock (lockObj)
            {
                if (instance == null)
                    instance = new AppConfig();
                return instance;
            }
        }
    }

    public static void PrintDefaultLanguage()
    {
        Console.WriteLine($"Default language is: {DefaultLanguage}");
    }

    private class Info
    {
        public string Details { get; }

        public Info(string details)
        {
            Details = details;
        }

        public void Show()
        {
            Console.WriteLine($"[INFO] {Details}");
        }
    }

    public void ShowInternalUsage()
    {
        var info = new Info("This message comes from the nested class.");
        info.Show();
    }
}
