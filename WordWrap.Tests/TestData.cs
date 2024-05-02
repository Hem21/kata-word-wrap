namespace WordWrap;

public class TestData
{
    public const string ShortText = "This is a short story.";
    
    public const int ShortTextLength = 22;

    public const string ShortTextWrappedAtColumnWidthOf6 = "This \nis a \nshort \nstory.";
    
    public const string ShortTextWrappedAtColumnWidthOf5 = "This \nis a \nshort\n \nstory\n.";
    
    public const string ShortTextWrappedAtColumnWidthOf4 = "This\n is \na \nshor\nt \nstor\ny.";

    public const string ShortTextWrappedAtColumnWidthOf1 =
        "T\nh\ni\ns\n \ni\ns\n \na\n \ns\nh\no\nr\nt\n \ns\nt\no\nr\ny\n.";

    
    
    
    public const string Text =
        "This is a story about how my life got twisted upside down and I moved to a place known as bell-air.";
    
    public const int TextLength = 99;

    public const string TextWrappedAtColumnWidthOf10 =
        "This is a \nstory \nabout how \nmy life \ngot \ntwisted \nupside \ndown and \nI moved \nto a \nplace \nknown as \nbell-air.";
    
    public const string TextWrappedAtColumnWidthOf8 =
        "This is \na story \nabout \nhow my \nlife \ngot \ntwisted \nupside \ndown \nand I \nmoved \nto a \nplace \nknown \nas \nbell-air\n.";

    public const string TextWrappedAtColumnWidthOf7 =
        "This \nis a \nstory \nabout \nhow my \nlife \ngot \ntwisted\n upside \ndown \nand I \nmoved \nto a \nplace \nknown \nas \nbell-ai\nr.";
}