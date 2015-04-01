// Problem 2. Bank accounts
// - A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts.
//   Customers could be individuals or companies.
// - All accounts have customer, balance and interest rate (monthly based).
//      - Deposit accounts are allowed to deposit and with draw money.
//      - Loan and mortgage accounts can only deposit money.
// - All accounts can calculate their interest amount for a given period (in months).
//   In the common case its is calculated as follows: number_of_months * interest_rate.
// - Loan accounts have no interest for the first 3 months if are held by individuals
//   and for the first 2 months if are held by a company.
// - Deposit accounts have no interest if their balance is positive and less than 1000.
// - Mortgage accounts have ½ interest for the first 12 months for companies and no interest
//   for the first 6 months for individuals.
// - Your task is to write a program to model the bank system by classes and interfaces.
// - You should identify the classes, interfaces, base classes and abstract actions and
//   implement the calculation of the interest functionality through overridden methods.

namespace Bank
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    using Bank.Accounts;
    using Bank.Customers;
    using Bank.Interfaces;

    public static class TestBankAccounts
    {
        public static void Main()
        {
            var peterAtanasov = new IndividualCustomer("Peter Atanasov");
            var mihailStoyanov = new IndividualCustomer("Mihail Stoyanov");
            var kirilKolev = new IndividualCustomer("Kiril Kolev");

            var mtel = new CompanyCustomer("Mtel");
            var microsoft = new CompanyCustomer("Microsoft");
            var telerik = new CompanyCustomer("Telerik");

            var individualDepositAccount = new DepositAccount(peterAtanasov, 0.05m);
            individualDepositAccount.Deposite(300m);

            var companyDepositAccount = new DepositAccount(mtel, 0.4m);
            companyDepositAccount.Deposite(60000m);

            var individualLoanAccount = new LoanAccount(mihailStoyanov, 0.03m);
            individualLoanAccount.Deposite(10m);

            var companyLoanAccount = new LoanAccount(microsoft, 0.1m);
            companyLoanAccount.Deposite(14000m);

            var individualMortgageAccount = new MortgageAccount(kirilKolev, 0.15m);
            individualMortgageAccount.Deposite(5000m);

            var companyMortgageAccount = new MortgageAccount(telerik, 0.6m);
            companyMortgageAccount.Deposite(1000000m);

            var accounts = new List<IAccount>()
            {
                individualDepositAccount,
                individualLoanAccount,
                individualMortgageAccount,
                companyDepositAccount,
                companyLoanAccount,
                companyMortgageAccount
            };

            PrintAccountsInfo(accounts);

            int periodInMounths = 4;

            PrintAccountsInterestAmmountForPeriod(accounts, periodInMounths);

            periodInMounths = 15;

            PrintAccountsInterestAmmountForPeriod(accounts, periodInMounths);
        }

        private static void PrintAccountsInfo(ICollection<IAccount> accounts)
        {
            Console.WriteLine("-------------");
            Console.WriteLine("All accounts:");
            Console.WriteLine("-------------");

            foreach (var account in accounts)
            {
                Console.WriteLine(account);
            }
        }

        private static void PrintAccountsInterestAmmountForPeriod(ICollection<IAccount> accounts, int periodInMounths)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Interest ammount for next {0} mounts:", periodInMounths);
            Console.WriteLine("-------------------------------------");

            foreach (var account in accounts)
            {
                Console.WriteLine("{0,-20} Interest amount: {1}", account.Customer.Name, account.InterestAmountForPeriod(periodInMounths));
            }
        }
    }
}