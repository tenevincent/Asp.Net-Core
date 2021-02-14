﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Services
{
    public interface IChatRoomService
    {
        Task<Guid> CreateRoom(string connectionId);

        Task<Guid> GetRoomForConnectionId(string connectionId);
    }
}
