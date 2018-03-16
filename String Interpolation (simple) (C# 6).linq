<Query Kind="Program" />

void Main()
{
	var letters = new [] {'a', 'b', 'c'};
	
	//Old way
	var old0 = string.Format("1:{0} 2:{1} 3:{2}", letters[0], letters[1], letters[2]);
	var old1 = string.Format("hello {0}", getString());
	var old2 = string.Format("Current date&time: {0:yyyy-MM-dd  HH:mm:ss}", DateTime.Now);

	//New way
	var new0 = $"1:{letters[0]} 2:{letters[1]} 3:{letters[2]}";
	var new1 = $"hello {getString()}";
	var new2 =$"Current date&time: {DateTime.Now:yyyy-MM-dd  HH:mm:ss}";
	
	
	old0.Dump(nameof(old0));
	old1.Dump(nameof(old1));
	old2.Dump(nameof(old2));

	new0.Dump(nameof(new0));
	new1.Dump(nameof(new1));
	new2.Dump(nameof(new2));
}

string getString() {
	return "how are you?";
}