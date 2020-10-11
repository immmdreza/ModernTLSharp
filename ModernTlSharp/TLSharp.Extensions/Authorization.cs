using ModernTlSharp.TLSharp.Core;
using ModernTlSharp.TLSharp.Tl.TL;
using ModernTlSharp.TLSharp.Tl.TL.Account;
using System.Threading.Tasks;
using static System.Console;

namespace ModernTlSharp.TLSharp.Extensions
{
    public class Authorization
    {
        private readonly TelegramClient _telegramClient;
        private string _sendCodeHas;

        public string PhoneNumber { get; set; }
        public TLUser TLUser { get; set; }

        public Authorization(TelegramClient telegramClient)
        {
            _telegramClient = telegramClient;
        }

        public Authorization(TelegramClient telegramClient,
            string phoneNumber)
        {
            _telegramClient = telegramClient;
            PhoneNumber = phoneNumber;
        }

        public async Task ConsoleAuthocate()
        {
            if (_telegramClient.IsUserAuthorized())
            {
                WriteLine($"Already authorized ({_telegramClient.Session.TLUser.FirstName})");

                return;
            }

            if (string.IsNullOrEmpty(PhoneNumber))
            {
                WriteLine("Please enter your phone number:");

                PhoneNumber = ReadLine();
            }

            _sendCodeHas = await _telegramClient.SendCodeRequestAsync(PhoneNumber);
            WriteLine("Code Sent!");
            WriteLine("Please enter the code you recieved:");

            string code = ReadLine();

            try
            {
                TLUser = await _telegramClient.MakeAuthAsync(PhoneNumber, _sendCodeHas, code);

                WriteLine($"Successfully authorized as {TLUser.FirstName}");
            }
            catch(Core.Exceptions.CloudPasswordNeededException)
            {
                WriteLine("Looks like your account has cloud password.");

                TLPassword pass = await _telegramClient.SendRequestAsync<TLPassword>(
                    new TLRequestGetPassword());

                WriteLine($"Please enter you password, Hint: {pass.Hint}");
                string password = ReadLine();

                TLUser = await _telegramClient.MakeAuthWithPasswordAsync(pass,
                password);

                WriteLine($"Successfully authorized as {TLUser.FirstName}");
            }
        }
    }
}
