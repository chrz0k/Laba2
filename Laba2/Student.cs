internal class Student
{
    private string name;
    private int[] grades;

    public Student()
    {
        name = "Default";
        grades = new int[0];
    }

    public Student(string name)
    {
        Name = name;
        grades = new int[0];
    }

    public Student(string name, int[] grades)
    {
        Name = name;
        Grades = grades;
    }

    public Student(Student student)
    {
        this.name = student.Name;
        this.grades = student.Grades;
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

    public override string ToString()
    {
        string s = name + ":\t ";
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