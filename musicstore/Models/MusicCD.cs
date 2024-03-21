namespace musicstore.Models
{
    public class MusicCD : Product
    {
        private string artist;
        private string label;
        private short released;
        private List<string> tracks = new List<string>();

        public MusicCD(string title, double price, string artist, string label, short released) : base(title, price)
        {
            this.artist = artist;
            this.label = label;
            this.released = released;
        }

        public void addTrack(string track)
        {
            tracks.Add(track);
        }

        public string Artist { get { return artist; } set { artist = value; } }
        public string Label { get { return label; } set {  label = value; } }
        public short Released { get {  return released; } set {  released = value; } }
        public List<string> Tracks { get {  return tracks; } }

    }
}
