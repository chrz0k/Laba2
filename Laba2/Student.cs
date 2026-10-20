namespace Laba2;

internal class Student
{
    private string name;
    private int[] grades;

    public Student(string name, params int[] grades)
    {
        this.name = name ?? "Default";
        this.grades = grades ?? new int[0];
    }

    public string Name
    {
        get { return name; }
        set { name = value ?? "Default"; }
    }

    public int[] Grades
    {
        get { return grades; }
        set { grades = value ?? new int[0]; }
    }

    public double AverageGrade()
    {
        if (grades.Length <= 0)
        {
            return 0;
        }

        int sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }

        double averageGrade = (double)sum / grades.Length;
        return averageGrade;
    }

    public bool IsExcellent()
    {
        if (grades.Length == 0)
        {
            return false;
        }

        foreach (int grade in grades)
        {
            if (grade < 5)
            {
                return false;
            }
        }

        return true;
    }

    public override string ToString()
    {
        string s = name + ": ";
        if (grades.Length == 0)
        {
            s += "Без оценок";
        }
        else
        {
            s += "[";
            for (int i = 0; i < grades.Length; i++)
            {
                if (i == grades.Length - 1)
                {
                    s += grades[i] + "]";
                }
                else
                {
                    s += grades[i] + ", ";
                }
            }
        }

        return s;
    }
}