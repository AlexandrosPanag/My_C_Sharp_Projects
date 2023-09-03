//By Alexandros Panagiotakopoulos - alexandrospanag.github.io

int saleAmount = 1100;
// int discount = saleAmount > 1000 ? 100 : 50;


// CONDITIONAL OPERATOR CHEAT SHEET
// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

saleAmount = 700;
// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");