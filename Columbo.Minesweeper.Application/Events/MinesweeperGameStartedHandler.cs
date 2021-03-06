﻿using System.Collections.Generic;
using Columbo.Minesweeper.Application.Domain;
using Columbo.Minesweeper.Application.Infrastructure;
using Columbo.Minesweeper.Application.Queries.Views;
using NHibernate.Linq;

namespace Columbo.Minesweeper.Application.Events
{
    public class MinesweeperGameStartedHandler : IDomainEventHandler<MinesweeperGameStarted>
    {
        public void handle(MinesweeperGameStarted domain_event)
        {
            var game = new MinefieldView() { game_id = domain_event.game_id, game_lost = false, game_won = false };

            using (var session = SessionFactory.GetNewSession())
            {
                using (var trans = session.BeginTransaction())
                {
                    session.Save(game);

                    trans.Commit();
                }
            }             
        }
    }
}