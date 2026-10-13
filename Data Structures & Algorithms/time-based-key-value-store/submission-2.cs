public class TimeMap {
    private Dictionary<string, List<(string, int)>> map = new Dictionary<string, List<(string, int)>>();

    public TimeMap() {
        
    }
    
    public void Set(string key, string value, int timestamp) {
        if(map.ContainsKey(key))
        {
            var pq = map[key];
            pq.Add((value, timestamp));
            map[key] = pq;
        }
        else
        {
            List<(string, int)> list  = new List<(string, int)>();
            list.Add((value, timestamp));
            map[key] = list;
        }
    }
    
    public string Get(string key, int timestamp) {
        if(map.ContainsKey(key))
        {
            var pq = map[key];
            int l = 0;
            int r = pq.Count-1;
            int result = 0;
            while(l<=r)
            {
                int mid = l + (r-l)/2;
                if(pq[mid].Item2 <= timestamp)
                {
                    result = mid;
                    l = mid+1;
                }
                else
                {
                    r = mid-1; 
                }
            }
            return timestamp >= pq[result].Item2 ? pq[result].Item1 : "";
        }
        else
        {
            return "";
        }
    }
}
