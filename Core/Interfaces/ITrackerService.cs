using Core.Entities;

namespace Core.Interfaces;

public interface ITrackerService
{
    public Task<Tracking> AddTracker();
}