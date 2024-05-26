using EntityModels;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Text.RegularExpressions;
using UIModels;

namespace BusinessLogic.Validation
{
    public class PersonValidator
    {
        Regex vName;
        Regex vAddress;
        Regex vDigit;
        Regex vEmail;
        Regex vPassword;
        public PersonValidator()
        {
            // Allows upper/lowercase + space (\s) + hyphen (-)
            vName = new Regex("^[A-Za-zÆØÅæøå-]+\\s?[A-Za-zÆØÅæøå-]+$");
            // Same as name + digits (0-9) + comma (,) + period (.)
            vAddress = new Regex("^[A-Za-zÆØÅæøå0-9\\s-,.]+$");
            // Allows digits
            vDigit = new Regex("^[0-9]+$");
            // Left of @ as Address but underscore (_) instead of comma
            // Right of @ same with underscore
            // After a period min 2 letters
            vEmail = new Regex("^[A-Za-z0-9-_.]+@[A-Za-z0-9-.]+\\.[A-Za-z]{2,}$");
            vPassword = new Regex("^[A-Za-zÆØÅæøå0-9-!.]{4,30}$");
        }

        public bool ValidName(string name)                      // Name     --*
        {
            return !string.IsNullOrWhiteSpace(name)
                && name.Length >= 2 && name.Length <= 30        // Length
                && vName.IsMatch(name);                         // Pattern
        }

        public bool ValidAddress(string address)                // Address  --*
        {
            return !string.IsNullOrWhiteSpace(address)
                && address.Length >= 3 && address.Length <= 50  // Length
                && vAddress.IsMatch(address);                   // Pattern
        }

        public bool ValidPostalCode(string post)                  // Postcode --*
        {
            return !string.IsNullOrEmpty(post)
                && post.Length == 4                             // Length
                && vDigit.IsMatch(post);                        // Pattern
        }

        public bool ValidEmail(string email)                    // Email    --*
        {
            return !string.IsNullOrEmpty(email)
                && email.Length > 5 && email.Length < 50        // Length
                && vEmail.IsMatch(email);                       // Pattern
        }

        public bool ValidPhone(string phone)                    // Phone    --*
        {
            return !string.IsNullOrEmpty(phone)
                && phone.Length == 8                            // Length
                && vDigit.IsMatch(phone);                       // Pattern
        }

        public bool ValidPassword(string password)
        {
            return !string.IsNullOrEmpty(password)
                && vPassword.IsMatch(password);
        }


        public bool ValidLogin(LoginDetailsUI loginDetails)
        {
            return ValidEmail(loginDetails.Username) &&
                ValidPassword(loginDetails.Password);
        }

        public bool ValidEmployee(EmployeeUI employee)
        {
            return ValidName(employee.Firstname) &&
                ValidName(employee.Lastname) &&
                ValidAddress(employee.AddressLine) &&
                ValidName(employee.City) &&
                ValidPostalCode(employee.PostalCode.ToString()) &&
                ValidEmail(employee.Email) &&
                ValidPhone(employee.PhoneNumber.ToString());
        }
        public bool ValidClient(ClientUI client)
        {
            return ValidName(client.Firstname) &&
                ValidName(client.Lastname) &&
                ValidAddress(client.AddressLine) &&
                ValidName(client.City) &&
                ValidPostalCode(client.PostalCode.ToString()) &&
                ValidEmail(client.Email);

        }

    }
}
