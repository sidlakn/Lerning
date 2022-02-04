// SKU = Stock Keeping Unit
string sku = "01-MN-10";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (01)
{
    case 01:
    type = "Sweat shirt";
    break;
     case 02:
    type = "T-Shirt";
    break;
       case 03:
    type = "Sweat pants";
    break;
}
switch (100)
{
    case 100:
    color = "Black";
    break; 
    case 200:
    color = "Maroon";
    break;
}
switch (10)
{
    case 10:
    size = "Small";
    break;
    case 20:
    size = "Medium";
    break;
    case 30:
    size = "Large";
    break;
}

Console.WriteLine($"Product: {size} {color} {type}");
