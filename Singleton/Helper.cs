public class SingletonEager {
    private static SingletonEager instance = new SingletonEager();

    private SingletonEager(){

    }

    public void PrintMethod(){
        System.Console.WriteLine("Printing from Singleton Eager type");
    }

    public static SingletonEager GetInstance(){
        return instance;
    }
}

public class SingletonLazy {
    private SingletonLazy(){

    }
    public static SingletonLazy instance ;

    public static SingletonLazy GetInstance(){
        if(instance == null){
            instance = new SingletonLazy();
        }

        return instance;
    }

     public void PrintMethod(){
        System.Console.WriteLine("Printing from Singleton Eager type");
    }
}