using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace FeatureFlag.Api
{
    public class asdflkasjdf : IConfigurationProvider
    {
        public IEnumerable<string> GetChildKeys(IEnumerable<string> earlierKeys, string parentPath)
        {
            throw new System.NotImplementedException();
        }

        public IChangeToken GetReloadToken()
        {
            throw new System.NotImplementedException();
        }

        public void Load()
        {
            throw new System.NotImplementedException();
        }

        public void Set(string key, string value)
        {
            throw new System.NotImplementedException();
        }

        public bool TryGet(string key, out string value)
        {
            throw new System.NotImplementedException();
        }
    }

    public class AppConfigConfigurationBuilder : IConfigurationBuilder
    {
        public IConfigurationBuilder Add(IConfigurationSource source)
        {
            throw new System.NotImplementedException();
        }

        public IConfigurationRoot Build()
        {
            throw new System.NotImplementedException();
        }

        public IDictionary<string, object> Properties { get; }
        public IList<IConfigurationSource> Sources { get; }
    }
}
