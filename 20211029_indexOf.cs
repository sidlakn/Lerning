const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";
int banana = input.IndexOf("<span>");
int peach = input.IndexOf("</span>");

banana += 6;
int lenght = peach - banana;
string test = input.Substring(banana, lenght);
Console.WriteLine(quantity);
Console.WriteLine(output);
Console.WriteLine(test);

int cucumber = input.IndexOf("<div>");
int melon = input.IndexOf("</div>");

cucumber += 5;
int lenght2 = melon - cucumber;
string test2 = input.Substring(cucumber, lenght2);
Console.WriteLine(test2);
