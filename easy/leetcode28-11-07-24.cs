// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/


public class Solution {
    public int StrStr(string haystack, string needle) {
        //actualy don't know what to return if needle is empty
        if (needle.Length < 1)
            return -1;
        //going for each simbol of string ->
        //haystack - Length of needle + 1 ->
        //so it doesn't do unnessasary steps
        for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
                for (int j = 0; 
                    //going for each simbol of string haystack ->
                    j < needle.Length &&
                    //Check that we don't go beyond haystack ->
                    i+j < haystack.Length && 
                    //Check that simbols are the same
                    needle[j] == haystack[i+j];
                    j++)
                    //And if we on j = needle.Length ->
                    //means that needle in haystack
                    if (j == needle.Length-1)
                        return i;
        return -1;
    }
}
