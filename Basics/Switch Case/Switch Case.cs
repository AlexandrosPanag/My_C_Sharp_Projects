//By Alexandros Panagiotakopoulos - alexandrospanag.github.io

int employeeLevel = 500;
string employeeName = "John Doe";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    case 500:
        title = "CEO";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");