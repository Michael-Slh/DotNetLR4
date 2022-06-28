namespace Lab04
{
    public class CinemaResponse<A>
    {
        public bool HasError { get; set; } = false;
        public string ErrorMessage { get; set; } = string.Empty;
        public A? Result { get; set; }
    }
}
