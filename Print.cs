public class Print
{
    public string name;
    public string surname;
    public string age;
    public string ID;
    public string salary;

    public User(string name, string surname, string ID, string age, int salary)
    {
        this.name = name;
        this.surname = surname;
        this.ID = ID;
        this.age = age;
        this.salary = salary;
    }

    public string PrintStaffInfo()
    {
        return "Staff information is : " 
        + this.name + " " + this.surname + " " +
         this.age + " Age : " +
         this.salary + " Salary is : " ;
    }

    public string PrintCoFounderInfo()
    {
        return "Co - Founder information is : " 
        + this.name + " " + this.surname + " " +
         this.ID + " ID Card Number is : " ;
    }
}