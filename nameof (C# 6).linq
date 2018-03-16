<Query Kind="Program" />

void Main()
{
	//This is design/compile time syntactic sugar. The C# executable will contain the literal value
	
	var myClass = new MyClass();

	//old - will fail if MyString refactored
	var fieldInfo = typeof(MyClass).GetField("MyString");
	fieldInfo.GetValue(myClass).Dump("Old");
	
	//new - will keep in sync with refactoring
	fieldInfo = typeof(MyClass).GetField(nameof(MyClass.MyString));
	fieldInfo.GetValue(myClass).Dump("New");
}


class MyClass {
	public string MyString;
	public MyClass() {
		this.MyString = "hello world";
	}
}