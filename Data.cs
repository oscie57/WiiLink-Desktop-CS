using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WiiLink_Desktop_CS
{
    public enum WiiType
    {
        Wii = 0,
        WiiU = 1,
        DolphinEmu = 2
    }

    public class RootConfig
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

    public class FirstConfig
    {
        [JsonPropertyName("maint")]
        public bool Maintenance { get; set; }
        [JsonPropertyName("url1")]
        public string URL1 { get; set; }
        [JsonPropertyName("url2")]
        public string URL2 { get; set; }
        [JsonPropertyName("url3")]
        public string URL3 { get; set; }
        [JsonPropertyName("eulaver")]
        public int eulaVer { get; set; }
        [JsonPropertyName("shopurl")]
        public string ShopURL { get; set; }
        [JsonPropertyName("shopkey")]
        public string ShopKey { get; set; }
        [JsonPropertyName("shopvalid")]
        public bool ShopValid { get; set; }
        [JsonPropertyName("akahost")]
        public int akaHost { get; set; }
        [JsonPropertyName("akaca")]
        public int akaCA { get; set; }
        [JsonPropertyName("smpkey")]
        public string SMPKey { get; set; }
        [JsonPropertyName("fmax")]
        public int FMax { get; set; }
        [JsonPropertyName("bmax")]
        public int BMax { get; set; }
        [JsonPropertyName("upddt")]
        public string UpdDT { get; set; }
    }
}
