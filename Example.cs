static int FeetToInches(int feet)
{
    Employee e = new()
    {
        Name = "Nithin"
    };
    e.Dump();
    int inches = feet * 12;
    return inches;
}
FeetToInches(30).Dump();
class Employee
{
    public string? Name { get; set; }
    public int Age { get; set; }
}




////int FeetToInches(int feet)
////{
////    int inches = feet * 12;
////    return inches;
////}


