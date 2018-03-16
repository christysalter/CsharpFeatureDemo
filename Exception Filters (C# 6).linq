<Query Kind="Program" />

void Main()
{
	DoSomethingOld(() => throw new Exception());
	DoSomethingOld(() => throw new Exception("some message"));
	DoSomethingOld(() => throw new Exception("other message", new Exception("inner exception")));

	DoSomethingNew(() => throw new Exception());
	DoSomethingNew(() => throw new Exception("some message"));
	DoSomethingNew(() => throw new Exception("other message", new Exception("inner exception")));
}

void DoSomethingOld(Action action) {
	try
	{
		action();
	}
	catch (Exception ex)
	{
		if (ex.InnerException != null)
		{
			ex.InnerException.Message.Dump("Old: Inner Exception");
		}
		else
		{
			if (ex.Message == "some message")
				ex.Message.Dump("Old: was some message");
			else
				ex.Message.Dump("Old: wasn't some message");
		}
	}
}

void DoSomethingNew(Action action) {
	try
	{
		action();
	}
	catch (Exception ex) when (ex.InnerException != null)
	{
		ex.InnerException.Message.Dump("New: Inner Exception");
	}
	catch (Exception ex) when (ex.Message == "some message")
	{
		ex.Message.Dump("New: was some message");
	}
	catch (Exception ex)
	{
		ex.Message.Dump("New: wasn't some message");
	}

}

