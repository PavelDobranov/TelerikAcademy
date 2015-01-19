// Problem 11. Bank Account Data
// A bank account has a holder name (first name, middle name and last name), available amount of money
// (balance), bank name, IBAN, 3 credit card numbers associated with the account.
// Declare the variables needed to keep the information for a single bank account 
// using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Pesho";
        string middleName = "Dimitrov";
        string lastName = "Ivanov";
        decimal moneyBalance = 335000.65M;
        string bankName = "DIYBank";
        string iban = "GB15 MIDL 4005 1512 3456";
        ulong firstCardNumber = 1231234564569876;
        ulong secondCardNumber = 1232135698453681;
        ulong thirdCardNumber = 1231236596947895;
    }
}