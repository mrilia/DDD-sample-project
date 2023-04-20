namespace TravelChecklist.Domain.Exceptions
{
    public class InvalidTemperatureException : Exception
    {
        public double Value { get; }

        public InvalidTemperatureException(double value) : base($"Value '{value}' is invalid temperature.")
            => Value = value;
    }
}
