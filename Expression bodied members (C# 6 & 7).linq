<Query Kind="Program" />

void Main()
{
	var oldEx = new OldExample("dave");
	oldEx.Dump("Old Exmaple");

	var newEx = new NewExample("dave");
	newEx.Dump("New Exmaple");
}

class OldExample {
	private string _name;
	public string Name {
		get { return _name; }
		set { _name = value; }
	}
	
	public string throws { get { throw new Exception("oops!"); } }
	
	public OldExample(string name) {
		_name = name;
	}
	
	~OldExample() {
		_name = null;
	}
}

class NewExample {
	private string _name;
	public string Name => _name;
	
	public string throws => throw new Exception("oops!");
	
	public string Name2 {
		get => _name.ToUpper();
		set => _name = value;
	}
	
	public NewExample(string name) => _name = name;
	
	~NewExample() => _name = null;
}