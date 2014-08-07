using System;
using System.Collections.Generic;
using System.Linq;
using Foosinator.Models;
using Mindscape.LightSpeed;

namespace Foosinator.Services
{
    public class ResultsService
    {
        readonly LightSpeedContext<FoosinatorModelUnitOfWork> _context = new LightSpeedContext<FoosinatorModelUnitOfWork>("Database");

        private const string Win = "WIN";
        private const string Lose = "LOSE";

        public void IssueWin(Guid gameId, Guid playerId)
        {
            using (FoosinatorModelUnitOfWork unitOfWork = _context.CreateUnitOfWork())
            {
                Result result = new Result
                                {
                                    Id = Guid.NewGuid(),
                                    Created = DateTime.UtcNow,
                                    GameId = gameId,
                                    PlayerId = playerId,
                                    Status = Win
                                };

                unitOfWork.Add(result);
                unitOfWork.SaveChanges();
            }
        }

        public void IssueLose(Guid gameId, Guid playerId)
        {
            using (FoosinatorModelUnitOfWork unitOfWork = _context.CreateUnitOfWork())
            {
                Result result = new Result
                {
                    Id = Guid.NewGuid(),
                    Created = DateTime.UtcNow,
                    GameId = gameId,
                    PlayerId = playerId,
                    Status = Lose
                };

                unitOfWork.Add(result);
                unitOfWork.SaveChanges();
            }
        }

        public List<LeaderboardRow> GetLeaderboard()
        {
            List<LeaderboardRow> outputRows = new List<LeaderboardRow>();

            using (FastUnitOfWork fastUnitOfWork = new FastUnitOfWork())
            {
                List<LeaderboardRow> rows = fastUnitOfWork.Query<LeaderboardRow>(@"
                    select 
	                    count(1) as Items,
	                    R.Status,
	                    P.Name,
						P.ProfilePicture
                    from 
	                    Results R
                    inner join
	                    Players P
		                    on R.PlayerId = P.ID
                    group by
	                    P.ID,
	                    R.Status,
	                    P.Name,
						P.ProfilePicture
                ", null).ToList();

                IEnumerable<IGrouping<string, LeaderboardRow>> groupedItems = rows.GroupBy(x => x.Name);
                foreach (IGrouping<string, LeaderboardRow> leaderboardRows in groupedItems)
                {
                    LeaderboardRow winsRow = leaderboardRows.SingleOrDefault(x => x.Status == Win);
                    LeaderboardRow lossesRow = leaderboardRows.SingleOrDefault(x => x.Status == Lose);

                    int wins = 0;
                    int losses = 0;

                    if (winsRow != null)
                    {
                        wins = winsRow.Items;
                    }

                    if (lossesRow != null)
                    {
                        losses = lossesRow.Items;
                    }

                    outputRows.Add(new LeaderboardRow
                                   {
                                       Name = leaderboardRows.Key,
                                       Points = wins - losses,
                                       Wins = wins,
                                       Losses = losses,
                                       ProfilePicture = leaderboardRows.First().ProfilePicture
                                   });
                }
            }

            return outputRows.OrderByDescending(x => x.Points).ToList();
        }
    }
}