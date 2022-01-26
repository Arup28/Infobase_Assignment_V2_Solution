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

_**It is possible to solve the above task for a significantly larger “words.txt” dictionary in under 0.01 seconds. 
If you wish to respond to this bonus question, please describe an alternate solution that could run in 10 milliseconds. An executable sample is not required for the bonus question.  **_

- Split the larger words.txt into smaller files and then apply the sequencing logic. As reading large text file might take additional overheads.
- Use SortedHashTable for sorting sorted data. 
- Implement partition sort for sorting across the page.
- Merge the results at the end.

