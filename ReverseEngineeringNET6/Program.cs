using System.Text;
using ReverseEngineeringNET6.NotImportant;
using Spectre.Console;

Console.OutputEncoding = Encoding.UTF8;
AnsiConsole.Write(
    new FigletText("Reverse Engineering")
        .LeftAligned()
        .Color(Color.Green));
var rule = new Rule();
rule.Style = Style.Parse("green");
AnsiConsole.Write(rule);
Thread.Sleep(2000);

Console.WriteLine("\nWhat are you looking for here? My secrets are horribly written in\n");
Thread.Sleep(2000);

string[] unicode = { "u̵̡͎͒͛̅̐͒̒̿̋̚", "n̷̤̘̣͖͍͈͖̣̖̍̓̓͂͠", "i̷̭͉̰͉̣̟͙͈̟͗̈́̒͌̓̐͘", "c̵̢͈̝̆", "o̶̧̭̼̩̺̫̥̘̳̰̊̉̆̓͌̕̚", "d̷̤͎̰̑̃͂̌̕͘͠", "e̵̼̘̒̇̊" };

foreach (string character in unicode)
{
    Console.Write(character);
    Thread.Sleep(900);
}

Thread.Sleep(5000);

await AnsiConsole.Progress()
    .StartAsync(async ctx =>
    {
        var task1 = ctx.AddTask("[green][/]");
        var task2 = ctx.AddTask("[red]The Amount of Time You're Wasting Here[/]");

        while (!ctx.IsFinished)
        {
            await Task.Delay(250);

            task1.Increment(1.5);
            task2.Increment(1);
        }
    });
Thread.Sleep(2000);

AnsiConsole.WriteLine("\n\nWow you're still here.... Ummm... Ok...\n");
Thread.Sleep(3000);

var whoCares = AnsiConsole.Ask<string>("Would you like to have the secret [fuchsia]key[/]?");

var keyPath = new TotallyNotImportant();
var key = keyPath.TotallyNotTheKey();

Console.WriteLine("\nOk well then you'll need to schedule an appointment.");
Thread.Sleep(2000);
Console.WriteLine("Let me see what I have available...\n");
Thread.Sleep(5000);

var year = DateTime.Now.Year + new Random().Next(30, 50);
var month = DateTime.Now.Month;
var calendar = new Calendar(year, month);
calendar.AddCalendarEvent(year, month, new Random().Next(1, 29));
calendar.HighlightStyle(Style.Parse("yellow bold"));
calendar.HeaderStyle(Style.Parse("blue bold"));
AnsiConsole.Write(calendar);
Thread.Sleep(3000);

AnsiConsole.Markup("\nI can [italic]try[/] to squeeze you in on that date... ");
Thread.Sleep(2000);
Console.Write("but no promises.\n");
Thread.Sleep(7000);

AnsiConsole.MarkupLine("\nDon't you see all this hard work I put into building this Console App? I'm begging you to reverse engineer me " + Emoji.Known.BrokenHeart + "\n");
Thread.Sleep(10000);