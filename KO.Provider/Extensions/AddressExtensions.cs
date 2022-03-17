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

                // Read
                item.CollectAddress(game);

                // Done
                list.Add(item);
            }

            game.UpdateAddresses(list);
        }

        public static Address CollectAddress(this Address address, Game game)
        {
            switch (address.Type)
            {
                case AddressType.Pointer:
                    var pointerValue = game.Handle.ReadAddress(address.Hex, address.Start, address.Length) + address.Hex.Length / 2;
                    var pointerResult = game.Handle.ReadLong(pointerValue);
                    address.Find(pointerValue, pointerResult);
                    break;
                case AddressType.Offset:
                    
                    break;
                case AddressType.Call:
                    var callValue = game.Handle.ReadAddress(address.Hex, address.Start, address.Length) + address.Hex.Length / 2;
                    var callAddress = game.Handle.ReadCallHexAddress(address.Hex, callValue);
                    var callResult = callValue + callAddress + 5;
                    address.Find(callValue, callResult);
                    break;
            }

            return address;
        }
    }
}