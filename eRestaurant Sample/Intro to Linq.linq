<Query Kind="Statements">
  <Connection>
    <ID>32401dff-6419-4a70-b730-75f6d2186136</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

/*Example 1: Querying data from eRestaurant*/
var result = from row in Tables
			 where row.Capacity > 3
			 select row;

// the following LIne won't work in your VS project
result.Dump(); // the.Dump() method is an extension method in LinqPad - it's not in .NET

/*Example 2: Query Simple array of strings*/
string[] names = {"Dan", "Don", "Sam", "Dwayne", "Laurel", "Steve"};
names.Dump();

var shortList = from person in names
				where person.StartsWith("D")
				select person;
shortList.Dump();