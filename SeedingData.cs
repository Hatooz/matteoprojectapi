namespace MatteoRbProject
{
    using MatteoRbProject.Models;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;

    public class SeedingData
    {
       

        public static List<Guid> GenerateGuids(int count)
        {
            var guids = new List<Guid>();
            for (int i = 0; i < count; i++)
            {
                guids.Add(Guid.NewGuid());
            }
            return guids;
        }
    }

}
