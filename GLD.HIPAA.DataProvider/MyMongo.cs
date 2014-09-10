using System.Linq;
using GLD.HIPAA.Doc;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace GLD.HIPAA.DataProvider
{
    public class MyMongo
    {
        private const string DbName = "EDI";
        private const string DocumentCollection = "Documents";
        private const string SegmentCollection = "Segments";

        private readonly MongoDatabase _database;

        public MyMongo(string connectionString)
        {
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            _database = server.GetDatabase(DbName);
        }

        public MyMongo() : this("monodb://localhost")
        {
        }

        // Write: ============================================================
        public void WriteDoc(Document doc)
        {
            _database.GetCollection<Document>(DocumentCollection).Insert(doc);
        }

        public void WriteSegment(Segment segment)
        {
            _database.GetCollection<Segment>(SegmentCollection).Insert(segment);
        }

        public void WriteDocAndSegments(Document doc, Segment[] segments)
        {
            _database.GetCollection<Document>(DocumentCollection).Insert(doc);

            foreach (var segment in segments)
                _database.GetCollection<Segment>(SegmentCollection).Insert(segment);
        }

        // Read: ============================================================
        public string ReadSegment(string segmentId)
        {
            var query = Query<Segment>.EQ(c => c.Id, segmentId);
            return _database.GetCollection<Segment>(SegmentCollection)
                .FindOne(query).Value;
        }

        public string[] ReadDocumentAsWhole(string docId)
        {
            var collection = _database.GetCollection<Segment>(SegmentCollection)
                .AsQueryable<Segment>()
                .Where(c => c.DocumentId == docId)
                .OrderBy(c => c.SegmentIndex);

            return collection.Select(segment => segment.Value).ToArray();
        }

        // Remove: ============================================================
        public void RemoveDoc(string docId)
        {
            var query = Query<Document>.EQ(e => e.Id, docId);
            _database.GetCollection<Document>(DocumentCollection).Remove(query);
        }

        public void RemoveSegment(string segmentId)
        {
            var query = Query<Segment>.EQ(e => e.Id, segmentId);
            _database.GetCollection<Segment>(SegmentCollection).Remove(query);
        }

        public void RemoveDocWithSegments(string docId)
        {
            var query = Query<Segment>.EQ(e => e.DocumentId, docId);
            _database.GetCollection<Segment>(SegmentCollection).Remove(query);

            query = Query<Document>.EQ(e => e.Id, docId);
            _database.GetCollection<Document>(DocumentCollection).Remove(query);
        }
    }
}