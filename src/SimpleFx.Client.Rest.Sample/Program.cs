using System;
using System.Threading.Tasks;
using SimpleFx.Client.Generated.Api;
using SimpleFx.Client.Generated.Client;
using SimpleFx.Client.Generated.Model;

namespace SimpleFx.Client.Rest.Sample
{
    class Program
    {
        private static readonly string ApiKey = "";
        private static readonly string ApiSecret = "";

        static void Main(string[] args)
        {
            Console.WriteLine("SimpleFX client");

            TestClient().Wait();

            Console.WriteLine("Finished..");
            Console.ReadLine();
        }

        private static async Task TestClient()
        {
            await DisplayInstruments();
            await DisplayAccounts();
        }

        private static async Task DisplayAccounts()
        {
            if (string.IsNullOrWhiteSpace(ApiSecret))
                return;

            var accessToken = await GetAccessToken(ApiKey, ApiSecret);
            GlobalConfiguration.Instance.DefaultHeaders.Add("Authorization", $"Bearer {accessToken}");

            var client = new AccountsApi();
            var accounts = await client.V3AccountsGetAccountsAsync();
            foreach (var account in accounts.Data)
            {
                Console.WriteLine($"Account | id: {account.Login,8}  balance: {account.Balance:0.0000} {account.Currency}");
            }

            Console.WriteLine();
        }

        private static async Task<string> GetAccessToken(string key, string secret)
        {
            var client = new AUTHENTICATIONApi();
            var response = await client.ApiV3AuthKeyPostAsync(new InlineObject(key, secret));
            return response.Data.Token;
        }

        private static async Task DisplayInstruments()
        {
            var client = new MarketApi("https://simplefx.com");
            var instruments = await client.UtilsInstrumentsJsonGetAsync();
            foreach (var response in instruments)
            {
                var instrument = response.Value;
                Console.WriteLine(
                    $"Instrument | key: {response.Key,6}  symbol: {instrument.Symbol,10}  quotes: {instrument.Quote.B}/{instrument.Quote.A} {instrument.PriceCurrency}");
            }

            Console.WriteLine();
        }
    }
}
