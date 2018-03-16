<Query Kind="Program" />

void Main()
{
	WhatIsItIf(null).Dump("null");
	WhatIsItIf(double.NaN).Dump("double.NAN");
	WhatIsItIf(double.MaxValue).Dump("double.MaxValue");
	WhatIsItIf("o").Dump("o");
	WhatIsItIf(5).Dump("5");
	WhatIsItIf("hello").Dump("hello");
	WhatIsItIf(string.Empty).Dump("string.Empty");
}



public string WhatIsItIf(object o)
{
	if (o is null) return "o is null";
		
	const double value = double.NaN;
	if (o is value) return "o is value";
	
	if (o is double.MaxValue) return "o is double.MaxValue";
		
	if (o is "o") return "o is \"o\"";
	
	if (o is int n) return $"o is int {n}";
	//var n = 0; //n is already declared in scope

	if (o is string s && !string.IsNullOrWhiteSpace(s)) return "o is not blank";

	return "o is something else";	
}

public string WhatIsItSwitch(object o)
{
		switch (o)
		{
			case null : return "o is null";
			case double.NaN: return "o is NaN";
			case double.MaxValue: return "o is double.MaxValue";
			case "o": return "o is \"o\"";
			case int n: return $"o is int {n}";
			case string s :
				if (string.IsNullOrWhiteSpace(s))
					return "o is not blank";
				goto default; //EWWWWWWWW
			default: return "o is something else";
	}
}