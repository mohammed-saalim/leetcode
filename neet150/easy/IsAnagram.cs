// public class Solution
// {
//     public bool IsAnagram( string s, string t )
//     {
//         if (s.Length != t.Length)
//         {
//             return false;
//         }

//         Span<int> usedS = stackalloc int[ 26 ];
//         Span<int> usedT = stackalloc int[ 26 ];

//         for (int i = 0; i < s.Length; i++ )
//         {
//             usedS[ s[ i ] - 97 ]++;
//             usedT[ t[ i ] - 97 ]++;
//         }


//         return usedS.SequenceEqual(usedT);
//     }
// }

// public class Solution {
//     public bool IsAnagram(string s, string t) {
//         if (s.Length != t.Length) {
//             return false;
//         }

//         var symbolFrequency = new Dictionary<char, int>();
//         for (int i = 0; i < s.Length; i++) {
//             symbolFrequency.TryAdd(s[i], 0);
//             symbolFrequency.TryAdd(t[i], 0);

//             symbolFrequency[s[i]]++;
//             symbolFrequency[t[i]]--;
//         }

//         return symbolFrequency.Values.All(frequence => frequence == 0);        
//     }
// }

public class Solution {
    public bool IsAnagram(string s, string t) {
        var dic = new Dictionary<char, int>();
        foreach (var character in s)
        {
            if(dic.ContainsKey(character))
                dic[character] += 1;
            else
                dic.Add(character, 1);
        }

        foreach (var character in t)
        {
            if(dic.ContainsKey(character))
                dic[character] -= 1;
            else
                return false;
        }

        if(dic.Values.All(v => v == 0))
            return true;
        else
            return false;
    }
}