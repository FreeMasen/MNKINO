using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Logging;

namespace MNKINO.Models
{
    public class ScreeningRepolistory : IScreeningRepository
    {
        private MnkinoContext _context;
        private ILogger _logger;

        public ScreeningRepolistory(MnkinoContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }

        public IEnumerable<Screening> GetAllScreenings()
        {
            try
            {
                return _context.Screenings
                    .OrderBy(t => t.Number)
                    .Reverse()
                    .ToList();

            }
            catch (Exception ex)
            {
                _logger.LogError("Could not get screenings from database", ex);
                return null;
            }
        }

        public IEnumerable<Screening> GetAllScreeningsWithVideos()
        {
           try
            {
                return _context.Screenings
                    .Include(t => t.Videos)
                    .OrderBy(t => t.Number)
                    .Reverse()
                    .ToList();

            }
            catch (Exception ex)
            {
                _logger.LogError("Could not get screenings from database", ex);
                return null;
            }
        }

        public void AddScreening(Screening newScreening)
        {
            _context.Add(newScreening);
        }

        public Screening GetScreeningByNumber(int number)
        {
            return _context.Screenings
                .Include(t => t.Videos)
                .FirstOrDefault(t => t.Number == number);
        }

        public Screening GetScreeningByTheme(string theme)
        {
            return _context.Screenings
                .Include(t => t.Videos)
                .FirstOrDefault(t => t.Theme == theme);
        }

        public void AddVideo(int screeingNumber, Video newVideo)
        {
            var screening = GetScreeningByNumber(screeingNumber);
            screening.Videos.Add(newVideo);
            _context.Add(screening);
        }
    }
}
