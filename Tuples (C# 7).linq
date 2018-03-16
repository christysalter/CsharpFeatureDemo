<Query Kind="Program" />

void Main()
{
	//Simple unnamed ValueTuple. Distinct from Tuple
	var tuple = GetTuple();
	tuple.Item1.Dump();
	
	//Tuple is of type System.ValueTuple
	var namedTuple = GetNamedTuple();
	namedTuple.val1.Dump();

	//Deconstructed Tuple - 3 distinct variables
	var (val1, val2, stringVal) = GetNamedTuple();
	$"val1={val1}  val2={val2}  stringVal={stringVal}".Dump();
	
	//new _ discard syntax for values we don't care about
	var (a, _, _) = GetNamedTuple();
	a.Dump();
}

(int, int, string) GetTuple() {
	return (10, 20, "GetTuple");
}

(int val1, int val2, string stringVal) GetNamedTuple() {
	return (val1: 1, val2:2, stringVal: "GetNamedTuple");
}