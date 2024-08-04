/*
To test code

void TestSolution() {
    Solution solution = new Solution();

    // Example input
    string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
    
    // Get the result
    IList<IList<string>> result = solution.GroupAnagrams(strs);
    
    // Print the result
    foreach (var group in result) {
        Console.WriteLine($"[{string.Join(", ", group)}]");
    }
}

// Execute the test case
TestSolution();


*/


public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {

        if(strs ==  null || strs.Length == 0){
            return new List<IList<string>>();
        }

        Dictionary<string, List<string>> map =  new Dictionary<string, List<string>>();

        foreach(string s in strs){
            char[] ch = s.ToCharArray();
            Array.Sort(ch);
            var res = new string(ch);

            if(!map.ContainsKey(res)){
                map[res] = new List<string>();
            }

            map[res].Add(s);
        }

        return new List<IList<string>>(map.Values);


        // Using Ling
        // return strs.GroupBy( s => new string(s.OrderBy(c=> c).ToArray())).Select(g => g.ToList() as IList<string>).ToList();

       
        
    }
}


/* in neetcode */


/*

public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        if(strs.Length == 0 || strs == null){
            return new List<List<string>>();
        }

        Dictionary<string, List<string>> map =  new Dictionary<string, List<string>>();

        foreach(string s in strs){

            string sorted = new string(s.OrderBy( c => c).ToArray());

            if(!map.ContainsKey(sorted)){

                map[sorted] = new List<string>();
            }

            map[sorted].Add(s);

        }


        return new List<List<string>>(map.Values);
        
    }
}




*/


Explanation:

1) Make a Dictionary which has key as the sorted string and values as the list of strings grouped for the sorted string


/*

Approach Brute
Input Validation:
Check if the input array strs is null or empty. If so, return an empty list.
HashMap Initialization:
Create a HashMap `map to store the groups of anagrams. The key of the HashMap will be the sorted string, and the value will be a list of strings (anagrams).
Iterating Over Input Strings:
Iterate through each string s in the input array strs.
Sorting Characters:
Convert the current string s into a character array ch.
Sort the character array ch in ascending order.
Constructing Key:
Convert the sorted character array ch back to a string keyStr.
Grouping Anagrams:
Check if the keyStr already exists in the HashMap map.
If it doesn't exist, create a new entry in the HashMap with keyStr as the key and an empty list as the value.
Add the original string s to the list corresponding to the keyStr.
Return the Result:
After iterating through all strings, return a list containing all the values (lists of anagrams) from the HashMap map.
Complexity
Time complexity: O(n∗nlogn)
Space complexity: O(n)

*/


/* Linq */


/*

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        // Group the strings by their sorted characters
        IEnumerable<IGrouping<string, string>> groupedAnagrams = strs.GroupBy(s => 
        {
            // Convert the string to a character array
            char[] charArray = s.ToCharArray();
            
            // Sort the character array
            Array.Sort(charArray);
            
            // Create a new string from the sorted character array
            string sortedString = new string(charArray);
            
            // Return the sorted string as the key
            return sortedString;
        });

        // Convert the grouped anagrams to a list of lists
        List<IList<string>> result = groupedAnagrams.Select(g => g.ToList() as IList<string>).ToList();

        // Return the result
        return result;
    }
}

// Test case
void TestSolution() {
    Solution solution = new Solution();

    // Example input
    string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
    
    // Get the result
    IList<IList<string>> result = solution.GroupAnagrams(strs);
    
    // Print the result
    foreach (var group in result) {
        Console.WriteLine($"[{string.Join(", ", group)}]");
    }
}

// Execute the test case
TestSolution();


Explanation of Each Step
GroupBy:

GroupBy(s => new string(s.OrderBy(c => c).ToArray()))
For each string s in the input array strs:
Convert s to a character array.
Sort the character array.
Convert the sorted character array back to a string.
Use this sorted string as the key for grouping.
Select:

Select(g => g.ToList() as IList<string>)
For each group g of anagrams:
Convert the group (which is an IGrouping<string, string>) to a List<string>.
Cast the list to IList<string>.
ToList:

ToList()
Convert the sequence of groups into a List<IList<string>>.
Example Walkthrough
Let's walk through an example with strs = ["eat", "tea", "tan", "ate", "nat", "bat"]:

GroupBy:

"eat" -> sorted as "aet"
"tea" -> sorted as "aet"
"tan" -> sorted as "ant"
"ate" -> sorted as "aet"
"nat" -> sorted as "ant"
"bat" -> sorted as "abt"
Grouped as:

{"aet": ["eat", "tea", "ate"], "ant": ["tan", "nat"], "abt": ["bat"]}
Select:

Convert each group to a list:
For "aet": ["eat", "tea", "ate"]
For "ant": ["tan", "nat"]
For "abt": ["bat"]
ToList:

Convert the sequence to a list of lists:
[["eat", "tea", "ate"], ["tan", "nat"], ["bat"]]
Final Result
[[eat, tea, ate], [tan, nat], [bat]]
This approach ensures that all anagrams are grouped together efficiently. The code leverages LINQ to perform the grouping and conversion operations in a concise and readable manner. If you have any questions or need further clarification, feel free to ask!


Let's revisit the group anagram solution and ensure it is clear and understandable. We will go through the steps and make sure everything is well explained.

Problem Statement
Given an array of strings, group anagrams together.

Approach
Sort Each String: Anagrams, when sorted, will have the same string. For example, "eat", "tea", and "ate" will all become "aet" when sorted.
Group by Sorted String: Use the sorted string as a key to group the original strings.
Step-by-Step Explanation
Convert Each String to a Sorted Version:

For each string in the input array, convert it to a character array, sort the array, and then convert it back to a string.
This sorted string will serve as a key for grouping anagrams.
Group Strings by the Sorted Key:

Use the GroupBy method to group strings by their sorted version.
Convert Groups to List of Lists:

Each group of anagrams is converted to a list, and the result is a list of these lists.


*/



/*linq expln*/  /* string.OrderBy( c => c) means convert string in ascending order.

/*

Step-by-Step Explanation
Grouping the Strings by Sorted Characters:

GroupBy(s => new string(s.OrderBy(c => c).ToArray()))
This line groups the strings in the array strs based on their sorted characters.
s.OrderBy(c => c) sorts the characters in the string s.
new string(s.OrderBy(c => c).ToArray()) converts the sorted characters back into a string.
GroupBy uses this sorted string as the key to group anagrams together.
Transforming the Grouped Results:

.Select(g => g.ToList() as IList<string>)
This line projects each group into a List<string> and then casts it to IList<string>.
g is a group of anagrams, and g.ToList() converts the group (which is an IEnumerable<string>) into a List<string>.
as IList<string> ensures that the result is of type IList<string>, which is required by the method signature.
Converting the Result to a List of Lists:

.ToList()
This line converts the result from an IEnumerable<IList<string>> to a List<IList<string>>.
This final conversion ensures that the method returns the correct type, which is IList<IList<string>>.
Detailed Example
Let's walk through an example to illustrate how this code works:

Input: strs = ["eat", "tea", "tan", "ate", "nat", "bat"]

Step-by-Step Execution:

Grouping by Sorted Characters:

"eat" -> "aet"
"tea" -> "aet"
"tan" -> "ant"
"ate" -> "aet"
"nat" -> "ant"
"bat" -> "abt"
After grouping, we get:

Group "aet": ["eat", "tea", "ate"]
Group "ant": ["tan", "nat"]
Group "abt": ["bat"]
Transforming Groups to Lists:

Group "aet": ["eat", "tea", "ate"] -> List<string> { "eat", "tea", "ate" }
Group "ant": ["tan", "nat"] -> List<string> { "tan", "nat" }
Group "abt": ["bat"] -> List<string> { "bat" }
Converting to List of Lists:

Result: List<IList<string>> { List<string> { "eat", "tea", "ate" }, List<string> { "tan", "nat" }, List<string> { "bat" } }
Summary
GroupBy: Groups the strings by their sorted characters, ensuring that anagrams fall into the same group.
OrderBy: Sorts the characters within each string to create a common key for anagrams.
ToList and as IList<string>: Converts each group into a list and ensures the type is IList<string>.
ToList(): Converts the overall result into a List<IList<string>>.
This solution is concise and leverages LINQ to perform the grouping and transformation operations in a functional programming style, making the code easy to read and understand.


*/

/* sort string using Linq 







The expression s.OrderBy(c => c) is a LINQ (Language Integrated Query) query that sorts the characters in the string s in ascending order. Let's break it down:

s.OrderBy(c => c)
s: This is the string that we want to sort.
OrderBy: This is a LINQ method that sorts the elements of a sequence (in this case, the characters of the string s) in ascending order based on a key.
c => c: This is a lambda expression used to specify the key for sorting. In this case, we are using each character c itself as the key, so the characters are sorted based on their natural order (i.e., their Unicode values).
Step-by-Step Explanation
String to Character Sequence:

When you use OrderBy on a string, it treats the string as a sequence of characters (IEnumerable<char>).
Lambda Expression:

c => c is a lambda expression where c represents each character in the string s. The lambda expression simply returns c, meaning the sorting key for each character is the character itself.
Sorting:

OrderBy(c => c) sorts the characters of the string s in ascending order based on their Unicode values.
Result:

The result of s.OrderBy(c => c) is an IEnumerable<char> where the characters are sorted in ascending order.
Example
Let's take an example to see how s.OrderBy(c => c) works.

csharp
Copy code
string s = "cba";
var sortedCharacters = s.OrderBy(c => c);
Step-by-Step Execution:

Original String:

s = "cba"
Character Sequence:

The string s is treated as a sequence of characters: ['c', 'b', 'a']
Sorting:

The characters are sorted based on their natural order (Unicode values):
'a' (Unicode 97)
'b' (Unicode 98)
'c' (Unicode 99)
Result:

The sorted sequence is: ['a', 'b', 'c']
Converting to Array and New String
After sorting, the characters are converted back to a string. This is done by using ToArray() to convert the IEnumerable<char> to a character array, and then using the new string() constructor to create a string from the character array.

csharp
Copy code
string sortedString = new string(s.OrderBy(c => c).ToArray());


*/

/* optimized  need to learn*/

/*

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        if (strs.Length == 0) {
            return new List<IList<string>>();
        }

        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

        foreach (string str in strs) {
            string sortedStr = CountSort(str);
            if (!anagrams.ContainsKey(sortedStr)) {
                anagrams.Add(sortedStr, new List<string>());
            }

            anagrams[sortedStr].Add(str);
        }

        IList<IList<string>> result = new List<IList<string>>();
        foreach (KeyValuePair<string, List<string>> kvp in anagrams) {
            result.Add(kvp.Value);
        }
        return result;
    }

    private string CountSort(string s) {
        int[] counts = new int[26];
        foreach (char c in s) {
            counts[c - 'a'] += 1;
        }

        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < counts.Length; i++) {
            if (counts[i] > 0) {
                builder.Append((char)('a' + i), counts[i]);
            }
        }

        return builder.ToString();
    }
}


*/