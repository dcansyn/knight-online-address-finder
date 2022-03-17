using KO.Provider.Domains;
using System.Collections.Generic;

namespace KO.Provider
{
    public class Client
    {
        public static List<Game> Games { get; set; } = new List<Game>();
        public static List<OperationCode> Codes { get; set; } = new List<OperationCode>();

        public readonly static List<Address> Addresses = new List<Address>()
        {
            new Address(true, "KO_PTR_CHR", "A1QQ8988QQ8B0D"),
        };
    }
}
