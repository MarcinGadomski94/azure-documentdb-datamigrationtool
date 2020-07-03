using Microsoft.DataTransfer.Basics.Extensions;
using Microsoft.DataTransfer.MongoDb.Shared;
using Microsoft.DataTransfer.WpfHost.Basics;

namespace Microsoft.DataTransfer.MongoDb.Wpf.Shared
{
    abstract class MongoDbAdapterConfiguration : ValidatableBindableBase, IMongoDbAdapterConfiguration
    {
        public static readonly string ConnectionStringPropertyName =
            ObjectExtensions.MemberName<IMongoDbAdapterConfiguration>(c => c.ConnectionString);

        public static readonly string CollectionPropertyName =
            ObjectExtensions.MemberName<IMongoDbAdapterConfiguration>(c => c.Collection);

        public static readonly string BatchSizePropertyName =
            ObjectExtensions.MemberName<IMongoDbAdapterConfiguration>(c => c.BatchSize);

        private string connectionString;
        private string collection;
        private string batchSize;

        public string ConnectionString
        {
            get { return connectionString; }
            set { SetProperty(ref connectionString, value, ValidateNonEmptyString); }
        }

        public string Collection
        {
            get { return collection; }
            set { SetProperty(ref collection, value, ValidateNonEmptyString); }
        }

        public string BatchSize
        {
            get { return batchSize; }
            set { SetProperty(ref batchSize, value, ValidateNonEmptyString); }
        }
    }
}
