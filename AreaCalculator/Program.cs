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



//var usersRoom = new Room(1,2,"feet");//不應該在這裡就先new建room，在有長寬單位時再建立就好

string wrongMessage = " Wrong Message：You have to follow the instruction. Please try again.";
Console.WriteLine(@"Enter ""feet"" or ""meters"" you want to use in calculating area.");
string unit = Console.ReadLine();

//重構：不要巢狀迴圈，將會顯示wrongMessage的情況一個個寫出來1.單位並非輸入UnitOfArea 2.長寬並非輸入數字

if (unit!=UnitOfArea.Meters.ToString().ToLower()&& unit!=UnitOfArea.Feet.ToString().ToLower())//我本來用"或"應該用"且"
{
    Console.WriteLine(wrongMessage);
    return;//我本來沒有加所以就算錯了還是會繼續跑，加了才能停止程式。
}

Console.WriteLine($"What is the length of the room in {unit}?");
var length = Console.ReadLine();
if(double.TryParse(length, out var resultLength)==false)
{
    Console.WriteLine(wrongMessage);
    return;
}

Console.WriteLine($"What is the width of the room in {unit}?");
var width = Console.ReadLine();
if(double.TryParse(width, out var resultWidth)==false)
{
    Console.WriteLine(wrongMessage);
    return;
}

Room room = new Room(resultLength, resultWidth,unit);

//這裡不小心把建構式寫成方法所以一直錯。
//原來不用放入東西就可以計算出area。原來建構式可以這樣使用。
string template = $@"You entered dimensions of {length} {unit} by {width} {unit}.
Area is {room.GetFeet}square feet.
Area is {room.GetMeter}square meters.";

Console.WriteLine(template);

//if (unit is "feet" or "meters")//unit=="feet"||unit=="meters"
//{
//    Console.WriteLine($"What is the length of the room in {unit}?");
//    string length = Console.ReadLine();

//    Console.WriteLine($"What is the width of the room in {unit}?");
//    string width = Console.ReadLine();

//    double resultLength, resultWidth;
//    if (double.TryParse(length, out resultLength))
//    {
//        if (double.TryParse(width, out resultWidth))
//        {
//            var usersRoom = new Room(resultLength, resultWidth, unit);

//            Console.WriteLine($"You entered dimensions of {length} {unit} by {width} {unit}.");
            
//            Console.WriteLine($"The area is \n{usersRoom.Area} square {Unit}");//最後這個單位不知道怎麼樣才能叫出另外一個
//        }
//        else
//        {
//            Console.WriteLine(wrongMessage);
//        }
//    }
//    else
//    {
//        Console.WriteLine(wrongMessage);
//    }
//}
//Console.WriteLine(wrongMessage);


//if (usersRoom.MustFeetOrMeters(usersRoom.Unit) ==true)//判斷使用者是否打錯東西應該放在與使用者互動的Program，而不是放在room
//{
    
//}