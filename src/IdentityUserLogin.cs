using System;

namespace AspNet.Identity.PostgreSQL
{
    [Serializable]
    public class IdentityUserLogin
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
    }
}
