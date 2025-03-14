
FizzBuzz();

Console.ReadLine();



void FizzBuzz()
{
	foreach (var number in Enumerable.Range(1, 100))
	{
		Console.WriteLine((number % 3 == 0, number % 5 == 0) switch
		{
			(true, true) => "FizzBuzz",
			(true, false) => "Fizz",
			(false, true) => "Buzz",
			(false, false) => number.ToString()
		});
	}
}
