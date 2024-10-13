namespace NumberFrequency;

internal class NumberFrequencyTest
{
    /// <summary>
    /// Run the test.
    /// </summary>
    /// <returns>The five numbers that appear the most times.</returns>
    public List<int> GetTopFiveMostFrequentNumbers(string filePath)
    {
        // Keep a dictionary of the numbers and their count.
        Dictionary<int, int> numbers = new();

        // Read the file line-by-line.
        using StreamReader reader = new(filePath);
        string? line;

        while ((line = reader.ReadLine()) != null)
        {
            // Extract all the numbers from this line.
            List<int> lineNumbers = line.Split([' '], StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            // If a number doesn't exist in the dictionary, add it with a count of 0, otherwise add 1 to the count.
            foreach (int number in lineNumbers.Where(number => !numbers.TryAdd(number, 0)))
                numbers[number]++;
        }

        // Now get the 5 numbers that appear the most frequently.
        List<int> mostFrequentNumbers = numbers
            .OrderByDescending(n => n.Value)
            .Take(5)
            .Select(n => n.Key)
            .OrderBy(n => n)
            .ToList();

        return mostFrequentNumbers;
    }
}