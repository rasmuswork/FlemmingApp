using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

//personer oprettes
Person person1 = new Person(); // person 1 is an object
person1.FirstName = "Abraham";
person1.LastName = "Lincoln";
person1.Address = "BigStreet 45b";
person1.PhoneNumber = 34204540;
person1.age = 30; //declaration

Person person2 = new Person();
person2.FirstName = "Gilbert";
person2.LastName = "skysovs";
person2.Address = "Littlestreet 23a";
person2.PhoneNumber = 42;
person2.age = 30;

Person person3 = new Person();
person3.FirstName = "Flomme";
person3.LastName = "";
person3.Address = "Brigde 45, a little to the left";
person3.PhoneNumber = 23242454;
person3.age = 145;

Person person4 = new Person();
person4.FirstName = "Blomme";
person4.LastName = "";
person4.Address = "BigCity street 45 ft";
person4.PhoneNumber = 11111111;
person4.age = 43;

Person person5 = new Person();
person5.FirstName = "Alexandre";
person5.LastName = "";
person5.Address = "Thorsvej 5";
person5.age = 34;



Console.WriteLine(person1.PastePerson); //tager person1 og metoden "PastePerson" som skriver al data ud
person1.SetToZero();
Console.WriteLine(person1.PastePerson); //skriver al data ud igen, men denne gang er alt sat til 0. "skal bare sætte alle værdierne for en person"
public class Product
{
    public double Pris;
    public double PrisTotal;
    
    public double kilogram;
    public double størrelse;
    public void MedMoms()
    {
        double PrisMedMoms = Pris * 1.25;
        Console.WriteLine(PrisMedMoms);
    }
}

public class Kunde : Person
{
    public int RabatGruppe = 0;
    public double TotalIndkøb;
}
public class Ansat : Person
{
    double Løn;
    internal double Provision;
    internal double TotalSalg;
    internal double GrundLøn = 10.5; //Det er et dårligt job.
    public double TotalLøn(double ProvisionsPenge)
    {
        return ProvisionsPenge + GrundLøn;
    }
    public double ProvisionTotal(double TotalSalg)
    {
        double ProvisionsPenge = TotalSalg * 0.05; //han får 5% af hans totale salg.
        Console.WriteLine(ProvisionsPenge); //Penge han får udbetalt som provision
        return ProvisionsPenge;
    }
    
}



//Invoke / call a method
//person1.hat();
public class Person
{
    // Definition of a type
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Address { get; set; }

    public int PhoneNumber { get; set; } = 0;
    public int age { get; set; } = 0;

    

 
    public string PastePerson => FirstName + " " + LastName + " " + Address + Convert.ToString(PhoneNumber) + Convert.ToString(age);
    public void SetToZero()
    {
        FirstName = "0";
        LastName = "0";
        Address = "0";
        PhoneNumber = 0;
        age = 0;
    }
}
