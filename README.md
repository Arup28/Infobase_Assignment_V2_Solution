# Instructions
Given a list of words (see the included 'words.txt' list), generate two output files, 'uniques' and 'fullwords'.
The 'uniques' output file should:
1.	Contain every sequence of four letters that appears in exactly one word of the words.txt dictionary.
2.	Include only one sequence of four letters per line.
3.	Be sorted in alphabetical order.
The 'fullwords' file should:
1.	Contain a corresponding line for each full, original words appearing in the 'uniques' file.
2.	The fullwords file must be in the in the same order as the uniques file above.
3.	As above, only one full word per line.
Codebase Requirements:
1.	Please write your solution in C#, PHP, or include an explanation for why you picked a different language.
2.	Solution must execute in under 2 seconds.
3.	Your solution must include proof that it has executed in under 2 seconds.
4.	The finished solution must be compilable (if appropriate) and executable.
Notes: If anything in these instructions seems ambiguous, make the best decision you can, and explain your decision.

Example source and output:
Input:  'words.txt' dictionary:
bicycle
book
for
recycle

* output: 'uniques.txt' would contain:
bicy
book
ecyc
icyc
recy

Programing Tip:'cycl' and 'ycle' would not be included in 'uniques.txt', because they each appear in more than one word.

The output 'fullwords.txt' would contain:
bicycle
book
recycle
bicycle
recycle



The theory question below this line is optional and not mandatory.
Optional: Theory Question:
It is possible to solve the above task for a significantly larger “words.txt” dictionary in under 0.01 seconds. 
If you wish to respond to this bonus question, please describe an alternate solution that could run in 10 milliseconds. An executable sample is not required for the bonus question.  
