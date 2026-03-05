static class LogLine
{
    public static string Message(string logLine)
    {
        string[] parts = logLine.Split(':', 2);
        return parts[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        string[] parts = logLine.Split(':', 2);
        string trimmed = parts[0].Substring(1, parts[0].Length - 2);
        return trimmed.ToLower();
    }

    public static string Reformat(string logLine)
    {
        string[] parts = logLine.Split(':', 2);
        string trimmed = parts[0].Substring(1, parts[0].Length - 2);
        return $"{parts[1].Trim()} ({trimmed.ToLower()})";
    }
}
