﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MT.Models.ViewModels
{
    public class WxOpenIdViewModel
    {
        public string access_token { get; set; }

        public string expires_in { get; set; }

        public string refresh_token { get; set; }

        public string openid { get; set; }

        public string scope { get; set; }

        public string unionid { get; set; }

        public string to_groupid { get; set; }
    }
}