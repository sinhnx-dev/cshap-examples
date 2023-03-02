public class Author{
    public string Name {set;get;}
    public string Email {set;get;}
    public char Gender {set;get;}

    public Author(){
        Name = "";
        Email = "";
        Gender = 'M';
    }
    public Author(string name, string email, char gender){
        Name = name;
        Email = email;
        Gender = gender;
    }

    public override string ToString(){
        string gender = Gender=='M'?"Male":"Female";
        return $"{Name} - {Email} - {gender}";
    }
}