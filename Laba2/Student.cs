internal class Student
{
    private string name;
    private int[] grades;

    public Student(string name, params int[] grades)
    {
        Name = name;
        Grades = (grades != null) ? grades : new int[0];
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (value != null)
            {
                name = value;
            }
            else
            {
                Console.WriteLine("Ошибка!");
                name = "Default";
            }
        }
    }

    public int[] Grades
    {
        get { return grades; }
        set {  grades = value; }
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

    public string Astudent()
    {
        if (grades.Length <= 0)
        {
            return "У студента нет оценок";
        }

        bool flag = true;
        for (int i = 0; i < grades.Length; i++)
        {
            if (grades[i] < 5)
            {
                flag = false;
                break;
            }
        }

        if (flag == true)
        {
            return "Студент является отличником";
        }
        else
        {
            return "Студент не является отличником";
        }
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