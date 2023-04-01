using System;

class Program
{
    static void Main(string[] args)
    {
        //Lecture Event
        Address a1 = new Address("1300 Bingham Blvd", "Salt Lake City", "UT", "84123");
        Lecture lecture = new Lecture("Lecture", "Understanding Polynesian Culture", "Discover the ways our ancestors " +
                            "navigated the past and prepare for the future.", "April 26, 2023", "6pm", a1, "Samuela Teni", "125");
        Console.WriteLine("------ Standard Details ------");
        lecture.GetStandardDetail();
        Console.WriteLine("------- Full Details: -------");
        lecture.GetFullDetail();
        Console.WriteLine("----- Short Description: ------");
        lecture.GetShortDescription();

        //Reception Event
        Address a2 = new Address("8700 Sunnyvale Drive", "West Jordan", "UT", "84088");
        Reception reception = new Reception("Reception", "Evelyn's Baby Shower", "Join us in celebrating and showering Evelyn " +
                            "and her bun in the oven.", "May 12, 2023", "3:30pm", a2, "babyshowers@nowhere.com");
        Console.WriteLine("------ Standard Details ------");
        reception.GetStandardDetail();
        Console.WriteLine("------- Full Details: -------");
        reception.GetFullDetail();
        Console.WriteLine("----- Short Description: ------");
        reception.GetShortDescription();

        //Outdoor Event
        Address a3 = new Address("11418 Noelani Drive", "South Jordan", "UT", "84095");
        Outdoor outdoor = new Outdoor("Outdoor", "Danny & May's Engagement", "Dance under the stars while we celebrate " +
                            "the engagement of Danny & May.", "June 10, 2023", "8pm", a3, "Clear 79");
        Console.WriteLine("------ Standard Details ------");
        outdoor.GetStandardDetail();
        Console.WriteLine("------- Full Details: -------");
        outdoor.GetFullDetail();
        Console.WriteLine("----- Short Description: ------");
        outdoor.GetShortDescription();
    }
}