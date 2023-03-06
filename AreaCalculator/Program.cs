//-(分析)大方向：
//    1.使用者輸入（互動）
//    2.邏輯（寫在Room這個類別裡面)
//      unit : feet or meters(field)
//      length(field)
//      wide(field)
//      area = length * width
//      conversionRate = 0.09290304
//      see if it’s feet : square meters = conversionRate * square feet
//      it’s meters : square feet = square meters/conversionRate
//    3.系統呈現內容（會變化的內容 長、寬、面積
//- 邏輯的部份，如果換單位、單位所乘的數字變了  重複內容太多要改太多地方了。如何消除重複
//- 物件導向：真實世界的物件，抽象成程式導向的類別屬性。
//物件的關鍵字”new”寫出A物件、再new出B物件

using AreaCalculator;

var usersRoom = new Room(1,2,"feet");

Console.WriteLine("Enter \"feet\" or \"meters\" you want to use in calculating area.");
usersRoom.Unit = Console.ReadLine();
if (usersRoom.MustFeetOrMeters(usersRoom.Unit) ==true)
{
    Console.WriteLine($"What is the length of the room in {usersRoom.Unit}?");
    string length = Console.ReadLine();
    Console.WriteLine($"What is the width of the room in {usersRoom.Unit}?");
    string width = Console.ReadLine();

    usersRoom.IfLengthWidthIsNumberCalculateArea(length, width);
}