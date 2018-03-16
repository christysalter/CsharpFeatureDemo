<Query Kind="Program" />

void Main()
{
	var firstName = "David";
	var surName = "O'Doherty";
	
	var url = $"https://www.example.com/api/customer?firstName={firstName}&surName={surName}";
	var safeUrl = EscapeUrl($"https://www.example.com/api/customer?firstName={firstName}&surName={surName}");
	url.Dump(nameof(url));
	safeUrl.Dump(nameof(safeUrl));

	var dob = new DateTime(1990, 01, 01);
	var birthplace = "London";
	
	var sql = $"select name from customers where dob >= {dob} and birthplace = {birthplace}";
	var safeSql = EscapeSql($"select name from customers where dob >= {dob} and birthplace = {birthplace}");
	sql.Dump("SQL");
	safeSql.Dump("Safe SQL");
}


string EscapeUrl(FormattableString url)
{
	var invariantParameters = url
		.GetArguments()
	  	.Select(a => FormattableString.Invariant($"{a}"));
	 
	var escapedParameters = invariantParameters
	  	.Select(Uri.EscapeDataString);

	return string.Format(url.Format, escapedParameters.ToArray());
}

string EscapeSql(FormattableString sql) {

	var invariantParameters = sql
		.GetArguments();

	var escapedParameters = invariantParameters
	  	.Select(x => escapeArg(x));
	
	return string.Format(sql.Format, escapedParameters.ToArray());

	string escapeArg(object arg)
	{
		if (arg is null)
			return "NULL";
		if (arg is string s)
			return $"'{s.Replace("'", "''")}'";
		if (arg is DateTime d)
			return $"'{d.ToString("dd-MMM-yyyy")}'";
		return arg.ToString();
	}
}