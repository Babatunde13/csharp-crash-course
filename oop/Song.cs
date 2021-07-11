namespace oop
{
    /// <summary>
    /// A Song Class
    /// @params title: Title of the song
    /// @params artist: artist of the song
    /// @params duration: duration of the song.
    /// <code>Song song1 = new Song("Title", "artist artist", 1000)</code>
    /// </summary>
    public class Song {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;

        public Song(string title_, string artist_, int duration_) {
            title = title_;
            artist = artist_;
            duration = duration_;
        }
    }
}