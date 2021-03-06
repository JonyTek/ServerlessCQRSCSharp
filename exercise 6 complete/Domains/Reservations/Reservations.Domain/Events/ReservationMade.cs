﻿using System;

namespace Reservations.Domain.Events
{
    //virtual workshop ex-5 hint
    public class ReservationMade
    {
        public Guid Id { get; private set; }
        public Guid HotelId { get; private set; }
        public string RoomType { get; private set; }

        public ReservationMade(Guid id, Guid hotelId, string roomType)
        {
            Id = id;
            HotelId = hotelId;
            RoomType = roomType;
        }
    }
}
