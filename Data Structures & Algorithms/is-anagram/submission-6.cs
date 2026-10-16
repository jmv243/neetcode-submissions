public class Solution {
    public bool IsAnagram(string s, string t) {
        var d = new Dictionary<char, int>();
        foreach(var x in s){
            if(d.ContainsKey(x)){
                d[x]++;
            }else{
                d.Add(x,1);
            }
        }

        foreach(var x in t){
            if(d.ContainsKey(x)){
                d[x]--;
                if(d[x] < 0){
                    return false;
                }
            }else{
                return false;
            }
        }

        foreach(var k in d.Keys){
            if(d[k] > 0){
                return false;
            }
        }

        return true;
    }
}
