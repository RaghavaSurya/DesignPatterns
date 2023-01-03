public class Fibbonacci{

    public Fibbonacci(){
        
    }       

    public void Play(int n){
       int[] traversed = new int[n+1];
       
       for (int j = 0; j <= n; j++)
       {
            traversed[j] = -1;
       }

       int result = fib(n,traversed);
       
       System.Console.WriteLine(result);
    }

    private int fib(int n,int[] traversed){     // 5
      if(traversed[n] != -1){
        return traversed[n];
      }
      else if(n <= 1){
        return n;
      }
      else{
        int result = fib(n-1, traversed) + fib(n-2, traversed);
        traversed[n] = result;
        return result;
      }
    }
} 