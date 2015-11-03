﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SocioBoard.Domain
{
   public interface ITwitterStatsRepository
    {
        void addTwitterStats(TwitterStats twitterstats);
        int deleteTwitterStats(Guid userid,string statsid);
        int updateTwitterStats(TwitterStats twitterstats);
        ArrayList getAllTwitterStatsOfUser(Guid UserId,int days);
        bool checkTwitterStatsExists(string TwitterStataID, Guid Userid);
        ArrayList getTwitterStatsById(Guid userId, string TwitterStataID, int days);
    }
}
