
public class Window:IButtonClickObserver
{
    Button _btn = new Button();
    TextBox _text = new TextBox();
    
    public Window()
    {
    
        _btn.Subscribe(this);
    }
    public void CaptureButtonClick()
    {
        _btn.OnClick();
    }
    public void Notify()
    {
       _text.Clear();
    }
}


public interface IButtonClickObserver
{
     void Notify();
}

public class Button 
{
    List<IButtonClickObserver> observers=new  List<IButtonClickObserver>();
    public void Subscribe(IButtonClickObserver observer) {​​​​​​​ this.observers.Add(observer));
    public void UnSubscribe(IButtonClickObserver observer) {​​​​​​​ this.observers.Remove(observer));
    
    public void OnClick()
    {
        foreach(IButtonClickObserver observer in observers)
        {
            observer.Notify();
        }       
    }
}

public class TextBox 
{
    public void Clear()
    {
        Console.WriteLine("Text Box Content Cleared");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Window _window = new Window();
        while(true)        
        {
            Console.WriteLine("Press Any Key To Press Button");
            Console.ReadKey();
            _window.CaptureButtonClick();
        }
     }
   }
}






