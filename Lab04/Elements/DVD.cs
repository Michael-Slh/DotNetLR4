namespace Lab04.Elements
{
    public class DVD : Device
    {
        public bool AutoRepeat { get; private set; } = false;
        public double Speed { get; private set; } = 1;
        public void TurnAutoRepeatOn()
        {
            if (!AutoRepeat)
                AutoRepeat = true;
        }
        public void TurnAutoRepeatOff()
        {
            if (AutoRepeat)
                AutoRepeat = false;
        }
        public void SetSpeed(double speed)
        {
            if (speed >= 0.5 && speed <= 4)
                Speed = speed;
        }
        public void ResetSpeed()
        {
            Speed = 1;
        }
    }
}
