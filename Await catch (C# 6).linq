<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task Main()
{
	try {
		throw new Exception("It broke");
	} catch (Exception e) {
		var result = AsyncLog(e.Message);
		Console.WriteLine(await result);
	}
}

async Task<string> AsyncLog(string text) {
	await Task.Run(() => Console.WriteLine(text));
	return text;
}