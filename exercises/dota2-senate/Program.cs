Solution sl = new Solution();

Console.WriteLine(sl.PredictPartyVictory("DDD"));


public class Solution {
    public string PredictPartyVictory(string senate) {


        while (senate.Length > 1)
        {
            if (senate[0] == 'R')
            {
                if(senate.Contains('D'))
                    senate.Remove(senate.IndexOf('D'), 1);
                    senate =
                else
                    return "Radiant";
            }
            else
            {
                if (senate.Contains('R'))
                    senate.Remove(senate.IndexOf('R'), 1);
                else
                    return "Dire";
            }
        }
        
        if (senate[0] == 'D')
            return "Dire";
        else
            return "Radiant";
    }
    
}