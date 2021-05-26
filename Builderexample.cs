# Sample1
 
class Customer{
 
string  name;
string pancard;
string address;
string contactNumber;
string emailId;
string employeerName;
 
   public Customer(string name,string panCard){}
   public void SetEmailId(){}
}
class CustomerBuilder{
 
Customer obj;
    public CustomerBuilder(string name ,string panCard){
 
        obj=new Customer(name,panCard);
       }
    public CustomerBuilder SetContactNumber(string contactNumer){ obj.ContactNumber=contactNumber; return this;}
    public CustomerBuilder SetEmail(string email){ obj.ContactNumber=contactNumber; return this;}
    public CustomerBuilder SetEmployeerName(string employeer){ obj.ContactNumber=contactNumber; return this;}
        public Customer GetCustomer(){ return obj;}
}
 

Customer obj=new CustomerBuilder("XXXX","fffffff").SetEmail("ZZZZZZZ@gmail.com").getCustomer();
Customer obj=new CustomerBuilder("XXXX","fffffff").SetEmail("zzzzzzz@gmail.com").setContactNumber("xcv".)getCustomer();



# Sample 2
 
 public interface IToyBuilder {  
    void SetModel();  
    void SetHead();  
    void SetLimbs();  
    void SetBody();  
    void SetLegs();  
    Toy GetToy();  
}  

public class Toy {  
    public string Model {  
        get;  
        set;  
    }  
    public string Head {  
        get;  
        set;  
    }  
    public string Limbs {  
        get;  
        set;  
    }  
    public string Body {  
        get;  
        set;  
    }  
    public string Legs {  
        get;  
        set;  
    }  
}  

public class ToyABuilder: IToyBuilder {  
    Toy toy = new Toy();  
    public void SetModel() {  
        toy.Model = "TOY A";  
    }  
    public void SetHead() {  
        toy.Head = "1";  
    }  
    public void SetLimbs() {  
        toy.Limbs = "4";  
    }  
    public void SetBody() {  
        toy.Body = "Plastic";  
    }  
    public void SetLegs() {  
        toy.Legs = "2";  
    }  
    public Toy GetToy() {  
        return toy;  
    }  
} 

public class ToyBBuilder: IToyBuilder {  
    Toy toy = new Toy();  
    public void SetModel() {  
        toy.Model = "TOY B";  
    }  
    public void SetHead() {  
        toy.Head = "1";  
    }  
    public void SetLimbs() {  
        toy.Limbs = "4";  
    }  
    public void SetBody() {  
        toy.Body = "Steel";  
    }  
    public void SetLegs() {  
        toy.Legs = "4";  
    }  
    public Toy GetToy() {  
        return toy;  
    }  
}

public class ToyCreator {  
    private IToyBuilder _toyBuilder;  
    public ToyCreator(IToyBuilder toyBuilder) {  
        _toyBuilder = toyBuilder;  
    }  
    public void CreateToy() {  
        _toyBuilder.SetModel();  
        _toyBuilder.SetHead();  
        _toyBuilder.SetLimbs();  
        _toyBuilder.SetBody();  
        _toyBuilder.SetLegs();  
    }  
    public Toy GetToy() {  
        return _toyBuilder.GetToy();  
    }  
}  

void Main() {  
    Console.WriteLine("-------------------------------List Of Toys--------------------------------------------");  
    var toyACreator = new ToyCreator(new ToyABuilder());  
    toyACreator.CreateToy();  
    toyACreator.GetToy().Dump();  
    var toyBCreator = new ToyCreator(new ToyBBuilder());  
    toyBCreator.CreateToy();  
    toyBCreator.GetToy().Dump();  
} 
