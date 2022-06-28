namespace Lab04.Elements
{
    public class Receiver : Device
    {
        public int Volume { get; private set; } = 0;
        public bool IsSpatialSound { get; private set; } = false;

        public void Mute()
        {
            Volume = 0;
        }
        public void SetVolume(int volume)
        {
            if (Volume >= 0 && Volume <= 100)
                Volume = volume;
        }
        public void VolumeUp()
        {
            if (Volume < 100)
                Volume++;
        }
        public void VolumeDown()
        {
            if (Volume > 0)
                Volume--;
        }
        public void TurnSpatialOn()
        {
            if (!IsSpatialSound)
                IsSpatialSound = true;
        }
        public void TurnSpatialOff()
        {
            if (IsSpatialSound)
                IsSpatialSound = false;
        }
    }
}
