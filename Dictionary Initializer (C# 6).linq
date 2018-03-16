<Query Kind="Program" />

void Main()
{
	var oldDict = new Dictionary<string, string>
	{
		{ "key1", "val1" },
		{ "key2", "val2" },
		{ "key3", "val3" }
	};
	
	oldDict.Dump(nameof(oldDict));
	
	var newDict = new Dictionary<string, string> 
	{
		["key1"] = "val1",
		["key2"] = "val2",
		["key3"] = "val3"
	};
	
	newDict.Dump(nameof(newDict));
}