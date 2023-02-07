namespace DesignBrowserHistory
{
    #region First Approach Using double linked List
    // public class BrowserHistory
    // {
    //     public UrlNode current;
    //     public BrowserHistory(string homepage)
    //     {
    //         this.current = new UrlNode(homepage);
    //     }

    //     public void Visit(string url)
    //     {
    //         current.next = new UrlNode(url, current);
    //         current = current.next;
    //     }

    //     public string Back(int steps)
    //     {
    //         while (current.prev != null && steps > 0)
    //         {
    //             current = current.prev;
    //             steps -= 1;
    //         }
    //         return current.url;
    //     }

    //     public string Forward(int steps)
    //     {
    //         while (current.next != null && steps > 0)
    //         {
    //             current = current.next;
    //             steps -= 1;
    //         }
    //         return current.url;
    //     }
    // }
    #endregion

    #region Second Approach Using array ("Stack") most optimal
    public class BrowserHistory {
    public int current;
    public int length;
    public string[] history;
    public BrowserHistory(string homepage) {
        this.current = 0;
        this.length = 1;
        this.history = new string[] {};
        this.history.Append(homepage);
    }
    
    public void Visit(string url) {
        if(history.Length < current + 2)
        {
            history.Append(url);
        }
        else
        {
            history[current + 1] = url;
        }
        current += 1;
        length = current + 1;
    }
    
    public string Back(int steps) {
        if(current - steps > 0)
        {
            current = current - steps;
            return history[current];
        }
        return history[current];
    }
    
    public string Forward(int steps) {
        if(current + steps < length)
        {
            current = current + steps;
            return history[current];
        }
        return history[current];
    }
}
    #endregion
}