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
