using System.Collections.Generic;

namespace Outside.BasicDotNet
{
    public class ExceptionAcceptableGenericCatch
    {
        private readonly List<ICollectionPointProvider> _collectionPointProviders;

        public ExceptionAcceptableGenericCatch()
        {
            _collectionPointProviders = new List<ICollectionPointProvider>() {new HermesCollectionPointProvider(), new UpsCollectionPointProvider()};
        }

        public List<CollectionPoint> Execute()
        {
            var collectionPoints = new List<CollectionPoint>();
            foreach (var collectionPointProvider in _collectionPointProviders)
            {
                var collectionPointsFromProvider = collectionPointProvider.Get(1, 1);
                collectionPoints.AddRange(collectionPointsFromProvider);
            }
            return collectionPoints;
        }
    }

    public interface ICollectionPointProvider
    {
        IEnumerable<CollectionPoint> Get(decimal latitude, decimal logitude);
    }

    public class HermesCollectionPointProvider : ICollectionPointProvider
    {
        public IEnumerable<CollectionPoint> Get(decimal latitude, decimal logitude)
        {
            throw new System.NotImplementedException();
        }
    }

    public class UpsCollectionPointProvider : ICollectionPointProvider
    {
        public IEnumerable<CollectionPoint> Get(decimal latitude, decimal logitude)
        {
            throw new System.NotImplementedException();
        }
    }

    public class CollectionPoint
    {
    }
}
