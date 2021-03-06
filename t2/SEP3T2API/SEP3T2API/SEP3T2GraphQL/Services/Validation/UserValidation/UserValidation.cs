using System;
using System.Linq;
using System.Threading.Tasks;
using SEP3T2GraphQL.Models;
using SEP3T2GraphQL.Repositories;

namespace SEP3T2GraphQL.Services.Validation.UserValidation
{
    public class UserValidation
    {
        private static bool IsValidFirstname(string firstname)
        {
            if (firstname != null && IsLettersOnly(firstname))
            {
                return true;
            }

            throw new ArgumentException("Invalid firstname");
        }

        private static bool IsValidLastname(string lastname)
        {
            if (lastname != null && IsLettersOnly(lastname))
            {
                return true;
            }

            throw new ArgumentException("Invalid lastname");
        }

        private static bool IsValidPassword(string password)
        {
            int validConditions = 0;
            if (password == null)
            {
                throw new ArgumentException("invalid password");
            }

            if (password.Length < 8)
            {
                throw new ArgumentException("password must at least be a length of 8 characters");
            }


            foreach (var c in password)
            {
                if (password.Any(char.IsLower))
                {
                    validConditions++;
                    break;
                }

                throw new ArgumentException("password must contain at least one lowercase letter");
            }

            foreach (var c in password)
            {
                if (password.Any(char.IsUpper))
                {
                    validConditions++;
                    break;
                }

                throw new ArgumentException("password must contain at least one uppercase letter");
            }

            foreach (var c in password)
            {
                if (password.Any(char.IsDigit))
                {
                    validConditions++;
                    break;
                }

                throw new ArgumentException("password must contain at least one number");
            }

            if (validConditions == 3)
            {
                return true;
            }

            throw new ArgumentException("password invalid");
        }


        private static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (phoneNumber != null && phoneNumber.All(char.IsDigit))
            {
                return true;
            }

            throw new ArgumentException("invalid phone number");
        }

        public async Task<bool> IsValidUser(User user)
        {
            if (IsValidFirstname(user.FirstName) && IsValidLastname(user.LastName) &&
                IsValidPassword(user.Password) && IsValidPhoneNumber(user.PhoneNumber))
            {
                return true;
            }
            throw new ArgumentException("Invalid host");
        }

        private static bool IsLettersOnly(string arg)
        {
            if (arg.All(char.IsLetter))
            {
                return true;
            }
            return false;
        }
    }
}