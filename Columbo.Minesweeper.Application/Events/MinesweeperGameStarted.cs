﻿using System;

namespace Columbo.Minesweeper.Application.Events
{
    public class MinesweeperGameStarted : IDomainEvent
    {       
        public MinesweeperGameStarted(Guid game_id)
        {
            this.game_id = game_id;
        }

        public Guid game_id { get; private set; }
    }
}