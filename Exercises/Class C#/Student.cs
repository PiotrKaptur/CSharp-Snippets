using System;
using System.Collections.Generic;

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

	public void AssGrade(int grade)
	{
		if(grade < 1 || grade > 5)
		{
			throw new ArgumentOutOfRangeException(nameof(grade), "Ocena musi być w zakresie od 1 - 5.");
		}
        //W przeciwnym razie dodajemy ocenę
        Grades.Add(grade);
    }
}
