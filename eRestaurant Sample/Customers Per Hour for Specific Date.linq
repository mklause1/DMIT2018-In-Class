<Query Kind="Expression" />

// How many customers per hour on Sept. 15, 2014.
from info in Bills
where info.BillDate.Year == 2014
   && info.BillDate.Month == 9
   && info.BillDate.Day == 15
group info by info.BillDate.Hour into infoGroup
select new 
{
   Hour = infoGroup.Key,
   CustomerBillCount = infoGroup.Count(),
   CustomersCount = infoGroup.Sum(x=>x.NumberInParty)
}