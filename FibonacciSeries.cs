using System;

public class FibonacciSeries
{
	public int firstNum = 0, secondNum = 1, result = 0;

	public void FindFibonacciSeries()
	{
		Console.WriteLine("Please Enter Number To Generate Series");
		int num = Convert.ToInt32(Console.Readline());
		Console.WriteLine("User number is: "+ num);
		result = firstNum + secondNum;
		Console.WriteLine("Series are:" + firstNum + "\t" + secondNum);
		for(int i=2;i<num;i++)
        {
			firstNum = secondNum;
			secondNum = result;
			Console.Write(" " + result);
			result = firstNum + secondNum;
        }

	}
}
