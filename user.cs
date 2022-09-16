public class user
{
    string Name;
    string Last;
    string age;
    int money;
    string Type;

    

public user(string Name, string Last, string age,int money,string Type)
{
    this.Name = Name;
    this.Last = Last;
    this.age = age;
    this.money = money;
    this.Type = Type;
}
public void Printuser(string Name, string Last, string age,int money,string Type)
{
    Console.WriteLine("{0} {1} age {2} money{3} type{4}",Name,Last,age,money,Type);
    


}






}