using System;

namespace Exchange_rate_management_system
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] currencyCode = { "1 USD = 1.7000 AZN", "1 EUR = 1.8271 AZN", "1 AUD = 1.2335 AZN", "1 ARS = 0.0141 AZN", "1 BYN = 0.6186 AZN", "1 BRL = 0.3544 AZN", "1 AED = 0.4628 AZN", "1 ZAR = 0.1099 AZN", "1 KRW = 0.1371 AZN", "1 CZK = 0.0740 AZN", "1 CLP = 0.2091 AZN", "1 CNY = 0.2552 AZN", "1 DKK = 0.2456 AZN", "1 GEL = 0.5709 AZN", "1 HKD = 0.2167 AZN", "1 INR = 0.0219 AZN", "1 GPB = 2.1370 AZN", "1 IDR = 0.0118 AZN", "1 IRR = 0.0040 AZN", "1 SEK = 0.1753 AZN", "1 CHF = 1.7747 AZN", "1 ILS = 0.5120 AZN", "1 CAD = 1.3522 AZN", "1 KWD = 5.5556 AZN", "1 KZT = 0.0039 AZN", "1 KGS = 0.0209 AZN", "1 LBP = 0.1125 AZN", "1 MYR = 0.3876 AZN", "1 MXN = 0.0870 AZN", "1 MDL = 0.0894 AZN", "1 EGP = 0.0912 AZN", "1 NOK = 0.1812 AZN", "1 UZS = 0.0155 AZN", "1 PLN = 0.3991 AZN", "1 RUB = 0.0271 AZN", "1 SGD = 1.2394 AZN", "1 SAR = 0.4532 AZN", "1 XDR = 2.2917 AZN", "1 TRY = 0.1031 AZN", "1 TWD = 0.0579 AZN", "1 TJS = 0.1449 AZN", "1 TMT = 0.4857 AZN", "1 UAH = 0.0578 AZN", "1 JPY = 1.3091 AZN", "1 NZD = 1.1143 AZN", "1 XAU = 3174.8520 AZN", "1 XAG = 38.0069 AZN", "1 XPT = 1737.7740 AZN", "1 XPD = 3497.6310 AZN" };
            double[] currencyRate = { 1.7000, 1.8271, 1.2335, 0.0141, 0.6186, 0.3544, 0.4628, 0.1099, 0.1371, 0.0740, 0.2091, 0.2552, 0.2456, 0.5709, 0.2167, 0.0219, 2.1370, 0.0118, 0.0040, 0.1753, 1.7747, 0.5120, 1.3522, 5.5556, 0.0039, 0.0209, 0.1125, 0.3876, 0.0870, 0.0894, 0.0912, 0.1812, 0.0155, 0.3991, 0.0271, 1.2394, 0.4532, 2.2917, 0.1031, 0.0579, 0.1449, 0.4857, 0.0578, 1.3091, 1.1143, 3174.8520, 38.0069, 1737.7740, 3497.6310 };

            bool notFound = true;

            while (true)
            {
                Console.WriteLine("Welcome!");
                Console.WriteLine("/show-recent-currency-rates");
                Console.WriteLine("/find-currency-rate-by-currencyCode");
                Console.WriteLine("/calculate-amount-by-currency");
                Console.WriteLine("/exit");

                string requiredCurrencyCode = Console.ReadLine();

                int currencyIndex = 0;

                if (requiredCurrencyCode == "/show-recent-currency-rates")
                {
                    while (currencyIndex < currencyCode.Length)
                    {
                        Console.WriteLine(currencyCode[currencyIndex]);

                        currencyIndex++;
                    }
                }

                else if (requiredCurrencyCode == "/find-currency-rate-by-currencyCode")
                {
                    Console.WriteLine("Please write the currency : ");
                    string currencyName = Console.ReadLine();

                    for (int i = 0; i < currencyRate.Length; i++)
                    {
                        if (currencyName == currencyCode[i])
                        {
                            Console.WriteLine($"{currencyCode[currencyIndex]}");
                            notFound = false;
                        }
                    }

                        if (notFound)
                        {
                            Console.WriteLine("Daxil etdiyiniz məzənnə tapılmadı");
                        }
                    }

                    else if (requiredCurrencyCode == "/calculate-amount-by-currency")
                    {
                        Console.WriteLine("Məbləği daxil edin : ");
                        double amount = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Məzənnəni seçin : ");

                        string selectedCode = Console.ReadLine();

                        for (int i = 0; i < currencyCode.Length; i++)
                        {
                            if (selectedCode == currencyCode[i])
                            {
                                double result = amount / currencyRate[i];
                                Console.WriteLine(result);

                                notFound = false;
                            }
                        }

                        if (notFound)
                        {
                            Console.WriteLine("Seçdiyiniz məzənnə tapılmadı");
                        }
                    }
                else if (requiredCurrencyCode == "/exit")
                {
                    Console.WriteLine("Proqramımızdan istifadə etdiyiniz üçün təşəkkür edirik!");
                }
                Console.ReadLine();
            }
        }
    }
}
