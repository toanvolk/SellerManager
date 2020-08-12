using IdentityServer4.Models;
using System.Collections.Generic;

public static class InMemoryConfig
{
    public static IEnumerable<IdentityResource> GetIdentityResources() =>
      new List<IdentityResource>
      {
          new IdentityResources.OpenId(),
          new IdentityResources.Profile()
      };
}