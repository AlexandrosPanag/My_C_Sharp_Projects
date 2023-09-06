//By Alexandros Panagiotakopoulos - alexandrospanag.github.io

double usd = 20;
int euro = UsdToEuro(usd);


Console.WriteLine($"${euro} EURO = ${EuroToUsd(euro)} USD");

int UsdToEuro(double usd)
{
    double rate = 1.2;
    return (int)(rate / usd);
}

double EuroToUsd(int euro)
{
    double rate = 1.2;
    return (int) euro * rate;
}
