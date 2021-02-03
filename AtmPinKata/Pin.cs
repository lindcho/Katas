using System.Linq;

namespace AtmPinKata
{
    public class Pin
    {
        public static bool ValidatePin(string pin)
        {
            return pin.All(char.IsDigit) && (pin.Length == 4 || pin.Length == 6);
        }
    }
}
