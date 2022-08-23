// Повторная домашняя задание 4 урока 
// 1 Задача
/*

{
 public static void Main()
 {
  int n1;
  int exp1;
	  Console.Write("\n\nFunction : To calculate the result of raising an integer number to another :\n");
      Console.Write("--------------------------------------------------------------------------------\n");
	  Console.Write("Input Base number: ");
      n1= Convert.ToInt32(Console.ReadLine());
      Console.Write("Input the Exponent : ");
      exp1= Convert.ToInt32(Console.ReadLine());	  
      Console.WriteLine("So, the number {0} ^ (to the power) {1} = {2} ",n1, exp1, PowerRaising(n1, exp1));
 }
 public static int PowerRaising(int num, int exp)
 {
  int rvalue = 1;
  int i;
  for (i=1;i<=exp;i++)
  rvalue=rvalue*num;
  return rvalue;
 }
} 
*/

//2 Задача 
/*

{
    static void Main ()
{
    int n, sum = 0, k;
    Console.Write("Enter the number :");
    n = int.Parse(Console.ReadLine());

    while(n!=0)
    {
        k = % 10;
        n = n / 10;
        sum = sum + k;
    }
    Console.WroteLine(" Sum of Digits = " + sum);

Console.ReadLine();
    }
}

*/

// 3 Задача 
/*
{  
    public static void Main()  
{  
    int[] arr = new int[8]; 
    int i;  
       Console.Write("\n\nRead and Print elements of an array:\n");
       Console.Write("-----------------------------------------\n");	
  
    Console.Write("Input 8 elements in the array :\n");  
    for(i=0; i<8; i++)  
    {  
	    Console.Write("element - {0} : ",i);
	    arr[i] = Convert.ToInt32(Console.ReadLine());  		
    }  
  
    Console.Write("\nElements in array are: ");  
    for(i=0; i<8; i++)  
    {  
        Console.Write("{0}  ", arr[i]);  
    } 
    Console.Write("\n");	
  }
}
*/ 



// 5 Урок 
/* 1 Задача 
 
 int one = 0;
int two = 0;
int[] arr = new int[2];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(2, 100);
    one = arr[0] % 2;
    two = arr[0] / 2;

    if (arr[i] % 2 == 0 && one + two == 100)
        Console.WriteLine(arr[i]);
}
 */

 /* 2 Задача 

 {
     
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        int even = 0, odd = 0;
 
        // Loop to find even, odd sum
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0)
                even += arr[i];
            else
                odd += arr[i];
        }
 
        Console.WriteLine("Even index positions"
                             + " sum: " + even);
                              
        Console.WriteLine("Odd index positions "
                               + "sum: " + odd);
    }
}

*/

/* 3 Задача 

{
    public static void Main()
    {
        int[] arr = { 8, 3, 5, -1, 2 };
 
        Array.Sort(arr);
        if (arr.Length > 0) {
            Console.WriteLine("Minimum number is " + arr[0]);
            Console.WriteLine("Maximum number is " + arr[arr.Length - 1]);
        }
    }
}
*/
 