using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace WiiLink_Desktop_CS
{
    public enum WiiType
    {
        Wii = 0,
        WiiU = 1,
        DolphinEmu = 2
    }

    public class Options
    {
        [JsonPropertyName("wiiNo")]
        public ulong WiiNo { get; set; }
        [JsonPropertyName("wiiType")]
        public WiiType WiiType { get; set; }
        [JsonPropertyName("discordID")]
        public ulong DiscordID { get; set; }
        [JsonPropertyName("serverURL")]
        public string ServerURL { get; set; }
        [JsonPropertyName("playAudio")]
        public bool PlayAudio { get; set; }
    }

    [XmlRoot(ElementName = "Config")]
    public class Config
    {
        [XmlElement(ElementName = "ver")]
        public int ver { get; set; }
        [XmlElement(ElementName = "maint")]
        public bool maint { get; set; }
        [XmlElement(ElementName = "url1")]
        public string url1 { get; set; }
        [XmlElement(ElementName = "url2")]
        public string url2 { get; set; }
        [XmlElement(ElementName = "url3")]
        public string url3 { get; set; }
        [XmlElement(ElementName = "eulaver")]
        public int eulaver { get; set; }
        [XmlElement(ElementName = "shopurl")]
        public string shopurl { get; set; }
        [XmlElement(ElementName = "shopkey")]
        public string shopkey { get; set; }
        [XmlElement(ElementName = "shopvalid")]
        public bool shopvalid { get; set; }
        [XmlElement(ElementName = "akahost")]
        public int akahost { get; set; }
        [XmlElement(ElementName = "akaca")]
        public int akaca { get; set; }
        [XmlElement(ElementName = "smpkey")]
        public string smpkey { get; set; }
        [XmlElement(ElementName = "fmax")]
        public int fmax { get; set; }
        [XmlElement(ElementName = "bmax")]
        public int bmax { get; set; }
        [XmlElement(ElementName = "upddt")]
        public DateTime upddt { get; set; }
    }

    [XmlRoot(ElementName = "Event")]
    public class Event
    {
        [XmlElement(ElementName = "ver")]
        public int ver { get; set; }
        [XmlElement(ElementName = "date")]
        public DateTime date { get; set; }
        [XmlElement(ElementName = "frameid")]
        public int frameid { get; set; }
        [XmlElement(ElementName = "color")]
        public int color { get; set; }
        [XmlElement(ElementName = "postertime")]
        public int postertime { get; set; }
        [XmlElement(ElementName = "adinfo")]
        public adinfo adinfo { get; set; }
        [XmlElement(ElementName = "posterinfo")]
        public List<posterinfo> posterinfo { get; set; }
        [XmlElement(ElementName = "introinfo")]
        public List<introinfo> introinfo { get; set; }
        [XmlElement(ElementName = "newsinfo")]
        public List<newsinfo> newsinfo { get; set; }
        [XmlElement(ElementName = "miiinfo")]
        public List<miiinfo> miiinfo { get; set; }
    }

    [XmlRoot(ElementName = "adinfo")]
    public class adinfo
    {
        [XmlElement(ElementName = "pref")]
        public List<int> pref { get; set; }
        [XmlElement(ElementName = "adid")]
        public List<int> adid { get; set; }
    }
    [XmlRoot(ElementName = "posterinfo")]
    public class posterinfo
    {
        [XmlElement(ElementName = "seq")]
        public int seq { get; set; }
        [XmlElement(ElementName = "posterid")]
        public int posterid { get; set; }
    }
    [XmlRoot(ElementName = "introinfo")]
    public class introinfo
    {
        [XmlElement(ElementName = "seq")]
        public int seq { get; set; }
        [XmlElement(ElementName = "cntid")]
        public string cntid { get; set; }
        [XmlElement(ElementName = "cnttype")]
        public int cnttype { get; set; }
        [XmlElement(ElementName = "random")]
        public int random { get; set; }
        [XmlElement(ElementName = "linktype")]
        public int linktype { get; set; }
        [XmlElement(ElementName = "dispsec")]
        public int dispsec { get; set; }
        [XmlElement(ElementName = "dimg")]
        public int dimg { get; set; }
        [XmlElement(ElementName = "linkid")]
        public int linkid { get; set; }
        [XmlElement(ElementName = "catname")]
        public string catname { get; set; }
    }
    [XmlRoot(ElementName = "newsinfo")]
    public class newsinfo
    {
        [XmlElement(ElementName = "page")]
        public int page { get; set; }
        [XmlElement(ElementName = "news")]
        public string news { get; set; }
    }
    [XmlRoot(ElementName = "miiinfo")]
    public class miiinfo
    {
        [XmlElement(ElementName = "seq")]
        public int seq { get; set; }
        [XmlElement(ElementName = "miiid")]
        public int miiid { get; set; }
    }

    [XmlRoot(ElementName = "PosterMeta")]
    public class PosterMeta
    {
        [XmlElement(ElementName = "ver")]
        public ushort ver { get; set; }
        [XmlElement(ElementName = "posterid")]
        public int posterid { get; set; }
        [XmlElement(ElementName = "msg")]
        public string msg { get; set; }
        [XmlElement(ElementName = "movieid")]
        public int movieid { get; set; }
        [XmlElement(ElementName = "title")]
        public string title { get; set; }
    }
}
