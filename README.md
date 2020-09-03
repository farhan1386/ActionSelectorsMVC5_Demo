# What are Action Selectors in ASP.NET MVC?

The Actions are the public methods of a controller in ASP.NET MVC Application that responds to incoming HTTP Requests. The Action Selectors in ASP.NET MVC are the attributes that can be applied to action methods and are used to influence or control which action method gets invoked in response to a request. That means Action Selectors in MVC help the routing engine to select the correct action method to handle a particular request.

# Types of Action Selectors in ASP.NET MVC.

1.	ActionName
2.	ActionVerbs (HttpGet, HttpPost, HttpPut, HttpDelete)
3.	NonAction


# Example ActionName

```
[ActionName("List")]
public ActionResult Index()
{
    var products = db.Products.ToList();
    return View(products);
}
```

# What is Action Verb Selector?

The ActionVerbs selector is to handle different type of Http requests. The MVC framework includes HttpGet, HttpPost, HttpPut, HttpDelete, HttpOptions, and HttpPatch action verbs. You can apply one or more action verbs to an action method to handle different HTTP requests. If you don't apply any action verbs to an action method, then it will handle HttpGet request by default

```
[AcceptVerbs(HttpVerbs.Get)]
[AcceptVerbs(HttpVerbs.Post)]
[AcceptVerbs(HttpVerbs.Put)]
[AcceptVerbs(HttpVerbs.Delete)]
[AcceptVerbs(HttpVerbs.Head)]
[AcceptVerbs(HttpVerbs.Patch)]

```

# What is the importance of NonActionAttribute? 

All public methods of a controller class are treated as the action method if you want to prevent this default method then you have to assign the public method with NonActionAttribute. 

```
[NonAction]
public string Greeting()
{
    return "<h2>Welcome to MVC 5</h2>";
}
```
