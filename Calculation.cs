using System;

public class Calculation
{
	private double num1;
	private double num2;
	private string calculationOperator;
	private double result=0.00;

	public double Num1 {
		get
		{
			return num1;
		}

		set 
		{
			num1 = value;
		}
	}

	public double Num2
	{
		get
		{
			return num2;
		}

		set
		{
			num2 = value;
		}
	}

	public string CalculationOperator
	{
		get
		{
			return calculationOperator;
		}

		set
		{
			calculationOperator = value;
		}
	}

	public double Result
	{
		get
		{
			return result;
		}

		set
		{
			result = value;
		}
	}

	public string getCalculation()
	{
		return num1.ToString() + " " + calculationOperator.ToString() + " " +  num2.ToString() + " = " +  result.ToString();
	}
}
