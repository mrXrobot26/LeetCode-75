public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var res = new StringBuilder();
        var len = Math.Max(word1.Length,word2.Length);
        var len1 =word1.Length;
        var len2 =word2.Length;
        for(int i=0;i<len;i++)
        {
            if(i<len1){
                res.Append(word1[i]);
            }
            if(i<len2){
                res.Append(word2[i]);
            }

        }
        return res.ToString();
    }
}