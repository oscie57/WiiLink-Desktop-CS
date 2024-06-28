using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
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


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, TypeName = "Config")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class FirstConfig
    {

        private ushort verField;

        private bool maintField;

        private string url1Field;

        private string url2Field;

        private string url3Field;

        private byte eulaverField;

        private string shopurlField;

        private string shopkeyField;

        private bool shopvalidField;

        private byte akahostField;

        private byte akacaField;

        private string smpkeyField;

        private byte fmaxField;

        private byte bmaxField;

        private System.DateTime upddtField;

        /// <remarks/>
        public ushort ver
        {
            get
            {
                return this.verField;
            }
            set
            {
                this.verField = value;
            }
        }

        /// <remarks/>
        public bool maint
        {
            get
            {
                return this.maintField;
            }
            set
            {
                this.maintField = value;
            }
        }

        /// <remarks/>
        public string url1
        {
            get
            {
                return this.url1Field;
            }
            set
            {
                this.url1Field = value;
            }
        }

        /// <remarks/>
        public string url2
        {
            get
            {
                return this.url2Field;
            }
            set
            {
                this.url2Field = value;
            }
        }

        /// <remarks/>
        public string url3
        {
            get
            {
                return this.url3Field;
            }
            set
            {
                this.url3Field = value;
            }
        }

        /// <remarks/>
        public byte eulaver
        {
            get
            {
                return this.eulaverField;
            }
            set
            {
                this.eulaverField = value;
            }
        }

        /// <remarks/>
        public string shopurl
        {
            get
            {
                return this.shopurlField;
            }
            set
            {
                this.shopurlField = value;
            }
        }

        /// <remarks/>
        public string shopkey
        {
            get
            {
                return this.shopkeyField;
            }
            set
            {
                this.shopkeyField = value;
            }
        }

        /// <remarks/>
        public bool shopvalid
        {
            get
            {
                return this.shopvalidField;
            }
            set
            {
                this.shopvalidField = value;
            }
        }

        /// <remarks/>
        public byte akahost
        {
            get
            {
                return this.akahostField;
            }
            set
            {
                this.akahostField = value;
            }
        }

        /// <remarks/>
        public byte akaca
        {
            get
            {
                return this.akacaField;
            }
            set
            {
                this.akacaField = value;
            }
        }

        /// <remarks/>
        public string smpkey
        {
            get
            {
                return this.smpkeyField;
            }
            set
            {
                this.smpkeyField = value;
            }
        }

        /// <remarks/>
        public byte fmax
        {
            get
            {
                return this.fmaxField;
            }
            set
            {
                this.fmaxField = value;
            }
        }

        /// <remarks/>
        public byte bmax
        {
            get
            {
                return this.bmaxField;
            }
            set
            {
                this.bmaxField = value;
            }
        }

        /// <remarks/>
        public System.DateTime upddt
        {
            get
            {
                return this.upddtField;
            }
            set
            {
                this.upddtField = value;
            }
        }
    }


}
