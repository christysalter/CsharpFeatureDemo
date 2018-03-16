<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	//Using async local functions with non-async parent functions allows us to gain the advantages of async code, while not having to deal with
	//aggregate exceptions when checking arguments, as the parameter validation can be done outside of the async context
	
	int asyncRes = GetMultipleAsync(6).Result;
	int res = GetMultipleAsync(6).Result;
	asyncRes.Dump(nameof(asyncRes));
	res.Dump(nameof(res));
}

//Old
async Task<int> GetMultipleAsync(int secondsDelay)
{
	"Executing GetMultipleAsync...".Dump();
	if (secondsDelay < 0 || secondsDelay > 5)
		throw new ArgumentOutOfRangeException("secondsDelay cannot exceed 5.");

	await Task.Delay(secondsDelay * 1000);
	return secondsDelay * new Random().Next(2, 10);
}

//New
Task<int> GetMultiple(int secondsDelay)
{
	if (secondsDelay < 0 || secondsDelay > 5)
		throw new ArgumentOutOfRangeException("secondsDelay cannot exceed 5.");

	return GetValueAsync();

	async Task<int> GetValueAsync()
	{
		Console.WriteLine("Executing GetValueAsync...");
		await Task.Delay(secondsDelay * 1000);
		return secondsDelay * new Random().Next(2, 10);
	}
}