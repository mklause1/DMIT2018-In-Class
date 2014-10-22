<Query Kind="Statements">
  <Connection>
    <ID>365fe964-c4f2-4663-a8eb-14a24d4a7216</ID>
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
					Price = info.SalePrice,
					Cost = info.UnitCost
				};
results.Dump();