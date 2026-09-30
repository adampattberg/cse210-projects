public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    public Job()
    {
    }

    public void DisplayJob()
    {
        Console.WriteLine ("");
        Console.WriteLine ($"{_company} ({_jobTitle}) {_startYear}-{_endYear}");
    }
}