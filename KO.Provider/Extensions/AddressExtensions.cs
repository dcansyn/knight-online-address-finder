using KO.Core.Extensions;
using KO.Provider.Domains;
using KO.Provider.Enums.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KO.Provider.Extensions
{
    public static class AddressExtensions
    {
        public static void CollectAddresses(this Game game)
        {
            var list = new List<Address>();
            foreach (var address in Client.Addresses)
            {
                var item = address.Clone();

                // Generate
                if (item.Type == AddressType.Generate)
                {

                    continue;
                }

                // Read
                item.CollectAddress(game);

                // Done
                list.Add(item);
            }

            game.UpdateAddresses(list);
        }

        public static Address CollectAddress(this Address address, Game game)
        {
            var value = game.Handle.ReadAddress(address.Hex, address.Start, address.Length) + address.Hex.Length / 2;
            var result = game.Handle.ReadLong(value);
            address.Find(value, result);

            return address;
        }
    }
}
