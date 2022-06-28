using FluentValidation;

namespace Lab04
{
    internal class Program
    {
        static void Main()
        {
            var homeCinema = new HomeCinema
            {
                //DVD = new(),
                TV = new(),
                Receiver = new()
            };
            Realize(homeCinema);
        }

        private static void Realize(HomeCinema homeCinema)
        {
            var inpVal = new InputValidator();
            var finished = false;
            while (!finished)
            {
                Console.WriteLine("0-3");
                string opt = Console.ReadLine();

                var validation = inpVal.Validate(opt);
                
                if (!validation.IsValid)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(validation.ToString());
                    Console.ForegroundColor = ConsoleColor.Gray;
                    continue;
                }
                var result = int.Parse(opt);
                switch (result)
                {
                    case 1:
                        {
                            var res = homeCinema.TurnSportMode();
                            if (res.HasError)
                            {
                                Console.WriteLine(res.ErrorMessage);
                            }
                            else
                                Console.WriteLine(res.Result);
                            break;
                        }
                    case 2:
                        {
                            var res = homeCinema.TurnFilmMode();
                            if (res.HasError)
                            {
                                Console.WriteLine(res.ErrorMessage);
                            }
                            else
                                Console.WriteLine(res.Result);
                            break;
                        }
                    case 3:
                        {
                            var res = homeCinema.TurnClassicMusicMode();
                            if (res.HasError)
                            {
                                Console.WriteLine(res.ErrorMessage);
                            }
                            else
                                Console.WriteLine(res.Result);
                            break;
                        }
                    case 0:
                        finished = true;
                        break;
                }
                Console.Write("Press any button to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    internal class InputValidator : AbstractValidator<string>
    {
        public InputValidator()
        {
            Transform(x => x, StringToNullableInt).NotNull().InclusiveBetween(0, 3);
        }
        private int? StringToNullableInt(string value) => int.TryParse(value, out int val) ? val : null;
    }
}