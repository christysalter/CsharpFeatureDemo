<Query Kind="Program" />

void Main()
{
	OddSequence(0, 99).Dump();	
}



IEnumerable<int> OddSequence(int start, int end)
{
	if (start < 0 || start > 99)
		throw new ArgumentOutOfRangeException("start must be between 0 and 99.");
	if (end > 100)
		throw new ArgumentOutOfRangeException("end must be less than or equal to 100.");
	if (start >= end)
		throw new ArgumentException("start must be less than end.");

	return GetOddSequence();

	IEnumerable<int> GetOddSequence()
	{
		for (int i = start; i <= end; i++)
		{
			if (i % 2 == 1)
				yield return i;
		}
	}
}