namespace Bank.Common
{
    public static class ErrorMessage
    {
        public const string NullValueFormat = "{0} cannot be null";
        public const string StringNullOrEmptyFormat = "{0} cannot be null or empty";
        public const string ValueLessThanZeroFormat = "{0} cannot be less than zero";
        public const string ValueLessOrEqualToZeroFormat = "{0} cannot be less or equal to zero";
        public const string WithdrawMoreThanCurrentBalanceFormat = "Cannot withdraw more than current balance: {0}";
    }
}