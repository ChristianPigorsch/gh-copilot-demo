using System.Collections.Generic;
using System.Linq;

namespace albums_api.Models
{
    public record MusicStyle(int Id, string Name, string Description, string Image_url)
    {
        public static List<MusicStyle> GetAll()
        {
            var styles = new List<MusicStyle>(){
                new MusicStyle(1, "Rock", "Guitar-driven, energetic music", "https://aka.ms/albums-rocklogo"),
                new MusicStyle(2, "Jazz", "Improvisational and harmonically rich", "https://aka.ms/albums-jazzlogo"),
                new MusicStyle(3, "Pop", "Catchy melodies and mainstream appeal", "https://aka.ms/albums-poplogo"),
                new MusicStyle(4, "Classical", "Orchestral and composed works", "https://aka.ms/albums-classicallogo"),
                new MusicStyle(5, "Electronic", "Synthesizers and electronic production", "https://aka.ms/albums-electroniclogo"),
                new MusicStyle(6, "Country", "Storytelling with acoustic instrumentation", "https://aka.ms/albums-countrylogo")
            };

            return styles;
        }

        public static MusicStyle? GetById(int id)
        {
            var styles = GetAll();
            return styles.FirstOrDefault(s => s.Id == id);
        }
    }
}
