namespace DesignBrowserHistory
{
    public class UrlNode
    {
    public UrlNode next;
    public UrlNode prev;
    public string url;

    public UrlNode(string url, UrlNode prev = null, UrlNode next = null)
    {
        this.url = url;
        this.prev = prev;
        this.next = next;
    }
    }

}