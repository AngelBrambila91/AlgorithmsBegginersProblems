using DesignBrowserHistory;

BrowserHistory browserHistory = new BrowserHistory("www.youtube.com");
browserHistory.Visit("a");
browserHistory.Visit("b");
browserHistory.Visit("c");
browserHistory.Back(1);
browserHistory.Back(1);
browserHistory.Forward(1);
browserHistory.Visit("d");
browserHistory.Forward(2);
browserHistory.Back(2);
browserHistory.Back(7);