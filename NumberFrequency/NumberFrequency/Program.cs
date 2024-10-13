using NumberFrequency;

// Run the test routine.
NumberFrequencyTest test = new NumberFrequencyTest();
List<int> numbers = test.GetTopFiveMostFrequentNumbers("numbers.txt");

// Show the results.
Console.WriteLine("The 5 most frequently appearing numbers are:");

foreach (int number in numbers)
    Console.WriteLine(number);

Console.ReadKey();