using System;
using System.Linq;
using Foosinator.Models;
using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Linq;
using Mindscape.LightSpeed.Querying;

namespace Foosinator.Services
{
    public class GameService
    {
        readonly LightSpeedContext<FoosinatorModelUnitOfWork> _context = new LightSpeedContext<FoosinatorModelUnitOfWork>("Database");

        private const string ActiveGame = "ACTIVE";
        private const string CompletedGame = "DONE";

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
                Game game = unitOfWork.Games.Single(x => x.Id == gameId);

                string player1Name = game.Player1.Name;
                string player2Name = game.Player2.Name;

                if (game.Player3Id != null && game.Player4Id != null)
                {
                    string player3Name = game.Player3.Name;
                    string player4Name = game.Player4.Name;
                }

                return game;
            }
        }

        public Game GetActiveGame()
        {
            using (FoosinatorModelUnitOfWork unitOfWork = _context.CreateUnitOfWork())
            {
                return unitOfWork.Games.SingleOrDefault(x => x.Status == ActiveGame);
            }
        }

        public void CancelGame(Guid gameId)
        {
            using (FoosinatorModelUnitOfWork unitOfWork = _context.CreateUnitOfWork())
            {
                Game game = unitOfWork.Games.Single(x => x.Id == gameId);
                unitOfWork.Remove(game);
                unitOfWork.SaveChanges();
            }
        }

        public void GameDone(Guid gameId, Guid winningPlayer)
        {
            ResultsService resultsService = new ResultsService();

            Game game = GetGame(gameId);

            if (winningPlayer == game.Player1Id)
            {
                resultsService.IssueWin(gameId, game.Player1Id);
                resultsService.IssueLose(gameId, game.Player2Id);

                if (game.Player3Id != null && game.Player4Id != null)
                {
                    resultsService.IssueWin(gameId, game.Player3Id.Value);
                    resultsService.IssueLose(gameId, game.Player4Id.Value);
                }
            }
            else
            {
                resultsService.IssueWin(gameId, game.Player2Id);
                resultsService.IssueLose(gameId, game.Player1Id);

                if (game.Player3Id != null && game.Player4Id != null)
                {
                    resultsService.IssueWin(gameId, game.Player4Id.Value);
                    resultsService.IssueLose(gameId, game.Player3Id.Value);
                }
            }

            using (FoosinatorModelUnitOfWork unitOfWork = _context.CreateUnitOfWork())
            {
                Game dbGame = unitOfWork.Games.Single(x => x.Id == gameId);
                dbGame.Status = CompletedGame;
                unitOfWork.SaveChanges();
            }
        }
    }
}