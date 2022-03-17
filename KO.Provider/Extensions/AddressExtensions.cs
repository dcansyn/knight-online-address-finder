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
                    var value = game.Handle.ReadAddress(address.Hex, address.Start, address.Length) + address.Hex.Length / 2;
                    var result = game.Handle.ReadLong(value);
                    address.Find(value, result);
                    break;
                case AddressType.Offset:
                    
                    break;
                case AddressType.Call:
                    var callAddress = game.Handle.ReadAddress(address.Hex, address.Start, address.Length) + address.Hex.Length / 2;
                    var callHexAddress = game.Handle.ReadCallHexAddress(address.Hex, callAddress);
                    var callResult = (callAddress + callHexAddress + 5).ConvertIntToHex();
                    /// TODO
                    break;
            }

            if (game.Title == "2345")
            {
                var value = game.Handle.ReadAddress(address.Hex, address.Start, address.Length) + address.Hex.Length / 2;
                var result = game.Handle.ReadLong(value);
                address.Find(value, result);
            }
            else
            {
                var value = game.Handle.ReadAddress(address.Hex, address.Start, address.Length) + address.Hex.Length / 2;
                var result = game.Handle.ReadLong(value);
                address.Find(value, result);
            }

            return address;
        }
    }
}
/*
004A59E6  |. 8B0D 7824F200            MOV ECX,DWORD PTR DS:[F22478]
004A59EC  |. 52                       PUSH EDX                                 ; /Arg2
004A59ED  |. 56                       PUSH ESI                                 ; |Arg1
004A59EE  |. E8 3D9BFFFF              CALL 2345_dum.0049F530                   ; \2345_dum.0049F530
*/