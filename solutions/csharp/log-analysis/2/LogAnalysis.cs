public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string log, string delimiter) {
        return log.Split(delimiter, 2)[1];
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string log, string firstMark, string lastMark) {
        int start = log.IndexOf(firstMark) + firstMark.Length;
        int end = log.IndexOf(lastMark);
        return log.Substring(start, end - start).Trim();
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string log) {
        return log.Split(":", 2)[1].Trim();
    }
    
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string log) {
        string[] parts = log.Split(":", 2);
        return parts[0].Substring(1, (int)parts[0].Length - 2);
    }
}