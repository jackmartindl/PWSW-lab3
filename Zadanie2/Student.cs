using System.Collections;

namespace Zadanie2;

public class Student
{
    private int nr_indeksu;
    private String imie;
    private String nazwisko;
    private int rok_st;
    private List<double> oceny;

    public Student()
    {
    }
    
    public void ShowNrIndeksu()
    {
        Console.WriteLine(this.nr_indeksu);
    }
    
    public void ShowImie()
    {
        Console.WriteLine(this.imie);
    }

    
    public void ShowNazwisko()
    {
        Console.WriteLine(this.nazwisko);
    }

    
    public void ShowRokSt()
    {
        Console.WriteLine(this.rok_st);
    }



    public Student(int nrIndeksu, string imie, string nazwisko, int rokSt)
    {
        nr_indeksu = nrIndeksu;
        this.imie = imie;
        this.nazwisko = nazwisko;
        rok_st = rokSt;
    }

    public int NrIndeksu
    {
        get => nr_indeksu;
        set => nr_indeksu = value;
    }

    public string Imie
    {
        get => imie;
        set => imie = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Nazwisko
    {
        get => nazwisko;
        set => nazwisko = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int RokSt
    {
        get => rok_st;
        set => rok_st = value;
    }

    public List<double> Oceny
    {
        get => oceny;
        set => oceny = value ?? throw new ArgumentNullException(nameof(value));
    }
}

