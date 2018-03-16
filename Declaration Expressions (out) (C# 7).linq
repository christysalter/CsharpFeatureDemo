<Query Kind="Program" />

void Main()
{
	// Old and new usage generate identical MSIL. Also supports _ discard syntax
	
	//old usage
	int num;
	int.TryParse("15", out num);
	num.Dump("old way");
	
	
	//new usage
	int.TryParse("15", out int num2);
	num2.Dump("new way");
	
	
	//out discard
	if (int.TryParse("15", out _)) {
		"We don't care about the out value".Dump("discard");
	}
}