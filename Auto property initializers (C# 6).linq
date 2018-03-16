<Query Kind="Program" />

void Main()
{
	//Looking at the generated IL, we can see that Before and After are identical. Both end up with constructors setting the name
	
	new Before().Name.Dump(nameof(Before));
	new After().Name.Dump(nameof(After));
	
}

class Before {
	public string Name { get; }
	
	public Before() {
		Name = "Joe Bloggs";
	}
}

class After {
	public string Name { get; /*supports set modifiers*/ } = "Joe Bloggs";
}