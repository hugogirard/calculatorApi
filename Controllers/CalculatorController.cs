using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers;


public class CalculatorController : ControllerBase
{
    /// <summary>
    /// Add two integers
    /// </summary>
    /// <param name="a">First operand. Default value is 51.</param>
    /// <param name="b">Second operand. Default value is 49.</param>
    /// <returns></returns>
    [HttpGet]
    [Route("api/add", Name = "Add two integers")]
    public ContentResult Add(int a = 51, int b = 49)
    {
        int result = a + b;
        var xml = $"<result><value>{result}</value><broughtToYouBy>Azure API Management</broughtToYouBy></result>";
        Response.Headers.Add("x-aspnet-version", "4.0.30319");
        return new ContentResult
        {
            Content = xml,
            ContentType = "application/xml",
            StatusCode = 200
        };        
    }


    /// <summary>
    /// Subtract two integers
    /// </summary>
    /// <param name="a">First operand. Default value is 51.</param>
    /// <param name="b">Second operand. Default value is 49.</param>
    /// <returns></returns>
    [HttpGet]
    [Route("api/sub")]
    public IActionResult Subtract(int a = 51, int b = 49)
    {
        int result = a - b;
        var xml = $"<result><value>{result}</value><broughtToYouBy>Azure API Management</broughtToYouBy></result>";
        Response.Headers.Add("x-aspnet-version", "4.0.30319");
        return new ContentResult
        {
            Content = xml,
            ContentType = "application/xml",
            StatusCode = 200
        };    
    }

    /// <summary>
    /// Multiply two integers
    /// </summary>
    /// <param name="a">First operand. Default value is 51.</param>
    /// <param name="b">Second operand. Default value is 49.</param>
    /// <returns></returns>
    [HttpGet]
    [Route("api/mul")]
    public IActionResult Multiply(int a = 51, int b = 49)
    {
        int result = a * b;
        var xml = $"<result><value>{result}</value><broughtToYouBy>Azure API Management</broughtToYouBy></result>";
        Response.Headers.Add("x-aspnet-version", "4.0.30319");
        return new ContentResult
        {
            Content = xml,
            ContentType = "application/xml",
            StatusCode = 200
        };    
    }

    /// <summary>
    /// Divide two integers
    /// </summary>
    /// <param name="a">First operand. Default value is 51.</param>
    /// <param name="b">Second operand. Default value is 49.</param>
    /// <returns></returns>
    [HttpGet]
    [Route("api/div")]
    public IActionResult Divide(int a = 51, int b = 49)
    {
        if (b == 0)
        {
            return BadRequest("Division by zero is not allowed.");
        }
        
        int result = a / b;
        var xml = $"<result><value>{result}</value><broughtToYouBy>Azure API Management</broughtToYouBy></result>";
        Response.Headers.Add("x-aspnet-version", "4.0.30319");
        return new ContentResult
        {
            Content = xml,
            ContentType = "application/xml",
            StatusCode = 200
        };    
    }
}

