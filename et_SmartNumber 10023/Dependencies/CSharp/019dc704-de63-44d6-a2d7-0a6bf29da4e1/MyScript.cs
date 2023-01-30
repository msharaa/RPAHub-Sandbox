using System;
using System.Text.RegularExpressions;
public class MyScript
{
    public string Hello()
    {
        return "welcome to ServiceNow!";
    }
    
    public static string GetOrderId(string order_message)
    {
		return Regex.Match(order_message, @"\d+").Value;
    
    }
}