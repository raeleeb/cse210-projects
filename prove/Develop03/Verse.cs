using System;

public class Verse
{
    private string _verse;

    public Verse()
    {

    }

    public Verse(string verse)
    {
        _verse = verse;
    }

    public string GetVersePreSet1()
    {
        string mosiahTwoFourOne = "And moreover, I would desire that ye should consider on " +
                                    "the blessed and a happy state of those that keep the commandments of God. " +
                                    "For behold, they are blessed in all things, both temporal and spiritual; " +
                                    "and if they hold out faithful to the end they are received into heaven, " +
                                    "that thereby they may dwell with God in a state of never-ending happiness. " +
                                    "O remember, remember that these things are true; for the Lord God hath spoken it.\n";
        return mosiahTwoFourOne;
    }

    public string GetVersePreSet2()
    {
        string proverbsThreeFiveSix = "Trust in the Lord with all thine heart; and lean not unto thine own " +
                                    "understanding. In all thy ways acknowledge him, and he shall direct " +
                                    "thy paths.\n";
        return proverbsThreeFiveSix;
    }

    public string GetVerse()
    {
        return _verse;
    }
}
