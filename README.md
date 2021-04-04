# Partial view and AJAX call

Demo with partial view and AJAX call using ASP.NET MVC

Index action method of Product controller returns partial view. 
```csharp
public ActionResult Index()
{
    IList<Product> products = Repositary.GetAll();
    return PartialView(products);
}
```        
This Index method has been called from Home -> Index view with jQuery and placed in html.
```javascript
$(document).ready(function () {
    $("#ShowProducts").click(function () {
        $.get("/Product/", function (data) { // Get data through AJAX call.
            $("#Products").empty();
            $("#Products").html(data); // Populate with data.
        });
    });
});
```
