<Query Kind="Statements">
  <Connection>
    <ID>32401dff-6419-4a70-b730-75f6d2186136</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

var results = 	from info in BillItems
				orderby info.Item.MenuCategory.Description, info.Item.Description
				select new
				{
					CategoryDescription = info.Item.MenuCategory.Description,
					ItemDescription = info.Item.Description,
					Quantity = info.Quantity,
					Price = info.SalePrice * info.Quantity,
					Cost = info.UnitCost * info.Quantity
				};
results.Dump();