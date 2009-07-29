using System.Linq;
using ChinookMediaManager.Data.Impl.Repositories;
using ChinookMediaManager.Domain;
using NHibernate.Context;
using NUnit.Framework;

namespace ChinookMediaManager.Data.Test
{
    [TestFixture]
    public class AlbumDataTest : PersistenceFixtureBase
    {
        [Test]
        public void can_get_albums_from_artist()
        {
            
            using(var session = sessions.OpenSession())
            {
                CurrentSessionContext.Bind(session);

                var albumRepository = new AlbumRepository(sessions);
                var artist = session.Get<Artist>(1);
                var albums = albumRepository.GetByArtist(artist).ToList();
                albums.Count.Should().Be.EqualTo(2);
                albums[0].Title.Should().Be.EqualTo("For Those About To Rock We Salute You");
                albums[1].Title.Should().Be.EqualTo("Let There Be Rock");
    
            }
            
        }
    }
}