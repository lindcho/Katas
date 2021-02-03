using System;

namespace AtmPinKata
{
    public class Pin
    {
        public static bool ValidatePin(string pin)
        {
            var isNumeric = false;
            if (!string.IsNullOrEmpty(pin) && (pin.Length == 4 || pin.Length == 6))
            {
                isNumeric = int.TryParse(pin, out _);
            }
            return isNumeric;
        }
    }
}
