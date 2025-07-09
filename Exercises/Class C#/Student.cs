using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public List<int> Grades { get; set; }

	//Konstruktor
	public Student(string firstName, string lastName)
	{
		FirstName = firstName;
		LastName = LastName;
		Grades = new List<int>();
	}

	// Metody:

	public void AddGrade(int grade)
	{
		if(grade < 1 || grade > 5)
		{
			throw new ArgumentOutOfRangeException(nameof(grade), "Ocena musi być w zakresie od 1 - 5.");
		}
        //W przeciwnym razie dodajemy ocenę
        Grades.Add(grade);
    }

	public double GetAverageGrade()
	{
		if(Grades.Count == 0)
		{
			return 0;
		}

		double sum = 0;
		foreach(var grade in Grades)
		{
			sum += grade;
		}

		return sum / Grades.Count;
	}

    public override string ToString()
    {

		// Tworzymy string z ocenami za pomocą Linq!!!
        var gradesList = Grades.Count > 0
            ? string.Join(", ", Grades)
            : "brak ocen";
        return $"{FirstName} {LastName}, oceny: {gradesList}; średnia: {GetAverageGrade():0.00}";
    }
}