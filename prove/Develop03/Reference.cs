public class Reference
{
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int Verse { get; private set; }
    public int? EndVerse { get; private set; }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = null;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = endVerse;
    }

    public Reference(string reference)
    {
        // Example: "Proverbs 3:5-6" or "John 3:16"
        string[] parts = reference.Split(' ');
        Book = string.Join(" ", parts.Take(parts.Length - 1));
        string chapterVerse = parts.Last();

        string[] chapterAndVerse = chapterVerse.Split(':');
        Chapter = int.Parse(chapterAndVerse[0]);

        if (chapterAndVerse[1].Contains('-'))
        {
            var verseParts = chapterAndVerse[1].Split('-');
            Verse = int.Parse(verseParts[0]);
            EndVerse = int.Parse(verseParts[1]);
        }
        else
        {
            Verse = int.Parse(chapterAndVerse[1]);
            EndVerse = null;
        }
    }

    public override string ToString()
    {
        return EndVerse.HasValue ?
            $"{Book} {Chapter}:{Verse}-{EndVerse}" :
            $"{Book} {Chapter}:{Verse}";
    }
}
