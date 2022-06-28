namespace Lab04.Elements
{
    public abstract class Device
    {
        public bool IsEnabled { get; protected set; }
        public void TurnOn()
        {
            if (!IsEnabled) IsEnabled = true;
        }
        public void TurnOff()
        {
            if (IsEnabled) IsEnabled = false;
        }
    }
}
