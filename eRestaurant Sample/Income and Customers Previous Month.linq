<Query Kind="Statements">
  <Connection>
    <ID>365fe964-c4f2-4663-a8eb-14a24d4a7216</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

// Get the following from the Bills table for the current Month:
// BillDate, ID, # people served, total amount billed
// Then, Display the total income for the month and the number of customers served

var month = DateTime.Today.Month - 1;
var year = DateTime.Today.Year;
var billsInMonth = 	from item in Bills
					where item.PaidStatus // Only bills that are paid
						&& item.BillDate.Month == month
						&& item.BillDate.Year == year
					orderby item.BillDate
					select new
					{
						BillDate = item.BillDate,
						BillId = item.BillID,
						NumberOfCustomers = item.NumberInParty,
						TotalAmount = item.BillItems.Sum(bi => bi.Quantity * bi.SalePrice)
					};
billsInMonth.Dump();