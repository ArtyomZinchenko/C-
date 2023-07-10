int a = 1;
int b = 2;
int c = 5;
int d = 23;
int e = 55;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.WriteLine("The maximum number is " + max);