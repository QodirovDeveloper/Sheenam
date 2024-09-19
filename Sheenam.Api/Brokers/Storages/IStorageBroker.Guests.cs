//==================================================
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use Comfort And Peace
//==================================================

using System.Threading.Tasks;
using Sheenam.Api.Models.Foundations.Guests;

namespace Sheenam.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Guest> InsertGuestAsync(Guest guest);
    }
}
