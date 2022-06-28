using Lab04.Elements;
using System.Drawing;

namespace Lab04
{
    public class HomeCinema
    {
        private readonly CinemaResponse<string> _TVConnectionError = new()
        {
            ErrorMessage = "No TV connection was found.",
            HasError = true
        };
        private readonly CinemaResponse<string> _DVDConnectionError = new()
        {
            ErrorMessage = "No DVD connection was found.",
            HasError = true
        };
        private readonly CinemaResponse<string> _recieverConnectionError = new()
        {
            ErrorMessage = "No reciever connection was found.",
            HasError = true
        };

        public TV TV { get; set; }
        public DVD DVD { get; set; }
        public Receiver Receiver { get; set; }

        public CinemaResponse<string> TurnSportMode()
        {
            if (TV is null)
                return _TVConnectionError;
            if (Receiver is null)
                return _recieverConnectionError;

            // TV settings
            TV.SetContrast(78);
            TV.SetBrightness(68);
            TV.SetSaturation(96);
            TV.Hue = Color.Green;


            // Reciever settings
            Receiver.TurnSpatialOn();
            Receiver.SetVolume(75);


            return new CinemaResponse<string>
            {
                Result = "Sport mode turned on..."
            };
        }

        public CinemaResponse<string> TurnClassicMusicMode()
        {

            if (TV is null)
                return _TVConnectionError;
            if (DVD is null)
                return _DVDConnectionError;
            if (Receiver is null)
                return _recieverConnectionError;

            // TV settings
            TV.SetContrast(42);
            TV.SetBrightness(38);
            TV.SetSaturation(40);
            TV.Hue = Color.Brown;

            // Reciever settings
            Receiver.TurnSpatialOn();
            Receiver.SetVolume(60);

            // DVD settings
            DVD.TurnAutoRepeatOn();

            return new CinemaResponse<string>
            {
                Result = "Classic mode turned on..."
            };
        }

        public CinemaResponse<string> TurnFilmMode()
        {
            if (TV is null)
                return _TVConnectionError;
            if (Receiver is null)
                return _recieverConnectionError;

            // TV settings
            TV.SetContrast(76);
            TV.SetBrightness(65);
            TV.SetSaturation(78);
            TV.Hue = Color.Orange;

            // Reciever settings
            Receiver.TurnSpatialOn();
            Receiver.SetVolume(70);

            return new CinemaResponse<string>
            {
                Result = "Classic mode turned on..."
            };
        }

        public void TurnOn()
        {
            TV?.TurnOn();
            DVD?.TurnOn();
            Receiver?.TurnOn();
        }
        public void TurnOff()
        {
            TV?.TurnOff();
            DVD?.TurnOff();
            Receiver?.TurnOff();
        }
    }
}
