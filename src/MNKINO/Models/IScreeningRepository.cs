using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MNKINO.Models
{
    public interface IScreeningRepository
    {
        bool SaveAll();
        IEnumerable<Screening> GetAllScreenings();
        IEnumerable<Screening> GetAllScreeningsWithVideos();
        void AddScreening(Screening newScreening);
        Screening GetScreeningByNumber(int number);
        Screening GetScreeningByTheme(string theme);
        void AddVideo(int screeingNumber, Video newVideo);
    }
}
