using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Cooking Lasagna","Laura Locatelli",360);
        Comment c1v1 = new Comment("Srini","Thanks for the tips, it turned out really great.");
        Comment c2v1 = new Comment("Jerry May","Great fresh ingredients and authentic to taste.");
        Comment c3v1 = new Comment("Riccardo Galdi","Buonissimo!");
        v1._comments.Add(c1v1);
        v1._comments.Add(c2v1);
        v1._comments.Add(c3v1);
        v1.Display();

        Video v2 = new Video("Cake Techniques","Sara Muka",240);
        Comment c1v2 = new Comment("Mary Beth","Thanks for the suggestions, my son's bday cake was a hit.");
        Comment c2v2 = new Comment("Lee Johnson","What's playing in the background? I like the music.");
        Comment c3v2 = new Comment("Lynn Trent","The layers turned out flawless! Thanks for the tips.");
        Comment c4v2 = new Comment("SaraMichel","Where can I buy the scrapers you used?");
        v2._comments.Add(c1v2);
        v2._comments.Add(c2v2);
        v2._comments.Add(c3v2);
        v2._comments.Add(c4v2);
        v2.Display();

        Video v3 = new Video("Making Flower Leis","Sioana Mele",750);
        Comment c1v3 = new Comment("IslandFlowers","Great technique on the leis, mahalo for sharing!");
        Comment c2v3 = new Comment("Naite Pele","How many flowers should I buy for 5 leis?");
        Comment c3v3 = new Comment("Loisi Sevelo","Taahine fefe hake?");
        Comment c4v3 = new Comment("Sioana Mele","Oku sai pe, malo aupito ee");
        v3._comments.Add(c1v3);
        v3._comments.Add(c2v3);
        v3._comments.Add(c3v3);
        v3._comments.Add(c4v3);
        v3.Display();    
    }
}