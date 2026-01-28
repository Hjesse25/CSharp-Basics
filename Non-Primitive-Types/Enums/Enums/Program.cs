using Enums;

var method = ShippingMethod.Express;
Console.WriteLine((int)method);

var methodId = 3;
Console.WriteLine((ShippingMethod)methodId);

Console.WriteLine(method.ToString());

var methodName = "Express";
var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);

