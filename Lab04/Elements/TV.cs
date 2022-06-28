using System.Drawing;

namespace Lab04.Elements
{
    public class TV : Device
    {
        public double Brightness { get; private set; } = 50;
        public double Saturation { get; private set; } = 50;
        public double Contrast { get; private set; } = 50;
        public Color Hue { get; set; } = Color.Red;

        public void SetBrightness(double brightness)
        {
            if (brightness >= 0 && brightness <= 100)
                Brightness = brightness;
        }
        public void SetSaturation(double saturation)
        {
            if (saturation >= 0 && saturation <= 100)
                Saturation = saturation;
        }
        public void SetContrast(double contrast)
        {
            if (contrast >= 0 && contrast <= 100)
                Contrast = contrast;
        }
    }
}
