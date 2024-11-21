// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double qEuros;
int qCentims;
int q50e, q20e, q10e, q5e, q2e, q1e, q50c, q20c, q10c, q2c, q1c; 
Console.WriteLine("Hello, World!");
qEuros = Math.Round(value: qEuros, 2);
qEuros = (int)(qEuros * 100);

q50e = qCentims / 5000;
qCentims = qCentims % 5000;

q20e = qCentims / 2000;
qCentims = qCentims % 2000;

q10e = qCentims / 1000;
qCentims = qCentims % 1000;

q5e = qCentims / 500;
qCentims = qCentims % 500;

q2e = qCentims / 200;
qCentims = qCentims % 200;

q1e = qCentims / 100;
qCentims = qCentims % 100;

q50c = qCentims / 50;
qCentims = qCentims % 50;

q20c = qCentims / 20;
qCentims = qCentims % 20;

q10c = qCentims / 10;
qCentims = qCentims % 10;

q5c = qCentims / 5;
qCentims = qCentims % 5;

q1c = qCentims / 1;
qCentims = qCentims % 1;

Console.WriteLine($"{q50e} bitllets de 50€");
Console.WriteLine($"{q20e} bitllets de 20€");
Console.WriteLine($"{q10e} bitllets de 10€");
Console.WriteLine($"{q5e} bitllets de 5€");
Console.WriteLine($"{q2e} monedes de 2€");
Console.WriteLine($"{q1e} monedes de 1€");
Console.WriteLine($"{q50c} monedes de 50 cèntims");
Console.WriteLine($"{q20c} monedes de 20 cèntims");
Console.WriteLine($"{q10c} monedes de 10 cèntims");
Console.WriteLine($"{q5c} monedes de 5 cèntims");
Console.WriteLine($"{q2c} monedes de 2 cèntims");
Console.WriteLine($"{q1c} monedes de 1 cèntim");
}


