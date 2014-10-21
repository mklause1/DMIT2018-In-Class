<Query Kind="Expression">
  <Connection>
    <ID>0db6b925-4cd7-49a3-8ca1-53049026cabf</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

// This query is for pulling out data to be used in a 
// Details report. The query gets all he menu items
// and their categories, sorting them by the category
// description and then by the menu item description.
from cat in Items
orderby cat.MenuCategory.Description, cat.Description
select new
{
	CategoryDescription = cat.MenuCategory.Description,
	ItemDescription = cat.Description,
	Price = cat.CurrentPrice,
	Calories = cat.Calories,
	Comment = cat.Comment
}