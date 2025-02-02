public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();

        
        for(int i=0;i < strs.Length; i++){

            var sortedString = sortString(strs[i]);

            if(!map.ContainsKey(sortedString)){
                map[sortedString] = new List<string>();
            }   
            map[sortedString].Add(strs[i]);
        }

        return map.Values.ToList<IList<string>>();
   
        
    }


    private string sortString(string s){

            var characters = s.ToCharArray();
            Array.Sort(characters);
            return new string(characters);
    }
}

