using System.Text.Json;

namespace FrenchVerbes.Verbes;

public static class ExampleSentencesRepository
{
    private static readonly Dictionary<string, Dictionary<string, List<string>>> _cache = new();
    private static readonly Random _random = new();
    private const string BaseFolderName = "Sentences";
    private const string FileExtension = ".json";

    public static List<string> GetRandomSentences(string verb, string tense, int count = 2)
    {
        verb = verb.ToLower().Trim();

        if (!_cache.ContainsKey(verb))
        {
            LoadVerbJson(verb);
        }

        if (_cache.TryGetValue(verb, out var tenses) && 
            tenses.TryGetValue(tense, out var sentences) && 
            sentences.Any())
        {
            return sentences.OrderBy(_ => _random.Next()).Take(count).ToList();
        }

        return new List<string>();
    }

    private static void LoadVerbJson(string verb)
    {
        // Root directory for all sentence JSONs
        string baseDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, BaseFolderName);
        
        if (!Directory.Exists(baseDir))
        {
            // This goes up from bin/Debug/net10.0/ to the project root
            string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", ".."));
            baseDir = Path.Combine(projectRoot, BaseFolderName);
        }

        if (!Directory.Exists(baseDir))
        {
            _cache[verb] = new Dictionary<string, List<string>>();
            return;
        }

        // Search recursively for the verb file (handles IrregularVerbes, RegularVerbes/Er, etc.)
        string[] files = Directory.GetFiles(baseDir, $"{verb}{FileExtension}", SearchOption.AllDirectories);

        if (files.Length == 0)
        {
            _cache[verb] = new Dictionary<string, List<string>>();
            return;
        }

        try
        {
            // Pick the first match found
            string jsonContent = File.ReadAllText(files[0]);
            var data = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(jsonContent);
            _cache[verb] = data ?? new Dictionary<string, List<string>>();
        }
        catch
        {
            _cache[verb] = new Dictionary<string, List<string>>();
        }
    }
}