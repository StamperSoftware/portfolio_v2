using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class TrackerService(PortfolioContext db):ITrackerService
{
    public async Task<Tracking> AddTracker()
    {
        var tracking = await db.Trackings.FirstOrDefaultAsync();
        if (tracking == null)
        {
            tracking = new Tracking{Count = 1};
            await db.Trackings.AddAsync(tracking);
        }
        else
        {
            tracking.Count++;
            db.Trackings.Update(tracking);
        }
        await db.SaveChangesAsync();
        return tracking;
    }
}