using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MNKINO.Models
{
    public class ScreeningRepolistorycs : IScreeningRepository
    {
        public bool SaveAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Screening> GetAllScreenings()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Screening> GetAllScreeningsWithVideos()
        {
            throw new NotImplementedException();
        }

        public void AddScreenings(Screening newScreening)
        {
            throw new NotImplementedException();
        }

        public Screening GetScreeningByNumber(int number)
        {
            throw new NotImplementedException();
        }

        public Screening GetScreeningByTheme(string theme)
        {
            throw new NotImplementedException();
        }

        public void AddVideo(int screeingNumber, Video newVideo)
        {
            throw new NotImplementedException();
        }
    }
}
