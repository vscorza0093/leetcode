
List<int> rq =  new List<int>{3325,3813,3836,4291,4353,4991};
//List<int> rq =  new List<int>{1, 100, 3001, 3002};
//List<int> rq =  new List<int>{1, 100, 3001, 3002, 10000, 10001, 13000, 13001, 13002, 18000, 18001, 18002, 18003, 18004};


RecentCounter recentCounter = new RecentCounter();

for (int i = 0; i < rq.Count; i++)
{
    Console.WriteLine(recentCounter.Ping(rq[i]));
}


public class RecentCounter {

    public List<int> requests = new List<int>();
    public RecentCounter() {}
    
    public int Ping(int t) {
        
        requests.Add(t);
        while (requests[requests.Count - 1] - requests[0] > 3000)
            requests.RemoveAt(0);

        return requests.Count;
    }

}

