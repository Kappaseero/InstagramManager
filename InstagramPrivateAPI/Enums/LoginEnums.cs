﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramPrivateAPI.Enums
{
    public enum LoginEnum
    {
        Success,
        AlreadyLoggedIn,
        EmailChallenged,
        MessageChallenged,
        SubmitPhone,
        Unsuccessful
    }
}