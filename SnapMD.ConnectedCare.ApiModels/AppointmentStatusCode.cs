using System;

namespace SnapMD.ConnectedCare.ApiModels
{
    [Flags]
    public enum AppointmentStatusCode
    {
        //0 = none
        //1 = pending
        //2 = scheduled
        //4 = active
        //8 = canceled
        //16 = completed

        None = 0,
        Pending = 1,
        Scheduled = 1 << 1,
        Active = 1 << 2,
        Canceled = 1 << 3,
        Completed = 1 << 4
    }
}
