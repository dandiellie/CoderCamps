<Query Kind="Expression">
  <Connection>
    <ID>edbc3d21-1073-45b6-878c-403e441da864</ID>
    <Persist>true</Persist>
    <Driver>AstoriaAuto</Driver>
    <Server>http://services.odata.org/Northwind/Northwind.svc</Server>
  </Connection>
</Query>

Employees.Where(e => e.Notes.Contains("BA")).Select(e => new{e.LastName})

Products.OrderByDescending(p => p.UnitPrice).Select(p => p)

Orders.Where(o => o.ShipCountry == "Mexico").Select(o => o)

Employees.Where(e => e.ReportsTo == null).Select(e => e)

Products.Where(p => p.ProductName == "Chai").Select(p => new{OrderDetails = p.Order_Details.ToList()}).FirstOrDefault().OrderDetails.Count

Order_Details.Where(o => o.Product.ProductName == "Chai").Count()