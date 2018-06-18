using System.ComponentModel.DataAnnotations;

namespace HW1.Validation
{
    class MobileAccountValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var mobileAccount = value as MobileAccount;

            if (mobileAccount != null && string.IsNullOrEmpty(mobileAccount.FirstName))
            {
                ErrorMessage = "FirstName is Null";
                return false;
            }

            if (mobileAccount != null && string.IsNullOrEmpty(mobileAccount.LastName))
            {
                ErrorMessage = "LastName is Null";
                return false;
            }

            return true;
        }
    }
}
