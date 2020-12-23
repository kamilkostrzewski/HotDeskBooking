using System;

namespace HotDeskBooking.Domain.Abstract
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
    }
}