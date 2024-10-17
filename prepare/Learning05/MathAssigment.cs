using System;
using System.Dynamic;

public class MathAssignment : Assignment
{
    public string _textBookSection;
    public string _problems;

    public MathAssignment(string student, string topic, string section, string problem) : base(student, topic)
    {   
        _textBookSection = section;
        _problems = problem;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}