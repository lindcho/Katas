using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace AtmPinKata
{
    public class Pin
    {
        public static bool ValidatePin(string pin)
        {
            var cleanPin = string.IsNullOrEmpty(pin) ? "" : pin;
            var isValidLength = (cleanPin.Length == 4 || cleanPin.Length == 6);
            return isValidLength && cleanPin.All(t => t <= '9' && t >= '0');
        }
    }
}
