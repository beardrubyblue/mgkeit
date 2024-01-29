class Program {
	static void Main() {
		Console.WriteLine("Введите значение x:");
		int x = int.Parse(Console.ReadLine());
		double result = x - 10 * Math.Sin(x)+ Math.Abs(Math.Pow(x, 4) - Math.Pow(x, 5));
		Console.WriteLine(result);
	}
}