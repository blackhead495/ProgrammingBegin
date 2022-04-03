// Программа - Часы

string[,] SymbolArray = 
{
    {
        " @@@  ", // 0
        "@   @ ",
        "@  @@ ",
        "@ @ @ ",
        "@@  @ ",
        "@   @ ",
        " @@@  ",
        "      "
    },
    {
        "   @  ", // 1
        "  @@  ",
        " @ @  ",
        "   @  ",
        "   @  ",
        "   @  ",
        "   @  ",
        "      "
    },
    {
        " @@@  ", // 2
        "@   @ ",
        "    @ ",
        "   @  ",
        "  @   ",
        " @    ",
        "@@@@@ ",
        "      "
    },
    {
        " @@@  ", // 3
        "@   @ ",
        "    @ ",
        "  @@  ",
        "    @ ",
        "@   @ ",
        " @@@  ",
        "      "
    },
    {
        "   @@ ", // 4
        "  @ @ ",
        " @  @ ",
        "@   @ ",
        "@@@@@ ",
        "    @ ",
        "    @ ",
        "      "
    },
    {
        "@@@@@ ", // 5
        "@     ",
        "@     ",
        "@@@@  ",
        "    @ ",
        "    @ ",
        "@@@@  ",
        "      "
    },
    {
        " @@@  ", // 6
        "@   @ ",
        "@     ",
        "@@@@  ",
        "@   @ ",
        "@   @ ",
        " @@@  ",
        "      "
    },
    {
        "@@@@@ ", // 7
        "    @ ",
        "    @ ",
        "   @  ",
        "  @   ",
        "  @   ",
        "  @   ",
        "      "
    },
    {
        " @@@  ", // 8
        "@   @ ",
        "@   @ ",
        " @@@  ",
        "@   @ ",
        "@   @ ",
        " @@@  ",
        "      "
    },
    {
        " @@@  ", // 9
        "@   @ ",
        "@   @ ",
        " @@@@ ",
        "    @ ",
        "@   @ ",
        " @@@  ",
        "      "
    },
    {
        "      ", // :
        "      ",
        "  @   ",
        "      ",
        "      ",
        "  @   ",
        "      ",
        "      "
    }
};

var lastDateTime = DateTime.Now;
var curDateTime  = new DateTime();

var Watch = "\n";

while (true)        
{
    curDateTime = DateTime.Now;
    if (lastDateTime.Second != curDateTime.Second)
    {
        lastDateTime = curDateTime;
        
        Watch = "\n";
        
        // Сформировать одну строку, с включением символов перевода строки
        for (int i = 0; i < 8; i++)
        {
            Watch += SymbolArray[curDateTime.Hour / 10, i];     // Часы
            Watch += SymbolArray[curDateTime.Hour % 10, i];     // Часы
            Watch += SymbolArray[10, i];                        // Двоеточие
            
            Watch += SymbolArray[curDateTime.Minute / 10, i];   // Минуты
            Watch += SymbolArray[curDateTime.Minute % 10, i];   // Минуты
            Watch += SymbolArray[10, i];                        // Двоеточие
            
            Watch += SymbolArray[curDateTime.Second / 10, i];   // Секунды
            Watch += SymbolArray[curDateTime.Second % 10, i];   // Секунды
            Watch += "\n";  
        }
        
        Console.Clear();
        Console.WriteLine(Watch);
    }
    else
    {
        Thread.Sleep(100);
    }
    
}
