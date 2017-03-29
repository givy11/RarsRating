using System;
using RarsCore;
using System.Text;

namespace RateFilm
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("RARS-определитель");
			Console.WriteLine("© 2017 Дмитрий Гурьянов. givy11@gmail.com");
			Console.WriteLine("Для продолжения нажмите любую клавишу");
			Console.ReadKey();

			RarsRating rating = new RarsRating();

			foreach (Question question in rating.Questions)
			{
				int rate = AskQuestion(question);
				if (rate > rating.CurrentRating)
				{
					rating.CurrentRating = rate;
				}
			}
			Console.Clear();
			Console.WriteLine($"Ваша информационная продукция предназначена для лиц старше {rating.CurrentRating} лет");
			Console.ReadKey();
        }

		static int AskQuestion(Question question)
		{
			Console.Clear();
			Console.WriteLine(question.Text);
			Console.WriteLine("Варианты:");
			for (int i = 0; i < question.Variants.Count; i++)
			{
				Console.WriteLine(i + " - " + question.Variants[i].Description);
			}
			string response = Console.ReadLine();
			int var = Convert.ToInt32(response);
			if (var >= 0 && var < question.Variants.Count)
			{
				return question.Variants[var].Value;
			}
			else
			{
				return 18;
			}
		} 
    }
}