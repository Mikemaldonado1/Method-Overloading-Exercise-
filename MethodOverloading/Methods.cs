using System;
namespace MethodOverloading
{
	public class Methods
	{
		public static int Add(int num1, int num2)
		{
			return num1 + num2;
		}


		public static decimal Add(decimal num1, decimal num2)
		{
			return num1 + num2;
		}


		public static string Add(int num1, int num2, bool input1)
		{
			int sum = num1 + num2;


			if (input1)
			{
				if (sum == 1)
				{
					return "1 dollar";
				}

				else
				{
					return $"{sum} dollars";
				}
			}
			else
			{
				return "You have an invalid entry!";
			}

			//else
			//{
			//	return "Please enter a valid number";
			//}
		}
		



	}

}
//Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
//If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.
//You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”
