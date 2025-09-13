using System;
public class Job
{
    public string _company;
    public string _jodTitel;
    public int _startYear;
    public int _endYear;
    internal string _jobTitle;

    public void Display() => Console.WriteLine($"{_jodTitel} ({_company}) {_startYear}-{_endYear}");
}