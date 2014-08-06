using System;
using System.Collections.Generic;
using System.Linq;
using Foosinator.Models;
using Mindscape.LightSpeed;

namespace Foosinator.Services
{
    public class PlayersService
    {
        readonly LightSpeedContext<FoosinatorModelUnitOfWork> 
            _context = new LightSpeedContext<FoosinatorModelUnitOfWork>("Database");

        public List<Player> GetAllPlayers()
        {
            using (FoosinatorModelUnitOfWork unitOfWork = _context.CreateUnitOfWork())
            {
                return unitOfWork.Players.ToList();
            }
        }

        public Player GetPlayer(Guid playerId)
        {
            using (FoosinatorModelUnitOfWork unitOfWork = _context.CreateUnitOfWork())
            {
                return unitOfWork.Players.SingleOrDefault(x => x.Id == playerId);
            }
        }

        public bool HasPlayerWithName(string name)
        {
            using (FoosinatorModelUnitOfWork unitOfWork = _context.CreateUnitOfWork())
            {
                return unitOfWork.Players.Any(x => x.Name == name);
            }
        }

        public Player CreatePlayer(string name)
        {
            using (FoosinatorModelUnitOfWork unitOfWork = _context.CreateUnitOfWork())
            {
                Player player = new Player
                                {
                                    Name = name,
                                    Created = DateTime.UtcNow,
                                    Id = Guid.NewGuid()
                                };

                unitOfWork.Add(player);
                unitOfWork.SaveChanges();

                return player;
            }
        }
    }
}