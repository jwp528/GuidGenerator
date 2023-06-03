const int MAX_ALLOWABLE_GUIDS = 10_000;
int guidsToGenerate = 1;

if(args.Length > 0)
{
    guidsToGenerate = int.Parse(args[0]);
}

if(guidsToGenerate < 1)
{
    Console.WriteLine("must generate at least 1 guid");
    guidsToGenerate = 1;
}

if(guidsToGenerate > MAX_ALLOWABLE_GUIDS)
{
    Console.WriteLine($"Cannot generate more than {MAX_ALLOWABLE_GUIDS} Guids at a time.");
    guidsToGenerate = MAX_ALLOWABLE_GUIDS;
}

string toClipboard = string.Empty;

// Not sure why anyone would ever need to generate this many, but it was interesting to see how Parallel.For works
if (guidsToGenerate > 1000)
{
    Parallel.For(0, guidsToGenerate, i =>
    {
        Guid guid = Guid.NewGuid();
        
        if(i == 0)
        {
            toClipboard = guid.ToString();
        }

        // Console.WriteLine($"{++i}: {Guid.NewGuid().ToString()}");
        Console.WriteLine(guid);
    });
}
else
{
    for(int i = 0; i < guidsToGenerate; ++i)
    {
        Guid guid = Guid.NewGuid();

        if(i == 0)
        {
            toClipboard = guid.ToString();
        }

        // Console.WriteLine($"{++i}: {guid}");
        Console.WriteLine(guid);
    }
}

TextCopy.ClipboardService.SetText(toClipboard);
Console.WriteLine($"\nGuid copied to clipboard.");