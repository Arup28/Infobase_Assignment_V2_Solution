class WordSequenceGenerator
{
	private static readonly int FOUR = 4;

	public static void Main()
	{
		try
		{
			SortedDictionary<string, string> sortedUniqueKeysAndValues = new();
			foreach (string line in File.ReadLines(@"Resources\words.txt"))
			{
				int strLength = line.Length;
				if (strLength <= FOUR && !sortedUniqueKeysAndValues.ContainsKey(line))
				{
					sortedUniqueKeysAndValues.Add(line, line);
				}
				else
				{
					for (int i = 0; i <= strLength - FOUR; i++)
					{
						string subStr = line.Substring(i, FOUR);
						if (!sortedUniqueKeysAndValues.ContainsKey(subStr))
						{
							sortedUniqueKeysAndValues.Add(subStr, line);
						}
					}
				}
			}
			File.WriteAllLines(@"Resources\uniques.txt", sortedUniqueKeysAndValues.Keys);
			File.WriteAllLines(@"Resources\fullwords.txt", sortedUniqueKeysAndValues.Values);
		}
		catch(Exception ex)
        {
			Console.WriteLine("Exception Message: " + ex.Message);
        }
	}
}

