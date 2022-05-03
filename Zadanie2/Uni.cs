using System.Collections;

namespace Zadanie2;

class Uni
{
    public List<double> ListaDopuszczalnychOcen;
    private List<Student> ListaStudentow = new List<Student>();

    public void DodajStudenta()
    {
        var student = new Student();
        Console.Write("Podaj imię studenta: ");
        student.Imie = Console.ReadLine()!;
        
        Console.Write("Podaj nazwisko studenta: ");
        student.Nazwisko = Console.ReadLine()!;
        
        Console.Write("Podaj nr. indeksu studenta: ");
        student.NrIndeksu = Int32.Parse(Console.ReadLine()!);

        Console.Write("Podaj rok studiów studenta: ");
        student.RokSt = Int32.Parse(Console.ReadLine()!);

        Console.WriteLine("Podaj oceny studenta " + student.Imie + "(n by zakonczyc): ");
        var endOfGrades = false;
        var grades = new List<double>();
        while (!endOfGrades)
        {
            var grade = Console.ReadLine()!;
            if (grade.Equals("n"))
            {
                endOfGrades = true;
            } 
            else if (ListaDopuszczalnychOcen.Contains(Double.Parse(grade)))
            {
                grades.Add(Double.Parse(grade));
            }
            else
            {
                Console.WriteLine("Podano niewłasciwą ocene! Podaj kolejną: ");
            }
        }

        student.Oceny = grades;
        
        ListaStudentow.Add(student);
    }

    public void UsunStudenta()
    {
        Console.Write("W celu usunięcia studenta podaj jego nr. indeksu: ");
        var indexNumber = Int32.Parse(Console.ReadLine()!);

        var studentFound = false;
        var studentFoundIndex = 0;
        for (int i = 0; i < ListaStudentow.Count; i++)
        {
            if (ListaStudentow[i].NrIndeksu == indexNumber)
            {
                studentFound = true;
                studentFoundIndex = i;
                break;
            }
        }

        if (studentFound)
        {
            ListaStudentow.RemoveAt(studentFoundIndex);
            Console.WriteLine("Student z nr. indeksu " + indexNumber + " został usunięty!");
        }
        else
        {
            Console.WriteLine("Nie znaleziono studenta z nr. indeksu " + indexNumber);
        }
    }

    public void ObliczSrednia()
    {
        Console.WriteLine("Wybierz studenta do obliczenia jego średniej:");
        for (int i = 0; i < ListaStudentow.Count; i++)
        {
            Console.WriteLine(i + ". " + ListaStudentow[i].Imie + " " + ListaStudentow[i].Nazwisko);
        }

        Console.Write("Wybieram studenta nr: ");
        var selectedStudentNumber = Int32.Parse(Console.ReadLine()!);

        var averageGrade = 0.0;
        for (int i = 0; i < ListaStudentow[selectedStudentNumber].Oceny.Count; i++)
        {
            averageGrade += ListaStudentow[selectedStudentNumber].Oceny[i];
        }

        averageGrade /= ListaStudentow[selectedStudentNumber].Oceny.Count;
        Console.WriteLine("Średnia ocen tego studenta to: " + averageGrade);
    }

    public void ObliczSredniaAll()
    {
        var averageGrade = 0.0;
        var numberOfGrades = 0;
        for (int i = 0; i < ListaStudentow.Count; i++)
        {
            for (int j = 0; j < ListaStudentow[i].Oceny.Count; j++)
            {
                averageGrade += ListaStudentow[i].Oceny[j];
                numberOfGrades++;
            }
        }

        try
        {
            averageGrade /= numberOfGrades;
            Console.WriteLine("Średnia ocen wszystkich studentów: " + averageGrade);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }
}

