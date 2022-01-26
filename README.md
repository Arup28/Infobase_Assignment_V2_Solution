# Assignment Statement

Given a list of words (see the included 'words.txt' list), generate two output files, 'uniques' and 'fullwords'.

## Approach
Here we have used **SortedDictionary** for storing record in sorted order.

 - Create SortedDictionary.
 - ReadLines from provided file.
 - Apply sequence logic.
 - Store result in sorted order.
 - Fill output result in text files.
 - Capture Elapsed time


```c#

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
```
