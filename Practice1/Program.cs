using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите размер массива");
			int SizeArray = Convert.ToInt32(Console.ReadLine());
			int[] numbers = new int[SizeArray];
			InputArray(numbers);
			OutInputArray(numbers);
			MeanValueAndAmount(numbers, SizeArray);
		}

		static void InputArray(int[] numbers)
		{
			Random rand = new Random();
			for(int i=0; i< numbers.Length; i++)
			{
				numbers[i] = rand.Next(100);
			}
		}

		static void MeanValueAndAmount(int[] numbers, int SizeArray)
		{
			int _MeanValue=0;
			int amount=0;
			foreach(int number in numbers)
			{
				amount += number;
			}
			_MeanValue = amount / SizeArray;
			Console.WriteLine("Среднее значение: {0}",_MeanValue);
			Console.WriteLine("Сумма: {0}", amount);
		}

		static void OutInputArray(int[] numbers)
		{
			foreach (int number in numbers)
			{
				Console.WriteLine(number);
			}
		}
	}
}
