string bracketExpression = "( () ( () ) )"; 

int count = 0;
int maxCount = 0;

foreach (var bracket in bracketExpression)
{
    if (bracket == '(')
    {
        count++;

        if (count > maxCount)
        {
            maxCount = count;
            Console.WriteLine(maxCount);
        }
    }
    else if (bracket == ')')
    {
        count--;

        if (count < 0)
        {
            Console.WriteLine("Некорректное скобочное выражение");
            break;
        }
    }
}

if (maxCount > 0 && count == 0)
{
    Console.WriteLine("Максимальная глубина: " + maxCount);
}