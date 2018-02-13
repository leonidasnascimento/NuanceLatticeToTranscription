using Newtonsoft.Json;
using System;

namespace CCA.Transcription.Lattice.Model.Auxiliar
{
    public partial class LatticeAuxiliar
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("operating_mode")]
        public string OperatingMode { get; set; }

        [JsonProperty("statistics")]
        public WelcomeStatistics Statistics { get; set; }

        [JsonProperty("channels")]
        public Channels Channels { get; set; }
    }

    public partial class Channels
    {
        [JsonProperty("firstChannelLabel")]
        public FirstChannelLabel FirstChannelLabel { get; set; }
    }

    public partial class FirstChannelLabel
    {
        [JsonProperty("errors")]
        public object[] Errors { get; set; }

        [JsonProperty("statistics")]
        public FirstChannelLabelStatistics Statistics { get; set; }

        [JsonProperty("transcript")]
        public Transcript[] Transcript { get; set; }

        [JsonProperty("lattice")]
        public Lattice Lattice { get; set; }
    }

    public partial class Lattice
    {
        [JsonProperty("1")]
        public Lattice1 The1 { get; set; }
    }

    public partial class Lattice1
    {
        [JsonProperty("links")]
        public Links Links { get; set; }
    }

    public partial class Links
    {
        [JsonProperty("0")]
        public The0 The0 { get; set; }

        [JsonProperty("1")]
        public The0 The1 { get; set; }

        [JsonProperty("2")]
        public The0 The2 { get; set; }

        [JsonProperty("3")]
        public The0 The3 { get; set; }

        [JsonProperty("4")]
        public The0 The4 { get; set; }

        [JsonProperty("5")]
        public The0 The5 { get; set; }

        [JsonProperty("6")]
        public The0 The6 { get; set; }

        [JsonProperty("7")]
        public The0 The7 { get; set; }

        [JsonProperty("8")]
        public The0 The8 { get; set; }

        [JsonProperty("9")]
        public The0 The9 { get; set; }

        [JsonProperty("10")]
        public The0 The10 { get; set; }

        [JsonProperty("11")]
        public The0 The11 { get; set; }

        [JsonProperty("12")]
        public The0 The12 { get; set; }

        [JsonProperty("13")]
        public The0 The13 { get; set; }

        [JsonProperty("14")]
        public The0 The14 { get; set; }

        [JsonProperty("15")]
        public The0 The15 { get; set; }

        [JsonProperty("16")]
        public The0 The16 { get; set; }

        [JsonProperty("17")]
        public The0 The17 { get; set; }

        [JsonProperty("18")]
        public The0 The18 { get; set; }

        [JsonProperty("19")]
        public The0 The19 { get; set; }

        [JsonProperty("20")]
        public The0 The20 { get; set; }

        [JsonProperty("21")]
        public The0 The21 { get; set; }

        [JsonProperty("22")]
        public The0 The22 { get; set; }

        [JsonProperty("23")]
        public The0 The23 { get; set; }

        [JsonProperty("24")]
        public The0 The24 { get; set; }

        [JsonProperty("25")]
        public The0 The25 { get; set; }

        [JsonProperty("26")]
        public The0 The26 { get; set; }

        [JsonProperty("27")]
        public The0 The27 { get; set; }

        [JsonProperty("28")]
        public The0 The28 { get; set; }

        [JsonProperty("29")]
        public The0 The29 { get; set; }

        [JsonProperty("30")]
        public The0 The30 { get; set; }

        [JsonProperty("31")]
        public The0 The31 { get; set; }

        [JsonProperty("32")]
        public The0 The32 { get; set; }

        [JsonProperty("33")]
        public The0 The33 { get; set; }

        [JsonProperty("34")]
        public The0 The34 { get; set; }

        [JsonProperty("35")]
        public The0 The35 { get; set; }

        [JsonProperty("36")]
        public The0 The36 { get; set; }

        [JsonProperty("37")]
        public The0 The37 { get; set; }

        [JsonProperty("38")]
        public The0 The38 { get; set; }

        [JsonProperty("39")]
        public The0 The39 { get; set; }

        [JsonProperty("40")]
        public The0 The40 { get; set; }

        [JsonProperty("41")]
        public The0 The41 { get; set; }

        [JsonProperty("42")]
        public The0 The42 { get; set; }

        [JsonProperty("43")]
        public The0 The43 { get; set; }

        [JsonProperty("44")]
        public The0 The44 { get; set; }

        [JsonProperty("45")]
        public The0 The45 { get; set; }

        [JsonProperty("46")]
        public The0 The46 { get; set; }

        [JsonProperty("47")]
        public The0 The47 { get; set; }

        [JsonProperty("48")]
        public The0 The48 { get; set; }

        [JsonProperty("49")]
        public The0 The49 { get; set; }

        [JsonProperty("50")]
        public The0 The50 { get; set; }

        [JsonProperty("51")]
        public The0 The51 { get; set; }

        [JsonProperty("52")]
        public The0 The52 { get; set; }

        [JsonProperty("53")]
        public The0 The53 { get; set; }

        [JsonProperty("54")]
        public The0 The54 { get; set; }

        [JsonProperty("55")]
        public The0 The55 { get; set; }

        [JsonProperty("56")]
        public The0 The56 { get; set; }

        [JsonProperty("57")]
        public The0 The57 { get; set; }

        [JsonProperty("58")]
        public The0 The58 { get; set; }

        [JsonProperty("59")]
        public The0 The59 { get; set; }

        [JsonProperty("60")]
        public The0 The60 { get; set; }

        [JsonProperty("61")]
        public The0 The61 { get; set; }

        [JsonProperty("62")]
        public The0 The62 { get; set; }

        [JsonProperty("63")]
        public The0 The63 { get; set; }

        [JsonProperty("64")]
        public The0 The64 { get; set; }

        [JsonProperty("65")]
        public The0 The65 { get; set; }

        [JsonProperty("66")]
        public The0 The66 { get; set; }

        [JsonProperty("67")]
        public The0 The67 { get; set; }

        [JsonProperty("68")]
        public The0 The68 { get; set; }

        [JsonProperty("69")]
        public The0 The69 { get; set; }

        [JsonProperty("70")]
        public The0 The70 { get; set; }

        [JsonProperty("71")]
        public The0 The71 { get; set; }

        [JsonProperty("72")]
        public The0 The72 { get; set; }

        [JsonProperty("73")]
        public The0 The73 { get; set; }

        [JsonProperty("74")]
        public The0 The74 { get; set; }

        [JsonProperty("75")]
        public The0 The75 { get; set; }

        [JsonProperty("76")]
        public The0 The76 { get; set; }

        [JsonProperty("77")]
        public The0 The77 { get; set; }

        [JsonProperty("78")]
        public The0 The78 { get; set; }

        [JsonProperty("79")]
        public The0 The79 { get; set; }

        [JsonProperty("80")]
        public The0 The80 { get; set; }

        [JsonProperty("81")]
        public The0 The81 { get; set; }

        [JsonProperty("82")]
        public The0 The82 { get; set; }

        [JsonProperty("83")]
        public The0 The83 { get; set; }

        [JsonProperty("84")]
        public The0 The84 { get; set; }

        [JsonProperty("85")]
        public The0 The85 { get; set; }

        [JsonProperty("86")]
        public The0 The86 { get; set; }

        [JsonProperty("87")]
        public The0 The87 { get; set; }

        [JsonProperty("88")]
        public The0 The88 { get; set; }

        [JsonProperty("89")]
        public The0 The89 { get; set; }

        [JsonProperty("90")]
        public The0 The90 { get; set; }

        [JsonProperty("91")]
        public The0 The91 { get; set; }

        [JsonProperty("92")]
        public The0 The92 { get; set; }

        [JsonProperty("93")]
        public The0 The93 { get; set; }

        [JsonProperty("94")]
        public The0 The94 { get; set; }

        [JsonProperty("95")]
        public The0 The95 { get; set; }

        [JsonProperty("96")]
        public The0 The96 { get; set; }

        [JsonProperty("97")]
        public The0 The97 { get; set; }

        [JsonProperty("98")]
        public The0 The98 { get; set; }

        [JsonProperty("99")]
        public The0 The99 { get; set; }

        [JsonProperty("100")]
        public The0 The100 { get; set; }

        [JsonProperty("101")]
        public The0 The101 { get; set; }

        [JsonProperty("102")]
        public The0 The102 { get; set; }

        [JsonProperty("103")]
        public The0 The103 { get; set; }

        [JsonProperty("104")]
        public The0 The104 { get; set; }

        [JsonProperty("105")]
        public The0 The105 { get; set; }

        [JsonProperty("106")]
        public The0 The106 { get; set; }

        [JsonProperty("107")]
        public The0 The107 { get; set; }

        [JsonProperty("108")]
        public The0 The108 { get; set; }

        [JsonProperty("109")]
        public The0 The109 { get; set; }

        [JsonProperty("110")]
        public The0 The110 { get; set; }

        [JsonProperty("111")]
        public The0 The111 { get; set; }

        [JsonProperty("112")]
        public The0 The112 { get; set; }

        [JsonProperty("113")]
        public The0 The113 { get; set; }

        [JsonProperty("114")]
        public The0 The114 { get; set; }

        [JsonProperty("115")]
        public The0 The115 { get; set; }

        [JsonProperty("116")]
        public The0 The116 { get; set; }

        [JsonProperty("117")]
        public The0 The117 { get; set; }

        [JsonProperty("118")]
        public The0 The118 { get; set; }

        [JsonProperty("119")]
        public The0 The119 { get; set; }

        [JsonProperty("120")]
        public The0 The120 { get; set; }

        [JsonProperty("121")]
        public The0 The121 { get; set; }

        [JsonProperty("122")]
        public The0 The122 { get; set; }

        [JsonProperty("123")]
        public The0 The123 { get; set; }

        [JsonProperty("124")]
        public The0 The124 { get; set; }

        [JsonProperty("125")]
        public The0 The125 { get; set; }

        [JsonProperty("126")]
        public The0 The126 { get; set; }

        [JsonProperty("127")]
        public The0 The127 { get; set; }

        [JsonProperty("128")]
        public The0 The128 { get; set; }

        [JsonProperty("129")]
        public The0 The129 { get; set; }

        [JsonProperty("130")]
        public The0 The130 { get; set; }

        [JsonProperty("131")]
        public The0 The131 { get; set; }

        [JsonProperty("132")]
        public The0 The132 { get; set; }

        [JsonProperty("133")]
        public The0 The133 { get; set; }

        [JsonProperty("134")]
        public The0 The134 { get; set; }
        
        [JsonProperty("135")]
        public The0 The135 { get; set; }

        [JsonProperty("136")]
        public The0 The136 { get; set; }

        [JsonProperty("137")]
        public The0 The137 { get; set; }

        [JsonProperty("138")]
        public The0 The138 { get; set; }

        [JsonProperty("139")]
        public The0 The139 { get; set; }

        [JsonProperty("140")]
        public The0 The140 { get; set; }

        [JsonProperty("141")]
        public The0 The141 { get; set; }

        [JsonProperty("142")]
        public The0 The142 { get; set; }

        [JsonProperty("143")]
        public The0 The143 { get; set; }

        [JsonProperty("144")]
        public The0 The144 { get; set; }

        [JsonProperty("145")]
        public The0 The145 { get; set; }

        [JsonProperty("146")]
        public The0 The146 { get; set; }

        [JsonProperty("147")]
        public The0 The147 { get; set; }

        [JsonProperty("148")]
        public The0 The148 { get; set; }

        [JsonProperty("149")]
        public The0 The149 { get; set; }

        [JsonProperty("150")]
        public The0 The150 { get; set; }

        [JsonProperty("151")]
        public The0 The151 { get; set; }

        [JsonProperty("152")]
        public The0 The152 { get; set; }

        [JsonProperty("153")]
        public The0 The153 { get; set; }

        [JsonProperty("154")]
        public The0 The154 { get; set; }

        [JsonProperty("155")]
        public The0 The155 { get; set; }

        [JsonProperty("156")]
        public The0 The156 { get; set; }

        [JsonProperty("157")]
        public The0 The157 { get; set; }

        [JsonProperty("158")]
        public The0 The158 { get; set; }

        [JsonProperty("159")]
        public The0 The159 { get; set; }

        [JsonProperty("160")]
        public The0 The160 { get; set; }

        [JsonProperty("161")]
        public The0 The161 { get; set; }

        [JsonProperty("162")]
        public The0 The162 { get; set; }

        [JsonProperty("163")]
        public The0 The163 { get; set; }

        [JsonProperty("164")]
        public The0 The164 { get; set; }

        [JsonProperty("165")]
        public The0 The165 { get; set; }

        [JsonProperty("166")]
        public The0 The166 { get; set; }

        [JsonProperty("167")]
        public The0 The167 { get; set; }

        [JsonProperty("168")]
        public The0 The168 { get; set; }

        [JsonProperty("169")]
        public The0 The169 { get; set; }

        [JsonProperty("170")]
        public The0 The170 { get; set; }

        [JsonProperty("171")]
        public The0 The171 { get; set; }

        [JsonProperty("172")]
        public The0 The172 { get; set; }

        [JsonProperty("173")]
        public The0 The173 { get; set; }

        [JsonProperty("174")]
        public The0 The174 { get; set; }

        [JsonProperty("175")]
        public The0 The175 { get; set; }

        [JsonProperty("176")]
        public The0 The176 { get; set; }

        [JsonProperty("177")]
        public The0 The177 { get; set; }

        [JsonProperty("178")]
        public The0 The178 { get; set; }

        [JsonProperty("179")]
        public The0 The179 { get; set; }

        [JsonProperty("180")]
        public The0 The180 { get; set; }

        [JsonProperty("181")]
        public The0 The181 { get; set; }

        [JsonProperty("182")]
        public The0 The182 { get; set; }

        [JsonProperty("183")]
        public The0 The183 { get; set; }

        [JsonProperty("184")]
        public The0 The184 { get; set; }

        [JsonProperty("185")]
        public The0 The185 { get; set; }

        [JsonProperty("186")]
        public The0 The186 { get; set; }

        [JsonProperty("187")]
        public The0 The187 { get; set; }

        [JsonProperty("188")]
        public The0 The188 { get; set; }

        [JsonProperty("189")]
        public The0 The189 { get; set; }

        [JsonProperty("190")]
        public The0 The190 { get; set; }

        [JsonProperty("191")]
        public The0 The191 { get; set; }

        [JsonProperty("192")]
        public The0 The192 { get; set; }

        [JsonProperty("193")]
        public The0 The193 { get; set; }

        [JsonProperty("194")]
        public The0 The194 { get; set; }

        [JsonProperty("195")]
        public The0 The195 { get; set; }

        [JsonProperty("196")]
        public The0 The196 { get; set; }

        [JsonProperty("197")]
        public The0 The197 { get; set; }

        [JsonProperty("198")]
        public The0 The198 { get; set; }

        [JsonProperty("199")]
        public The0 The199 { get; set; }

        [JsonProperty("200")]
        public The0 The200 { get; set; }

        [JsonProperty("201")]
        public The0 The201 { get; set; }

        [JsonProperty("202")]
        public The0 The202 { get; set; }

        [JsonProperty("203")]
        public The0 The203 { get; set; }

        [JsonProperty("204")]
        public The0 The204 { get; set; }

        [JsonProperty("205")]
        public The0 The205 { get; set; }

        [JsonProperty("206")]
        public The0 The206 { get; set; }

        [JsonProperty("207")]
        public The0 The207 { get; set; }

        [JsonProperty("208")]
        public The0 The208 { get; set; }

        [JsonProperty("209")]
        public The0 The209 { get; set; }

        [JsonProperty("210")]
        public The0 The210 { get; set; }

        [JsonProperty("211")]
        public The0 The211 { get; set; }

        [JsonProperty("212")]
        public The0 The212 { get; set; }

        [JsonProperty("213")]
        public The0 The213 { get; set; }

        [JsonProperty("214")]
        public The0 The214 { get; set; }

        [JsonProperty("215")]
        public The0 The215 { get; set; }

        [JsonProperty("216")]
        public The0 The216 { get; set; }

        [JsonProperty("217")]
        public The0 The217 { get; set; }

        [JsonProperty("218")]
        public The0 The218 { get; set; }

        [JsonProperty("219")]
        public The0 The219 { get; set; }

        [JsonProperty("220")]
        public The0 The220 { get; set; }

        [JsonProperty("221")]
        public The0 The221 { get; set; }

        [JsonProperty("222")]
        public The0 The222 { get; set; }

        [JsonProperty("223")]
        public The0 The223 { get; set; }

        [JsonProperty("224")]
        public The0 The224 { get; set; }

        [JsonProperty("225")]
        public The0 The225 { get; set; }

        [JsonProperty("226")]
        public The0 The226 { get; set; }

        [JsonProperty("227")]
        public The0 The227 { get; set; }

        [JsonProperty("228")]
        public The0 The228 { get; set; }

        [JsonProperty("229")]
        public The0 The229 { get; set; }

        [JsonProperty("230")]
        public The0 The230 { get; set; }

        [JsonProperty("231")]
        public The0 The231 { get; set; }

        [JsonProperty("232")]
        public The0 The232 { get; set; }

        [JsonProperty("233")]
        public The0 The233 { get; set; }

        [JsonProperty("234")]
        public The0 The234 { get; set; }

        [JsonProperty("235")]
        public The0 The235 { get; set; }

        [JsonProperty("236")]
        public The0 The236 { get; set; }

        [JsonProperty("237")]
        public The0 The237 { get; set; }

        [JsonProperty("238")]
        public The0 The238 { get; set; }

        [JsonProperty("239")]
        public The0 The239 { get; set; }

        [JsonProperty("240")]
        public The0 The240 { get; set; }

        [JsonProperty("241")]
        public The0 The241 { get; set; }

        [JsonProperty("242")]
        public The0 The242 { get; set; }

        [JsonProperty("243")]
        public The0 The243 { get; set; }

        [JsonProperty("244")]
        public The0 The244 { get; set; }

        [JsonProperty("245")]
        public The0 The245 { get; set; }

        [JsonProperty("246")]
        public The0 The246 { get; set; }

        [JsonProperty("247")]
        public The0 The247 { get; set; }

        [JsonProperty("248")]
        public The0 The248 { get; set; }

        [JsonProperty("249")]
        public The0 The249 { get; set; }

        [JsonProperty("250")]
        public The0 The250 { get; set; }

        [JsonProperty("251")]
        public The0 The251 { get; set; }

        [JsonProperty("252")]
        public The0 The252 { get; set; }

        [JsonProperty("253")]
        public The0 The253 { get; set; }

        [JsonProperty("254")]
        public The0 The254 { get; set; }

        [JsonProperty("255")]
        public The0 The255 { get; set; }

        [JsonProperty("256")]
        public The0 The256 { get; set; }

        [JsonProperty("257")]
        public The0 The257 { get; set; }

        [JsonProperty("258")]
        public The0 The258 { get; set; }

        [JsonProperty("259")]
        public The0 The259 { get; set; }

        [JsonProperty("260")]
        public The0 The260 { get; set; }

        [JsonProperty("261")]
        public The0 The261 { get; set; }

        [JsonProperty("262")]
        public The0 The262 { get; set; }

        [JsonProperty("263")]
        public The0 The263 { get; set; }

        [JsonProperty("264")]
        public The0 The264 { get; set; }

        [JsonProperty("265")]
        public The0 The265 { get; set; }

        [JsonProperty("266")]
        public The0 The266 { get; set; }

        [JsonProperty("267")]
        public The0 The267 { get; set; }

        [JsonProperty("268")]
        public The0 The268 { get; set; }

        [JsonProperty("269")]
        public The0 The269 { get; set; }

        [JsonProperty("270")]
        public The0 The270 { get; set; }

        [JsonProperty("271")]
        public The0 The271 { get; set; }

        [JsonProperty("272")]
        public The0 The272 { get; set; }

        [JsonProperty("273")]
        public The0 The273 { get; set; }

        [JsonProperty("274")]
        public The0 The274 { get; set; }

        [JsonProperty("275")]
        public The0 The275 { get; set; }

        [JsonProperty("276")]
        public The0 The276 { get; set; }

        [JsonProperty("277")]
        public The0 The277 { get; set; }

        [JsonProperty("278")]
        public The0 The278 { get; set; }

        [JsonProperty("279")]
        public The0 The279 { get; set; }

        [JsonProperty("280")]
        public The0 The280 { get; set; }

        [JsonProperty("281")]
        public The0 The281 { get; set; }

        [JsonProperty("282")]
        public The0 The282 { get; set; }

        [JsonProperty("283")]
        public The0 The283 { get; set; }

        [JsonProperty("284")]
        public The0 The284 { get; set; }

        [JsonProperty("285")]
        public The0 The285 { get; set; }

        [JsonProperty("286")]
        public The0 The286 { get; set; }

        [JsonProperty("287")]
        public The0 The287 { get; set; }

        [JsonProperty("288")]
        public The0 The288 { get; set; }

        [JsonProperty("289")]
        public The0 The289 { get; set; }

        [JsonProperty("290")]
        public The0 The290 { get; set; }

        [JsonProperty("291")]
        public The0 The291 { get; set; }

        [JsonProperty("292")]
        public The0 The292 { get; set; }

        [JsonProperty("293")]
        public The0 The293 { get; set; }

        [JsonProperty("294")]
        public The0 The294 { get; set; }

        [JsonProperty("295")]
        public The0 The295 { get; set; }

        [JsonProperty("296")]
        public The0 The296 { get; set; }

        [JsonProperty("297")]
        public The0 The297 { get; set; }

        [JsonProperty("298")]
        public The0 The298 { get; set; }

        [JsonProperty("299")]
        public The0 The299 { get; set; }

        [JsonProperty("300")]
        public The0 The300 { get; set; }

        [JsonProperty("301")]
        public The0 The301 { get; set; }

        [JsonProperty("302")]
        public The0 The302 { get; set; }

        [JsonProperty("303")]
        public The0 The303 { get; set; }

        [JsonProperty("304")]
        public The0 The304 { get; set; }

        [JsonProperty("305")]
        public The0 The305 { get; set; }

        [JsonProperty("306")]
        public The0 The306 { get; set; }

        [JsonProperty("307")]
        public The0 The307 { get; set; }

        [JsonProperty("308")]
        public The0 The308 { get; set; }

        [JsonProperty("309")]
        public The0 The309 { get; set; }

        [JsonProperty("310")]
        public The0 The310 { get; set; }

        [JsonProperty("311")]
        public The0 The311 { get; set; }

        [JsonProperty("312")]
        public The0 The312 { get; set; }

        [JsonProperty("313")]
        public The0 The313 { get; set; }

        [JsonProperty("314")]
        public The0 The314 { get; set; }

        [JsonProperty("315")]
        public The0 The315 { get; set; }

        [JsonProperty("316")]
        public The0 The316 { get; set; }

        [JsonProperty("317")]
        public The0 The317 { get; set; }

        [JsonProperty("318")]
        public The0 The318 { get; set; }

        [JsonProperty("319")]
        public The0 The319 { get; set; }

        [JsonProperty("320")]
        public The0 The320 { get; set; }

        [JsonProperty("321")]
        public The0 The321 { get; set; }

        [JsonProperty("322")]
        public The0 The322 { get; set; }

        [JsonProperty("323")]
        public The0 The323 { get; set; }

        [JsonProperty("324")]
        public The0 The324 { get; set; }

        [JsonProperty("325")]
        public The0 The325 { get; set; }

        [JsonProperty("326")]
        public The0 The326 { get; set; }

        [JsonProperty("327")]
        public The0 The327 { get; set; }

        [JsonProperty("328")]
        public The0 The328 { get; set; }

        [JsonProperty("329")]
        public The0 The329 { get; set; }

        [JsonProperty("330")]
        public The0 The330 { get; set; }

        [JsonProperty("331")]
        public The0 The331 { get; set; }

        [JsonProperty("332")]
        public The0 The332 { get; set; }

        [JsonProperty("333")]
        public The0 The333 { get; set; }

        [JsonProperty("334")]
        public The0 The334 { get; set; }

        [JsonProperty("335")]
        public The0 The335 { get; set; }

        [JsonProperty("336")]
        public The0 The336 { get; set; }

        [JsonProperty("337")]
        public The0 The337 { get; set; }

        [JsonProperty("338")]
        public The0 The338 { get; set; }

        [JsonProperty("339")]
        public The0 The339 { get; set; }

        [JsonProperty("340")]
        public The0 The340 { get; set; }

        [JsonProperty("341")]
        public The0 The341 { get; set; }

        [JsonProperty("342")]
        public The0 The342 { get; set; }

        [JsonProperty("343")]
        public The0 The343 { get; set; }

        [JsonProperty("344")]
        public The0 The344 { get; set; }

        [JsonProperty("345")]
        public The0 The345 { get; set; }

        [JsonProperty("346")]
        public The0 The346 { get; set; }

        [JsonProperty("347")]
        public The0 The347 { get; set; }

        [JsonProperty("348")]
        public The0 The348 { get; set; }

        [JsonProperty("349")]
        public The0 The349 { get; set; }

        [JsonProperty("350")]
        public The0 The350 { get; set; }

        [JsonProperty("351")]
        public The0 The351 { get; set; }

        [JsonProperty("352")]
        public The0 The352 { get; set; }

        [JsonProperty("353")]
        public The0 The353 { get; set; }

        [JsonProperty("354")]
        public The0 The354 { get; set; }

        [JsonProperty("355")]
        public The0 The355 { get; set; }

        [JsonProperty("356")]
        public The0 The356 { get; set; }

        [JsonProperty("357")]
        public The0 The357 { get; set; }

        [JsonProperty("358")]
        public The0 The358 { get; set; }

        [JsonProperty("359")]
        public The0 The359 { get; set; }

        [JsonProperty("360")]
        public The0 The360 { get; set; }

        [JsonProperty("361")]
        public The0 The361 { get; set; }

        [JsonProperty("362")]
        public The0 The362 { get; set; }

        [JsonProperty("363")]
        public The0 The363 { get; set; }

        [JsonProperty("364")]
        public The0 The364 { get; set; }

        [JsonProperty("365")]
        public The0 The365 { get; set; }

        [JsonProperty("366")]
        public The0 The366 { get; set; }

        [JsonProperty("367")]
        public The0 The367 { get; set; }

        [JsonProperty("368")]
        public The0 The368 { get; set; }

        [JsonProperty("369")]
        public The0 The369 { get; set; }

        [JsonProperty("370")]
        public The0 The370 { get; set; }

        [JsonProperty("371")]
        public The0 The371 { get; set; }

        [JsonProperty("372")]
        public The0 The372 { get; set; }

        [JsonProperty("373")]
        public The0 The373 { get; set; }

        [JsonProperty("374")]
        public The0 The374 { get; set; }

        [JsonProperty("375")]
        public The0 The375 { get; set; }

        [JsonProperty("376")]
        public The0 The376 { get; set; }

        [JsonProperty("377")]
        public The0 The377 { get; set; }

        [JsonProperty("378")]
        public The0 The378 { get; set; }

        [JsonProperty("379")]
        public The0 The379 { get; set; }

        [JsonProperty("380")]
        public The0 The380 { get; set; }

        [JsonProperty("381")]
        public The0 The381 { get; set; }

        [JsonProperty("382")]
        public The0 The382 { get; set; }

        [JsonProperty("383")]
        public The0 The383 { get; set; }

        [JsonProperty("384")]
        public The0 The384 { get; set; }

        [JsonProperty("385")]
        public The0 The385 { get; set; }

        [JsonProperty("386")]
        public The0 The386 { get; set; }

        [JsonProperty("387")]
        public The0 The387 { get; set; }

        [JsonProperty("388")]
        public The0 The388 { get; set; }

        [JsonProperty("389")]
        public The0 The389 { get; set; }

        [JsonProperty("390")]
        public The0 The390 { get; set; }

        [JsonProperty("391")]
        public The0 The391 { get; set; }

        [JsonProperty("392")]
        public The0 The392 { get; set; }

        [JsonProperty("393")]
        public The0 The393 { get; set; }

        [JsonProperty("394")]
        public The0 The394 { get; set; }

        [JsonProperty("395")]
        public The0 The395 { get; set; }

        [JsonProperty("396")]
        public The0 The396 { get; set; }

        [JsonProperty("397")]
        public The0 The397 { get; set; }

        [JsonProperty("398")]
        public The0 The398 { get; set; }

        [JsonProperty("399")]
        public The0 The399 { get; set; }

        [JsonProperty("400")]
        public The0 The400 { get; set; }

        [JsonProperty("401")]
        public The0 The401 { get; set; }

        [JsonProperty("402")]
        public The0 The402 { get; set; }

        [JsonProperty("403")]
        public The0 The403 { get; set; }

        [JsonProperty("404")]
        public The0 The404 { get; set; }

        [JsonProperty("405")]
        public The0 The405 { get; set; }

        [JsonProperty("406")]
        public The0 The406 { get; set; }

        [JsonProperty("407")]
        public The0 The407 { get; set; }

        [JsonProperty("408")]
        public The0 The408 { get; set; }

        [JsonProperty("409")]
        public The0 The409 { get; set; }

        [JsonProperty("410")]
        public The0 The410 { get; set; }

        [JsonProperty("411")]
        public The0 The411 { get; set; }

        [JsonProperty("412")]
        public The0 The412 { get; set; }

        [JsonProperty("413")]
        public The0 The413 { get; set; }

        [JsonProperty("414")]
        public The0 The414 { get; set; }

        [JsonProperty("415")]
        public The0 The415 { get; set; }

        [JsonProperty("416")]
        public The0 The416 { get; set; }

        [JsonProperty("417")]
        public The0 The417 { get; set; }

        [JsonProperty("418")]
        public The0 The418 { get; set; }

        [JsonProperty("419")]
        public The0 The419 { get; set; }

        [JsonProperty("420")]
        public The0 The420 { get; set; }

        [JsonProperty("421")]
        public The0 The421 { get; set; }

        [JsonProperty("422")]
        public The0 The422 { get; set; }

        [JsonProperty("423")]
        public The0 The423 { get; set; }

        [JsonProperty("424")]
        public The0 The424 { get; set; }

        [JsonProperty("425")]
        public The0 The425 { get; set; }

        [JsonProperty("426")]
        public The0 The426 { get; set; }

        [JsonProperty("427")]
        public The0 The427 { get; set; }

        [JsonProperty("428")]
        public The0 The428 { get; set; }

        [JsonProperty("429")]
        public The0 The429 { get; set; }

        [JsonProperty("430")]
        public The0 The430 { get; set; }

        [JsonProperty("431")]
        public The0 The431 { get; set; }

        [JsonProperty("432")]
        public The0 The432 { get; set; }

        [JsonProperty("433")]
        public The0 The433 { get; set; }

        [JsonProperty("434")]
        public The0 The434 { get; set; }

        [JsonProperty("435")]
        public The0 The435 { get; set; }

        [JsonProperty("436")]
        public The0 The436 { get; set; }

        [JsonProperty("437")]
        public The0 The437 { get; set; }

        [JsonProperty("438")]
        public The0 The438 { get; set; }

        [JsonProperty("439")]
        public The0 The439 { get; set; }

        [JsonProperty("440")]
        public The0 The440 { get; set; }

        [JsonProperty("441")]
        public The0 The441 { get; set; }

        [JsonProperty("442")]
        public The0 The442 { get; set; }

        [JsonProperty("443")]
        public The0 The443 { get; set; }

        [JsonProperty("444")]
        public The0 The444 { get; set; }

        [JsonProperty("445")]
        public The0 The445 { get; set; }

        [JsonProperty("446")]
        public The0 The446 { get; set; }

        [JsonProperty("447")]
        public The0 The447 { get; set; }

        [JsonProperty("448")]
        public The0 The448 { get; set; }

        [JsonProperty("449")]
        public The0 The449 { get; set; }

        [JsonProperty("450")]
        public The0 The450 { get; set; }

        [JsonProperty("451")]
        public The0 The451 { get; set; }

        [JsonProperty("452")]
        public The0 The452 { get; set; }

        [JsonProperty("453")]
        public The0 The453 { get; set; }

        [JsonProperty("454")]
        public The0 The454 { get; set; }

        [JsonProperty("455")]
        public The0 The455 { get; set; }

        [JsonProperty("456")]
        public The0 The456 { get; set; }

        [JsonProperty("457")]
        public The0 The457 { get; set; }

        [JsonProperty("458")]
        public The0 The458 { get; set; }

        [JsonProperty("459")]
        public The0 The459 { get; set; }

        [JsonProperty("460")]
        public The0 The460 { get; set; }

        [JsonProperty("461")]
        public The0 The461 { get; set; }

        [JsonProperty("462")]
        public The0 The462 { get; set; }

        [JsonProperty("463")]
        public The0 The463 { get; set; }

        [JsonProperty("464")]
        public The0 The464 { get; set; }

        [JsonProperty("465")]
        public The0 The465 { get; set; }

        [JsonProperty("466")]
        public The0 The466 { get; set; }

        [JsonProperty("467")]
        public The0 The467 { get; set; }

        [JsonProperty("468")]
        public The0 The468 { get; set; }

        [JsonProperty("469")]
        public The0 The469 { get; set; }

        [JsonProperty("470")]
        public The0 The470 { get; set; }

        [JsonProperty("471")]
        public The0 The471 { get; set; }

        [JsonProperty("472")]
        public The0 The472 { get; set; }

        [JsonProperty("473")]
        public The0 The473 { get; set; }

        [JsonProperty("474")]
        public The0 The474 { get; set; }

        [JsonProperty("475")]
        public The0 The475 { get; set; }

        [JsonProperty("476")]
        public The0 The476 { get; set; }

        [JsonProperty("477")]
        public The0 The477 { get; set; }

        [JsonProperty("478")]
        public The0 The478 { get; set; }

        [JsonProperty("479")]
        public The0 The479 { get; set; }

        [JsonProperty("480")]
        public The0 The480 { get; set; }

        [JsonProperty("481")]
        public The0 The481 { get; set; }

        [JsonProperty("482")]
        public The0 The482 { get; set; }

        [JsonProperty("483")]
        public The0 The483 { get; set; }

        [JsonProperty("484")]
        public The0 The484 { get; set; }

        [JsonProperty("485")]
        public The0 The485 { get; set; }

        [JsonProperty("486")]
        public The0 The486 { get; set; }

        [JsonProperty("487")]
        public The0 The487 { get; set; }

        [JsonProperty("488")]
        public The0 The488 { get; set; }

        [JsonProperty("489")]
        public The0 The489 { get; set; }

        [JsonProperty("490")]
        public The0 The490 { get; set; }

        [JsonProperty("491")]
        public The0 The491 { get; set; }

        [JsonProperty("492")]
        public The0 The492 { get; set; }

        [JsonProperty("493")]
        public The0 The493 { get; set; }

        [JsonProperty("494")]
        public The0 The494 { get; set; }

        [JsonProperty("495")]
        public The0 The495 { get; set; }

        [JsonProperty("496")]
        public The0 The496 { get; set; }

        [JsonProperty("497")]
        public The0 The497 { get; set; }

        [JsonProperty("498")]
        public The0 The498 { get; set; }

        [JsonProperty("499")]
        public The0 The499 { get; set; }

        [JsonProperty("500")]
        public The0 The500 { get; set; }

        [JsonProperty("501")]
        public The0 The501 { get; set; }

        [JsonProperty("502")]
        public The0 The502 { get; set; }

        [JsonProperty("503")]
        public The0 The503 { get; set; }

        [JsonProperty("504")]
        public The0 The504 { get; set; }

        [JsonProperty("505")]
        public The0 The505 { get; set; }

        [JsonProperty("506")]
        public The0 The506 { get; set; }

        [JsonProperty("507")]
        public The0 The507 { get; set; }

        [JsonProperty("508")]
        public The0 The508 { get; set; }

        [JsonProperty("509")]
        public The0 The509 { get; set; }

        [JsonProperty("510")]
        public The0 The510 { get; set; }

        [JsonProperty("511")]
        public The0 The511 { get; set; }

        [JsonProperty("512")]
        public The0 The512 { get; set; }

        [JsonProperty("513")]
        public The0 The513 { get; set; }

        [JsonProperty("514")]
        public The0 The514 { get; set; }

        [JsonProperty("515")]
        public The0 The515 { get; set; }

        [JsonProperty("516")]
        public The0 The516 { get; set; }

        [JsonProperty("517")]
        public The0 The517 { get; set; }

        [JsonProperty("518")]
        public The0 The518 { get; set; }

        [JsonProperty("519")]
        public The0 The519 { get; set; }

        [JsonProperty("520")]
        public The0 The520 { get; set; }

        [JsonProperty("521")]
        public The0 The521 { get; set; }

        [JsonProperty("522")]
        public The0 The522 { get; set; }

        [JsonProperty("523")]
        public The0 The523 { get; set; }

        [JsonProperty("524")]
        public The0 The524 { get; set; }

        [JsonProperty("525")]
        public The0 The525 { get; set; }

        [JsonProperty("526")]
        public The0 The526 { get; set; }

        [JsonProperty("527")]
        public The0 The527 { get; set; }

        [JsonProperty("528")]
        public The0 The528 { get; set; }

        [JsonProperty("529")]
        public The0 The529 { get; set; }

        [JsonProperty("530")]
        public The0 The530 { get; set; }

        [JsonProperty("531")]
        public The0 The531 { get; set; }

        [JsonProperty("532")]
        public The0 The532 { get; set; }

        [JsonProperty("533")]
        public The0 The533 { get; set; }

        [JsonProperty("534")]
        public The0 The534 { get; set; }

        [JsonProperty("535")]
        public The0 The535 { get; set; }

        [JsonProperty("536")]
        public The0 The536 { get; set; }

        [JsonProperty("537")]
        public The0 The537 { get; set; }

        [JsonProperty("538")]
        public The0 The538 { get; set; }

        [JsonProperty("539")]
        public The0 The539 { get; set; }

        [JsonProperty("540")]
        public The0 The540 { get; set; }

        [JsonProperty("541")]
        public The0 The541 { get; set; }

        [JsonProperty("542")]
        public The0 The542 { get; set; }

        [JsonProperty("543")]
        public The0 The543 { get; set; }

        [JsonProperty("544")]
        public The0 The544 { get; set; }

        [JsonProperty("545")]
        public The0 The545 { get; set; }

        [JsonProperty("546")]
        public The0 The546 { get; set; }

        [JsonProperty("547")]
        public The0 The547 { get; set; }

        [JsonProperty("548")]
        public The0 The548 { get; set; }

        [JsonProperty("549")]
        public The0 The549 { get; set; }

        [JsonProperty("550")]
        public The0 The550 { get; set; }

        [JsonProperty("551")]
        public The0 The551 { get; set; }

        [JsonProperty("552")]
        public The0 The552 { get; set; }

        [JsonProperty("553")]
        public The0 The553 { get; set; }

        [JsonProperty("554")]
        public The0 The554 { get; set; }

        [JsonProperty("555")]
        public The0 The555 { get; set; }

        [JsonProperty("556")]
        public The0 The556 { get; set; }

        [JsonProperty("557")]
        public The0 The557 { get; set; }

        [JsonProperty("558")]
        public The0 The558 { get; set; }

        [JsonProperty("559")]
        public The0 The559 { get; set; }

        [JsonProperty("560")]
        public The0 The560 { get; set; }

        [JsonProperty("561")]
        public The0 The561 { get; set; }

        [JsonProperty("562")]
        public The0 The562 { get; set; }

        [JsonProperty("563")]
        public The0 The563 { get; set; }

        [JsonProperty("564")]
        public The0 The564 { get; set; }

        [JsonProperty("565")]
        public The0 The565 { get; set; }

        [JsonProperty("566")]
        public The0 The566 { get; set; }

        [JsonProperty("567")]
        public The0 The567 { get; set; }

        [JsonProperty("568")]
        public The0 The568 { get; set; }

        [JsonProperty("569")]
        public The0 The569 { get; set; }

        [JsonProperty("570")]
        public The0 The570 { get; set; }

        [JsonProperty("571")]
        public The0 The571 { get; set; }

        [JsonProperty("572")]
        public The0 The572 { get; set; }

        [JsonProperty("573")]
        public The0 The573 { get; set; }

        [JsonProperty("574")]
        public The0 The574 { get; set; }

        [JsonProperty("575")]
        public The0 The575 { get; set; }

        [JsonProperty("576")]
        public The0 The576 { get; set; }

        [JsonProperty("577")]
        public The0 The577 { get; set; }

        [JsonProperty("578")]
        public The0 The578 { get; set; }

        [JsonProperty("579")]
        public The0 The579 { get; set; }

        [JsonProperty("580")]
        public The0 The580 { get; set; }

        [JsonProperty("581")]
        public The0 The581 { get; set; }

        [JsonProperty("582")]
        public The0 The582 { get; set; }

        [JsonProperty("583")]
        public The0 The583 { get; set; }

        [JsonProperty("584")]
        public The0 The584 { get; set; }

        [JsonProperty("585")]
        public The0 The585 { get; set; }

        [JsonProperty("586")]
        public The0 The586 { get; set; }

        [JsonProperty("587")]
        public The0 The587 { get; set; }

        [JsonProperty("588")]
        public The0 The588 { get; set; }

        [JsonProperty("589")]
        public The0 The589 { get; set; }

        [JsonProperty("590")]
        public The0 The590 { get; set; }

        [JsonProperty("591")]
        public The0 The591 { get; set; }

        [JsonProperty("592")]
        public The0 The592 { get; set; }

        [JsonProperty("593")]
        public The0 The593 { get; set; }

        [JsonProperty("594")]
        public The0 The594 { get; set; }

        [JsonProperty("595")]
        public The0 The595 { get; set; }

        [JsonProperty("596")]
        public The0 The596 { get; set; }

        [JsonProperty("597")]
        public The0 The597 { get; set; }

        [JsonProperty("598")]
        public The0 The598 { get; set; }

        [JsonProperty("599")]
        public The0 The599 { get; set; }

        [JsonProperty("600")]
        public The0 The600 { get; set; }

        [JsonProperty("601")]
        public The0 The601 { get; set; }

        [JsonProperty("602")]
        public The0 The602 { get; set; }

        [JsonProperty("603")]
        public The0 The603 { get; set; }

        [JsonProperty("604")]
        public The0 The604 { get; set; }

        [JsonProperty("605")]
        public The0 The605 { get; set; }

        [JsonProperty("606")]
        public The0 The606 { get; set; }

        [JsonProperty("607")]
        public The0 The607 { get; set; }

        [JsonProperty("608")]
        public The0 The608 { get; set; }

        [JsonProperty("609")]
        public The0 The609 { get; set; }

        [JsonProperty("610")]
        public The0 The610 { get; set; }

        [JsonProperty("611")]
        public The0 The611 { get; set; }

        [JsonProperty("612")]
        public The0 The612 { get; set; }

        [JsonProperty("613")]
        public The0 The613 { get; set; }

        [JsonProperty("614")]
        public The0 The614 { get; set; }

        [JsonProperty("615")]
        public The0 The615 { get; set; }

        [JsonProperty("616")]
        public The0 The616 { get; set; }

        [JsonProperty("617")]
        public The0 The617 { get; set; }

        [JsonProperty("618")]
        public The0 The618 { get; set; }

        [JsonProperty("619")]
        public The0 The619 { get; set; }

        [JsonProperty("620")]
        public The0 The620 { get; set; }

        [JsonProperty("621")]
        public The0 The621 { get; set; }

        [JsonProperty("622")]
        public The0 The622 { get; set; }

        [JsonProperty("623")]
        public The0 The623 { get; set; }

        [JsonProperty("624")]
        public The0 The624 { get; set; }

        [JsonProperty("625")]
        public The0 The625 { get; set; }

        [JsonProperty("626")]
        public The0 The626 { get; set; }

        [JsonProperty("627")]
        public The0 The627 { get; set; }

        [JsonProperty("628")]
        public The0 The628 { get; set; }

        [JsonProperty("629")]
        public The0 The629 { get; set; }

        [JsonProperty("630")]
        public The0 The630 { get; set; }

        [JsonProperty("631")]
        public The0 The631 { get; set; }

        [JsonProperty("632")]
        public The0 The632 { get; set; }

        [JsonProperty("633")]
        public The0 The633 { get; set; }

        [JsonProperty("634")]
        public The0 The634 { get; set; }

        [JsonProperty("635")]
        public The0 The635 { get; set; }

        [JsonProperty("636")]
        public The0 The636 { get; set; }

        [JsonProperty("637")]
        public The0 The637 { get; set; }

        [JsonProperty("638")]
        public The0 The638 { get; set; }

        [JsonProperty("639")]
        public The0 The639 { get; set; }

        [JsonProperty("640")]
        public The0 The640 { get; set; }

        [JsonProperty("641")]
        public The0 The641 { get; set; }

        [JsonProperty("642")]
        public The0 The642 { get; set; }

        [JsonProperty("643")]
        public The0 The643 { get; set; }

        [JsonProperty("644")]
        public The0 The644 { get; set; }

        [JsonProperty("645")]
        public The0 The645 { get; set; }

        [JsonProperty("646")]
        public The0 The646 { get; set; }

        [JsonProperty("647")]
        public The0 The647 { get; set; }

        [JsonProperty("648")]
        public The0 The648 { get; set; }

        [JsonProperty("649")]
        public The0 The649 { get; set; }

        [JsonProperty("650")]
        public The0 The650 { get; set; }

        [JsonProperty("651")]
        public The0 The651 { get; set; }

        [JsonProperty("652")]
        public The0 The652 { get; set; }

        [JsonProperty("653")]
        public The0 The653 { get; set; }

        [JsonProperty("654")]
        public The0 The654 { get; set; }

        [JsonProperty("655")]
        public The0 The655 { get; set; }

        [JsonProperty("656")]
        public The0 The656 { get; set; }

        [JsonProperty("657")]
        public The0 The657 { get; set; }

        [JsonProperty("658")]
        public The0 The658 { get; set; }

        [JsonProperty("659")]
        public The0 The659 { get; set; }

        [JsonProperty("660")]
        public The0 The660 { get; set; }

        [JsonProperty("661")]
        public The0 The661 { get; set; }

        [JsonProperty("662")]
        public The0 The662 { get; set; }

        [JsonProperty("663")]
        public The0 The663 { get; set; }

        [JsonProperty("664")]
        public The0 The664 { get; set; }

        [JsonProperty("665")]
        public The0 The665 { get; set; }

        [JsonProperty("666")]
        public The0 The666 { get; set; }

        [JsonProperty("667")]
        public The0 The667 { get; set; }

        [JsonProperty("668")]
        public The0 The668 { get; set; }

        [JsonProperty("669")]
        public The0 The669 { get; set; }

        [JsonProperty("670")]
        public The0 The670 { get; set; }

        [JsonProperty("671")]
        public The0 The671 { get; set; }

        [JsonProperty("672")]
        public The0 The672 { get; set; }

        [JsonProperty("673")]
        public The0 The673 { get; set; }

        [JsonProperty("674")]
        public The0 The674 { get; set; }

        [JsonProperty("675")]
        public The0 The675 { get; set; }

        [JsonProperty("676")]
        public The0 The676 { get; set; }

        [JsonProperty("677")]
        public The0 The677 { get; set; }

        [JsonProperty("678")]
        public The0 The678 { get; set; }

        [JsonProperty("679")]
        public The0 The679 { get; set; }

        [JsonProperty("680")]
        public The0 The680 { get; set; }

        [JsonProperty("681")]
        public The0 The681 { get; set; }

        [JsonProperty("682")]
        public The0 The682 { get; set; }

        [JsonProperty("683")]
        public The0 The683 { get; set; }

        [JsonProperty("684")]
        public The0 The684 { get; set; }

        [JsonProperty("685")]
        public The0 The685 { get; set; }

        [JsonProperty("686")]
        public The0 The686 { get; set; }

        [JsonProperty("687")]
        public The0 The687 { get; set; }

        [JsonProperty("688")]
        public The0 The688 { get; set; }

        [JsonProperty("689")]
        public The0 The689 { get; set; }

        [JsonProperty("690")]
        public The0 The690 { get; set; }

        [JsonProperty("691")]
        public The0 The691 { get; set; }

        [JsonProperty("692")]
        public The0 The692 { get; set; }

        [JsonProperty("693")]
        public The0 The693 { get; set; }

        [JsonProperty("694")]
        public The0 The694 { get; set; }

        [JsonProperty("695")]
        public The0 The695 { get; set; }

        [JsonProperty("696")]
        public The0 The696 { get; set; }

        [JsonProperty("697")]
        public The0 The697 { get; set; }

        [JsonProperty("698")]
        public The0 The698 { get; set; }

        [JsonProperty("699")]
        public The0 The699 { get; set; }

        [JsonProperty("700")]
        public The0 The700 { get; set; }

        [JsonProperty("701")]
        public The0 The701 { get; set; }

        [JsonProperty("702")]
        public The0 The702 { get; set; }

        [JsonProperty("703")]
        public The0 The703 { get; set; }

        [JsonProperty("704")]
        public The0 The704 { get; set; }

        [JsonProperty("705")]
        public The0 The705 { get; set; }

        [JsonProperty("706")]
        public The0 The706 { get; set; }

        [JsonProperty("707")]
        public The0 The707 { get; set; }

        [JsonProperty("708")]
        public The0 The708 { get; set; }

        [JsonProperty("709")]
        public The0 The709 { get; set; }

        [JsonProperty("710")]
        public The0 The710 { get; set; }

        [JsonProperty("711")]
        public The0 The711 { get; set; }

        [JsonProperty("712")]
        public The0 The712 { get; set; }

        [JsonProperty("713")]
        public The0 The713 { get; set; }

        [JsonProperty("714")]
        public The0 The714 { get; set; }

        [JsonProperty("715")]
        public The0 The715 { get; set; }

        [JsonProperty("716")]
        public The0 The716 { get; set; }

        [JsonProperty("717")]
        public The0 The717 { get; set; }

        [JsonProperty("718")]
        public The0 The718 { get; set; }

        [JsonProperty("719")]
        public The0 The719 { get; set; }

        [JsonProperty("720")]
        public The0 The720 { get; set; }

        [JsonProperty("721")]
        public The0 The721 { get; set; }

        [JsonProperty("722")]
        public The0 The722 { get; set; }

        [JsonProperty("723")]
        public The0 The723 { get; set; }

        [JsonProperty("724")]
        public The0 The724 { get; set; }

        [JsonProperty("725")]
        public The0 The725 { get; set; }

        [JsonProperty("726")]
        public The0 The726 { get; set; }

        [JsonProperty("727")]
        public The0 The727 { get; set; }

        [JsonProperty("728")]
        public The0 The728 { get; set; }

        [JsonProperty("729")]
        public The0 The729 { get; set; }

        [JsonProperty("730")]
        public The0 The730 { get; set; }

        [JsonProperty("731")]
        public The0 The731 { get; set; }

        [JsonProperty("732")]
        public The0 The732 { get; set; }

        [JsonProperty("733")]
        public The0 The733 { get; set; }

        [JsonProperty("734")]
        public The0 The734 { get; set; }

        [JsonProperty("735")]
        public The0 The735 { get; set; }

        [JsonProperty("736")]
        public The0 The736 { get; set; }

        [JsonProperty("737")]
        public The0 The737 { get; set; }

        [JsonProperty("738")]
        public The0 The738 { get; set; }

        [JsonProperty("739")]
        public The0 The739 { get; set; }

        [JsonProperty("740")]
        public The0 The740 { get; set; }

        [JsonProperty("741")]
        public The0 The741 { get; set; }

        [JsonProperty("742")]
        public The0 The742 { get; set; }

        [JsonProperty("743")]
        public The0 The743 { get; set; }

        [JsonProperty("744")]
        public The0 The744 { get; set; }

        [JsonProperty("745")]
        public The0 The745 { get; set; }

        [JsonProperty("746")]
        public The0 The746 { get; set; }

        [JsonProperty("747")]
        public The0 The747 { get; set; }

        [JsonProperty("748")]
        public The0 The748 { get; set; }

        [JsonProperty("749")]
        public The0 The749 { get; set; }

        [JsonProperty("750")]
        public The0 The750 { get; set; }

        [JsonProperty("751")]
        public The0 The751 { get; set; }

        [JsonProperty("752")]
        public The0 The752 { get; set; }

        [JsonProperty("753")]
        public The0 The753 { get; set; }

        [JsonProperty("754")]
        public The0 The754 { get; set; }

        [JsonProperty("755")]
        public The0 The755 { get; set; }

        [JsonProperty("756")]
        public The0 The756 { get; set; }

        [JsonProperty("757")]
        public The0 The757 { get; set; }

        [JsonProperty("758")]
        public The0 The758 { get; set; }

        [JsonProperty("759")]
        public The0 The759 { get; set; }

        [JsonProperty("760")]
        public The0 The760 { get; set; }

        [JsonProperty("761")]
        public The0 The761 { get; set; }

        [JsonProperty("762")]
        public The0 The762 { get; set; }

        [JsonProperty("763")]
        public The0 The763 { get; set; }

        [JsonProperty("764")]
        public The0 The764 { get; set; }

        [JsonProperty("765")]
        public The0 The765 { get; set; }

        [JsonProperty("766")]
        public The0 The766 { get; set; }

        [JsonProperty("767")]
        public The0 The767 { get; set; }

        [JsonProperty("768")]
        public The0 The768 { get; set; }

        [JsonProperty("769")]
        public The0 The769 { get; set; }

        [JsonProperty("770")]
        public The0 The770 { get; set; }

        [JsonProperty("771")]
        public The0 The771 { get; set; }

        [JsonProperty("772")]
        public The0 The772 { get; set; }

        [JsonProperty("773")]
        public The0 The773 { get; set; }

        [JsonProperty("774")]
        public The0 The774 { get; set; }

        [JsonProperty("775")]
        public The0 The775 { get; set; }

        [JsonProperty("776")]
        public The0 The776 { get; set; }

        [JsonProperty("777")]
        public The0 The777 { get; set; }

        [JsonProperty("778")]
        public The0 The778 { get; set; }

        [JsonProperty("779")]
        public The0 The779 { get; set; }

        [JsonProperty("780")]
        public The0 The780 { get; set; }

        [JsonProperty("781")]
        public The0 The781 { get; set; }

        [JsonProperty("782")]
        public The0 The782 { get; set; }

        [JsonProperty("783")]
        public The0 The783 { get; set; }

        [JsonProperty("784")]
        public The0 The784 { get; set; }

        [JsonProperty("785")]
        public The0 The785 { get; set; }

        [JsonProperty("786")]
        public The0 The786 { get; set; }

        [JsonProperty("787")]
        public The0 The787 { get; set; }

        [JsonProperty("788")]
        public The0 The788 { get; set; }

        [JsonProperty("789")]
        public The0 The789 { get; set; }

        [JsonProperty("790")]
        public The0 The790 { get; set; }

        [JsonProperty("791")]
        public The0 The791 { get; set; }

        [JsonProperty("792")]
        public The0 The792 { get; set; }

        [JsonProperty("793")]
        public The0 The793 { get; set; }

        [JsonProperty("794")]
        public The0 The794 { get; set; }

        [JsonProperty("795")]
        public The0 The795 { get; set; }

        [JsonProperty("796")]
        public The0 The796 { get; set; }

        [JsonProperty("797")]
        public The0 The797 { get; set; }

        [JsonProperty("798")]
        public The0 The798 { get; set; }

        [JsonProperty("799")]
        public The0 The799 { get; set; }

        [JsonProperty("800")]
        public The0 The800 { get; set; }

        [JsonProperty("801")]
        public The0 The801 { get; set; }

        [JsonProperty("802")]
        public The0 The802 { get; set; }

        [JsonProperty("803")]
        public The0 The803 { get; set; }

        [JsonProperty("804")]
        public The0 The804 { get; set; }

        [JsonProperty("805")]
        public The0 The805 { get; set; }

        [JsonProperty("806")]
        public The0 The806 { get; set; }

        [JsonProperty("807")]
        public The0 The807 { get; set; }

        [JsonProperty("808")]
        public The0 The808 { get; set; }

        [JsonProperty("809")]
        public The0 The809 { get; set; }

        [JsonProperty("810")]
        public The0 The810 { get; set; }

        [JsonProperty("811")]
        public The0 The811 { get; set; }

        [JsonProperty("812")]
        public The0 The812 { get; set; }

        [JsonProperty("813")]
        public The0 The813 { get; set; }

        [JsonProperty("814")]
        public The0 The814 { get; set; }

        [JsonProperty("815")]
        public The0 The815 { get; set; }

        [JsonProperty("816")]
        public The0 The816 { get; set; }

        [JsonProperty("817")]
        public The0 The817 { get; set; }

        [JsonProperty("818")]
        public The0 The818 { get; set; }

        [JsonProperty("819")]
        public The0 The819 { get; set; }

        [JsonProperty("820")]
        public The0 The820 { get; set; }

        [JsonProperty("821")]
        public The0 The821 { get; set; }

        [JsonProperty("822")]
        public The0 The822 { get; set; }

        [JsonProperty("823")]
        public The0 The823 { get; set; }

        [JsonProperty("824")]
        public The0 The824 { get; set; }

        [JsonProperty("825")]
        public The0 The825 { get; set; }

        [JsonProperty("826")]
        public The0 The826 { get; set; }

        [JsonProperty("827")]
        public The0 The827 { get; set; }

        [JsonProperty("828")]
        public The0 The828 { get; set; }

        [JsonProperty("829")]
        public The0 The829 { get; set; }

        [JsonProperty("830")]
        public The0 The830 { get; set; }

        [JsonProperty("831")]
        public The0 The831 { get; set; }

        [JsonProperty("832")]
        public The0 The832 { get; set; }

        [JsonProperty("833")]
        public The0 The833 { get; set; }

        [JsonProperty("834")]
        public The0 The834 { get; set; }

        [JsonProperty("835")]
        public The0 The835 { get; set; }

        [JsonProperty("836")]
        public The0 The836 { get; set; }

        [JsonProperty("837")]
        public The0 The837 { get; set; }

        [JsonProperty("838")]
        public The0 The838 { get; set; }

        [JsonProperty("839")]
        public The0 The839 { get; set; }

        [JsonProperty("840")]
        public The0 The840 { get; set; }

        [JsonProperty("841")]
        public The0 The841 { get; set; }

        [JsonProperty("842")]
        public The0 The842 { get; set; }

        [JsonProperty("843")]
        public The0 The843 { get; set; }

        [JsonProperty("844")]
        public The0 The844 { get; set; }

        [JsonProperty("845")]
        public The0 The845 { get; set; }

        [JsonProperty("846")]
        public The0 The846 { get; set; }

        [JsonProperty("847")]
        public The0 The847 { get; set; }

        [JsonProperty("848")]
        public The0 The848 { get; set; }

        [JsonProperty("849")]
        public The0 The849 { get; set; }

        [JsonProperty("850")]
        public The0 The850 { get; set; }

        [JsonProperty("851")]
        public The0 The851 { get; set; }

        [JsonProperty("852")]
        public The0 The852 { get; set; }

        [JsonProperty("853")]
        public The0 The853 { get; set; }

        [JsonProperty("854")]
        public The0 The854 { get; set; }

        [JsonProperty("855")]
        public The0 The855 { get; set; }

        [JsonProperty("856")]
        public The0 The856 { get; set; }

        [JsonProperty("857")]
        public The0 The857 { get; set; }

        [JsonProperty("858")]
        public The0 The858 { get; set; }

        [JsonProperty("859")]
        public The0 The859 { get; set; }

        [JsonProperty("860")]
        public The0 The860 { get; set; }

        [JsonProperty("861")]
        public The0 The861 { get; set; }

        [JsonProperty("862")]
        public The0 The862 { get; set; }

        [JsonProperty("863")]
        public The0 The863 { get; set; }

        [JsonProperty("864")]
        public The0 The864 { get; set; }

        [JsonProperty("865")]
        public The0 The865 { get; set; }

        [JsonProperty("866")]
        public The0 The866 { get; set; }

        [JsonProperty("867")]
        public The0 The867 { get; set; }

        [JsonProperty("868")]
        public The0 The868 { get; set; }

        [JsonProperty("869")]
        public The0 The869 { get; set; }

        [JsonProperty("870")]
        public The0 The870 { get; set; }

        [JsonProperty("871")]
        public The0 The871 { get; set; }

        [JsonProperty("872")]
        public The0 The872 { get; set; }

        [JsonProperty("873")]
        public The0 The873 { get; set; }

        [JsonProperty("874")]
        public The0 The874 { get; set; }

        [JsonProperty("875")]
        public The0 The875 { get; set; }

        [JsonProperty("876")]
        public The0 The876 { get; set; }

        [JsonProperty("877")]
        public The0 The877 { get; set; }

        [JsonProperty("878")]
        public The0 The878 { get; set; }

        [JsonProperty("879")]
        public The0 The879 { get; set; }

        [JsonProperty("880")]
        public The0 The880 { get; set; }

        [JsonProperty("881")]
        public The0 The881 { get; set; }

        [JsonProperty("882")]
        public The0 The882 { get; set; }

        [JsonProperty("883")]
        public The0 The883 { get; set; }

        [JsonProperty("884")]
        public The0 The884 { get; set; }

        [JsonProperty("885")]
        public The0 The885 { get; set; }

        [JsonProperty("886")]
        public The0 The886 { get; set; }

        [JsonProperty("887")]
        public The0 The887 { get; set; }

        [JsonProperty("888")]
        public The0 The888 { get; set; }

        [JsonProperty("889")]
        public The0 The889 { get; set; }

        [JsonProperty("890")]
        public The0 The890 { get; set; }

        [JsonProperty("891")]
        public The0 The891 { get; set; }

        [JsonProperty("892")]
        public The0 The892 { get; set; }

        [JsonProperty("893")]
        public The0 The893 { get; set; }

        [JsonProperty("894")]
        public The0 The894 { get; set; }

        [JsonProperty("895")]
        public The0 The895 { get; set; }

        [JsonProperty("896")]
        public The0 The896 { get; set; }

        [JsonProperty("897")]
        public The0 The897 { get; set; }

        [JsonProperty("898")]
        public The0 The898 { get; set; }

        [JsonProperty("899")]
        public The0 The899 { get; set; }

        [JsonProperty("900")]
        public The0 The900 { get; set; }

        [JsonProperty("901")]
        public The0 The901 { get; set; }

        [JsonProperty("902")]
        public The0 The902 { get; set; }

        [JsonProperty("903")]
        public The0 The903 { get; set; }

        [JsonProperty("904")]
        public The0 The904 { get; set; }

        [JsonProperty("905")]
        public The0 The905 { get; set; }

        [JsonProperty("906")]
        public The0 The906 { get; set; }

        [JsonProperty("907")]
        public The0 The907 { get; set; }

        [JsonProperty("908")]
        public The0 The908 { get; set; }

        [JsonProperty("909")]
        public The0 The909 { get; set; }

        [JsonProperty("910")]
        public The0 The910 { get; set; }

        [JsonProperty("911")]
        public The0 The911 { get; set; }

        [JsonProperty("912")]
        public The0 The912 { get; set; }

        [JsonProperty("913")]
        public The0 The913 { get; set; }

        [JsonProperty("914")]
        public The0 The914 { get; set; }

        [JsonProperty("915")]
        public The0 The915 { get; set; }

        [JsonProperty("916")]
        public The0 The916 { get; set; }

        [JsonProperty("917")]
        public The0 The917 { get; set; }

        [JsonProperty("918")]
        public The0 The918 { get; set; }

        [JsonProperty("919")]
        public The0 The919 { get; set; }

        [JsonProperty("920")]
        public The0 The920 { get; set; }

        [JsonProperty("921")]
        public The0 The921 { get; set; }

        [JsonProperty("922")]
        public The0 The922 { get; set; }

        [JsonProperty("923")]
        public The0 The923 { get; set; }

        [JsonProperty("924")]
        public The0 The924 { get; set; }

        [JsonProperty("925")]
        public The0 The925 { get; set; }

        [JsonProperty("926")]
        public The0 The926 { get; set; }

        [JsonProperty("927")]
        public The0 The927 { get; set; }

        [JsonProperty("928")]
        public The0 The928 { get; set; }

        [JsonProperty("929")]
        public The0 The929 { get; set; }

        [JsonProperty("930")]
        public The0 The930 { get; set; }

        [JsonProperty("931")]
        public The0 The931 { get; set; }

        [JsonProperty("932")]
        public The0 The932 { get; set; }

        [JsonProperty("933")]
        public The0 The933 { get; set; }

        [JsonProperty("934")]
        public The0 The934 { get; set; }

        [JsonProperty("935")]
        public The0 The935 { get; set; }

        [JsonProperty("936")]
        public The0 The936 { get; set; }

        [JsonProperty("937")]
        public The0 The937 { get; set; }

        [JsonProperty("938")]
        public The0 The938 { get; set; }

        [JsonProperty("939")]
        public The0 The939 { get; set; }

        [JsonProperty("940")]
        public The0 The940 { get; set; }

        [JsonProperty("941")]
        public The0 The941 { get; set; }

        [JsonProperty("942")]
        public The0 The942 { get; set; }

        [JsonProperty("943")]
        public The0 The943 { get; set; }

        [JsonProperty("944")]
        public The0 The944 { get; set; }

        [JsonProperty("945")]
        public The0 The945 { get; set; }

        [JsonProperty("946")]
        public The0 The946 { get; set; }

        [JsonProperty("947")]
        public The0 The947 { get; set; }

        [JsonProperty("948")]
        public The0 The948 { get; set; }

        [JsonProperty("949")]
        public The0 The949 { get; set; }

        [JsonProperty("950")]
        public The0 The950 { get; set; }

        [JsonProperty("951")]
        public The0 The951 { get; set; }

        [JsonProperty("952")]
        public The0 The952 { get; set; }

        [JsonProperty("953")]
        public The0 The953 { get; set; }

        [JsonProperty("954")]
        public The0 The954 { get; set; }

        [JsonProperty("955")]
        public The0 The955 { get; set; }

        [JsonProperty("956")]
        public The0 The956 { get; set; }

        [JsonProperty("957")]
        public The0 The957 { get; set; }

        [JsonProperty("958")]
        public The0 The958 { get; set; }

        [JsonProperty("959")]
        public The0 The959 { get; set; }

        [JsonProperty("960")]
        public The0 The960 { get; set; }

        [JsonProperty("961")]
        public The0 The961 { get; set; }

        [JsonProperty("962")]
        public The0 The962 { get; set; }

        [JsonProperty("963")]
        public The0 The963 { get; set; }

        [JsonProperty("964")]
        public The0 The964 { get; set; }

        [JsonProperty("965")]
        public The0 The965 { get; set; }

        [JsonProperty("966")]
        public The0 The966 { get; set; }

        [JsonProperty("967")]
        public The0 The967 { get; set; }

        [JsonProperty("968")]
        public The0 The968 { get; set; }

        [JsonProperty("969")]
        public The0 The969 { get; set; }

        [JsonProperty("970")]
        public The0 The970 { get; set; }

        [JsonProperty("971")]
        public The0 The971 { get; set; }

        [JsonProperty("972")]
        public The0 The972 { get; set; }

        [JsonProperty("973")]
        public The0 The973 { get; set; }

        [JsonProperty("974")]
        public The0 The974 { get; set; }

        [JsonProperty("975")]
        public The0 The975 { get; set; }

        [JsonProperty("976")]
        public The0 The976 { get; set; }

        [JsonProperty("977")]
        public The0 The977 { get; set; }

        [JsonProperty("978")]
        public The0 The978 { get; set; }

        [JsonProperty("979")]
        public The0 The979 { get; set; }

        [JsonProperty("980")]
        public The0 The980 { get; set; }

        [JsonProperty("981")]
        public The0 The981 { get; set; }

        [JsonProperty("982")]
        public The0 The982 { get; set; }

        [JsonProperty("983")]
        public The0 The983 { get; set; }

        [JsonProperty("984")]
        public The0 The984 { get; set; }

        [JsonProperty("985")]
        public The0 The985 { get; set; }

        [JsonProperty("986")]
        public The0 The986 { get; set; }

        [JsonProperty("987")]
        public The0 The987 { get; set; }

        [JsonProperty("988")]
        public The0 The988 { get; set; }

        [JsonProperty("989")]
        public The0 The989 { get; set; }

        [JsonProperty("990")]
        public The0 The990 { get; set; }

        [JsonProperty("991")]
        public The0 The991 { get; set; }

        [JsonProperty("992")]
        public The0 The992 { get; set; }

        [JsonProperty("993")]
        public The0 The993 { get; set; }

        [JsonProperty("994")]
        public The0 The994 { get; set; }

        [JsonProperty("995")]
        public The0 The995 { get; set; }

        [JsonProperty("996")]
        public The0 The996 { get; set; }

        [JsonProperty("997")]
        public The0 The997 { get; set; }

        [JsonProperty("998")]
        public The0 The998 { get; set; }

        [JsonProperty("999")]
        public The0 The999 { get; set; }

        [JsonProperty("1000")]
        public The0 The1000 { get; set; }

        [JsonProperty("1001")]
        public The0 The1001 { get; set; }

        [JsonProperty("1002")]
        public The0 The1002 { get; set; }

        [JsonProperty("1003")]
        public The0 The1003 { get; set; }

        [JsonProperty("1004")]
        public The0 The1004 { get; set; }

        [JsonProperty("1005")]
        public The0 The1005 { get; set; }

        [JsonProperty("1006")]
        public The0 The1006 { get; set; }

        [JsonProperty("1007")]
        public The0 The1007 { get; set; }

        [JsonProperty("1008")]
        public The0 The1008 { get; set; }

        [JsonProperty("1009")]
        public The0 The1009 { get; set; }

        [JsonProperty("1010")]
        public The0 The1010 { get; set; }

        [JsonProperty("1011")]
        public The0 The1011 { get; set; }

        [JsonProperty("1012")]
        public The0 The1012 { get; set; }

        [JsonProperty("1013")]
        public The0 The1013 { get; set; }

        [JsonProperty("1014")]
        public The0 The1014 { get; set; }

        [JsonProperty("1015")]
        public The0 The1015 { get; set; }

        [JsonProperty("1016")]
        public The0 The1016 { get; set; }

        [JsonProperty("1017")]
        public The0 The1017 { get; set; }

        [JsonProperty("1018")]
        public The0 The1018 { get; set; }

        [JsonProperty("1019")]
        public The0 The1019 { get; set; }

        [JsonProperty("1020")]
        public The0 The1020 { get; set; }

        [JsonProperty("1021")]
        public The0 The1021 { get; set; }

        [JsonProperty("1022")]
        public The0 The1022 { get; set; }

        [JsonProperty("1023")]
        public The0 The1023 { get; set; }

        [JsonProperty("1024")]
        public The0 The1024 { get; set; }

        [JsonProperty("1025")]
        public The0 The1025 { get; set; }

        [JsonProperty("1026")]
        public The0 The1026 { get; set; }

        [JsonProperty("1027")]
        public The0 The1027 { get; set; }

        [JsonProperty("1028")]
        public The0 The1028 { get; set; }

        [JsonProperty("1029")]
        public The0 The1029 { get; set; }

        [JsonProperty("1030")]
        public The0 The1030 { get; set; }

        [JsonProperty("1031")]
        public The0 The1031 { get; set; }

        [JsonProperty("1032")]
        public The0 The1032 { get; set; }
    }

    public partial class The0
    {
        [JsonProperty("start")]
        public double Start { get; set; }

        [JsonProperty("end")]
        public double End { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("best_path")]
        public bool BestPath { get; set; }

        [JsonProperty("speaker")]
        public long Speaker { get; set; }

        [JsonProperty("word")]
        public string Word { get; set; }

        [JsonProperty("intensity")]
        public double Intensity { get; set; }
    }

    public partial class FirstChannelLabelStatistics
    {
        [JsonProperty("content_fetch_time")]
        public long ContentFetchTime { get; set; }

        [JsonProperty("audio_length")]
        public double AudioLength { get; set; }

        [JsonProperty("audio_channels")]
        public long AudioChannels { get; set; }

        [JsonProperty("audio_analysis_time")]
        public long AudioAnalysisTime { get; set; }

        [JsonProperty("segmentation_time")]
        public long SegmentationTime { get; set; }

        [JsonProperty("transcription_time")]
        public long TranscriptionTime { get; set; }

        [JsonProperty("diarization_time")]
        public long DiarizationTime { get; set; }

        [JsonProperty("merge_time")]
        public long MergeTime { get; set; }

        [JsonProperty("formatting_time")]
        public long FormattingTime { get; set; }

        [JsonProperty("execution_time")]
        public long ExecutionTime { get; set; }
    }

    public partial class Transcript
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("speaker")]
        public Speaker Speaker { get; set; }

        [JsonProperty("start")]
        public double Start { get; set; }

        [JsonProperty("end")]
        public double End { get; set; }
    }

    public partial class WelcomeStatistics
    {
        [JsonProperty("request_processing_time")]
        public long RequestProcessingTime { get; set; }

        [JsonProperty("content_fetch_time")]
        public long[] ContentFetchTime { get; set; }

        [JsonProperty("job_preparation_time")]
        public long JobPreparationTime { get; set; }

        [JsonProperty("audio_analysis_time")]
        public long AudioAnalysisTime { get; set; }

        [JsonProperty("segmentation_time")]
        public long SegmentationTime { get; set; }

        [JsonProperty("transcription_time")]
        public long TranscriptionTime { get; set; }

        [JsonProperty("diarization_time")]
        public long DiarizationTime { get; set; }

        [JsonProperty("merge_time")]
        public long MergeTime { get; set; }

        [JsonProperty("formatting_time")]
        public long FormattingTime { get; set; }
    }

    public enum Speaker { The1, The2 };

    public partial class LatticeAuxiliar
    {
        public static LatticeAuxiliar FromJson(string json) => JsonConvert.DeserializeObject<LatticeAuxiliar>(json, Converter.Settings);
    }

    static class SpeakerExtensions
    {
        public static Speaker? ValueForString(string str)
        {
            switch (str)
            {
                case "1": return Speaker.The1;
                case "2": return Speaker.The2;
                default: return null;
            }
        }

        public static Speaker ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Speaker value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Speaker.The1: serializer.Serialize(writer, "1"); break;
                case Speaker.The2: serializer.Serialize(writer, "2"); break;
            }
        }
    }

    public static class Serialize
    {
        public static string ToJson(this LatticeAuxiliar self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Speaker) || t == typeof(Speaker?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (t == typeof(Speaker))
                return SpeakerExtensions.ReadJson(reader, serializer);
            if (t == typeof(Speaker?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return SpeakerExtensions.ReadJson(reader, serializer);
            }
            throw new Exception("Unknown type");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var t = value.GetType();
            if (t == typeof(Speaker))
            {
                ((Speaker)value).WriteJson(writer, serializer);
                return;
            }
            throw new Exception("Unknown type");
        }

        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = { new Converter() },
        };
    }
}
