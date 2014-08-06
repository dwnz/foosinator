using System;
using System.Linq;
using Foosinator.Models;
using Mindscape.LightSpeed;

namespace Foosinator.Services
{
    public class GameService
    {
        readonly LightSpeedContext<FoosinatorModelUnitOfWork> _context = new LightSpeedContext<FoosinatorModelUnitOfWork>("Database");

        private const string ActiveGame = "ACTIVE";

        public bool HasActiveGame()
        {
            using (FoosinatorModelUnitOfWork unitOfWork = _context.CreateUnitOfWork())
            {
                return unitOfWork.Games.Any(x => x.Status == ActiveGame);
            }
        }

        public Game CreateGame(Guid playerId, Guid teamPlayerId, Guid vsPlayerId, Guid vsPlayerTeamMateId)
        {
            using (FoosinatorModelUnitOfWork unitOfWork = _context.CreateUnitOfWork())
            {
                Game game = new Game
                            {
                                Created = DateTime.UtcNow,
                                Id = Guid.NewGuid(),
                                Player1Id = playerId,
                                Player2Id = vsPlayerId,
                                Player3Id = NullOrGuid(teamPlayerId),
                                Player4Id = NullOrGuid(vsPlayerTeamMateId),
                                Status = ActiveGame
                            };

                unitOfWork.Add(game);
                unitOfWork.SaveChanges();

                return game;
            }
        }

        Guid? NullOrGuid(Guid playerId)
        {
            if (playerId == Guid.Empty)
                return null;

            return playerId;
        }

        public Game GetGame(Guid gameId)
        {
            using (FoosinatorModelUnitOfWork unitOfWork = _context.CreateUnitOfWork())
            {
                return unitOfWork.Games.Single(x => x.Id == gameId);
            }
        }
    }
}