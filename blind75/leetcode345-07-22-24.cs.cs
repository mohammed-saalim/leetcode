// 345. Reverse Vowels of a String
// Solved
// Easy
// Topics
// Companies
// Given a string s, reverse only all the vowels in the string and return it.

// The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.

 

// Example 1:

// Input: s = "hello"
// Output: "holle"
// Example 2:

// Input: s = "leetcode"
// Output: "leotcede"

// Solution:

public class Solution {
    public string ReverseVowels(string s) {

        var stack = new Stack<char>();
        var str = new StringBuilder();

        foreach(var i in s){
            if("aeiouAEIOU".Contains(i)){
                stack.Push(i);
            }

        }


        foreach(var i in s){
            if("aeiouAEIOU".Contains(i)){
                str.Append(stack.Pop());
            }
            else{
                str.Append(i);
            }
        }

        return str.ToString();
        
    }
}


/*
Steps:
1) Check every element in string and when a vowel matches. Push it into the stack
if("aeiouAEIOU".Contains(s[i])){ stack.Push(i);}
2) Again, Check every element in string this time append the string builder (str) when you find a vowel with the popped stack element.
if("aeiouAEIOU".Contains(s[i])){ str.Append(stack.Pop();)}
return str.ToString();
