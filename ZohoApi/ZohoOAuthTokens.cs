﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZohoApi
{
    public class ZohoOAuthTokens
    {

        private string userMailId;
        private string accessToken;
        private string refreshToken;
        private long expiryTime;

        public string UserMaiilId
        {
            get
            {
                return userMailId;
            }
            set
            {
                userMailId = value;
            }
        }

        public string RefreshToken
        {
            get
            {
                return refreshToken;
            }
            set
            {
                refreshToken = value;
            }
        }

        public long ExpiryTime
        {
            get
            {
                return expiryTime;
            }
            set
            {
                expiryTime = value;
            }
        }

        public string AccessToken
        {
            get
            {
                if (IsAccessTokenValid())
                {
                    return accessToken;
                }
                throw new Exception("Access token expired");
                //MessageBox.Show("Access token expired", "Token", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw new ZohoOAuthException("Access token expired");
            }
            set
            {
                accessToken = value;
            }
        }

        private bool IsAccessTokenValid()
        {
            if (GetExpiryLapseInMillis() > 10L)
            {
                return true;
            }
            return false;
        }

        public long GetExpiryLapseInMillis()
        {
            long time = (ExpiryTime - (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds);
            return (time);
        }
    }
}
