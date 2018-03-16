<Query Kind="Program" />

void Main()
{
	string str = null;
	
	//old
	var length1 = 0;
	if (str != null)
		length1 = str.Length;
	length1.Dump("old");
	
	//new
	var length2 = str?.Length ?? 0;
	length2.Dump("new");
	
	
	str?[0].Dump("empty");
	str = "hi";
	str?[0].Dump("not empty");
}