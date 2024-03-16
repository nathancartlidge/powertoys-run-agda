using System;
using System.Collections.Generic;
using System.Text;

namespace nthn.Agda
{
    public class AgdaLookup
    {
        public Dictionary<string, string> keyValuePairs = new Dictionary<string, string>()
        {
            // todo: this isn't all the input options - for example, you can type `\gamma` to get `γ`.
            //       i think this is the responsibility of a package called quail - I need to do some digging
            //       to find their keymap as well so i can add it in
            {"eq", "=∼∽≈≋∻∾∿≀≃⋍≂≅ ≌≊≡≣≐≑≒≓≔≕≖≗≘≙≚≛≜≝≞≟≍≎≏≬⋕＝"},
            {"eqn", "≠≁ ≉     ≄  ≇≆  ≢                 ≭    "},
            {"=n", "≠"},
            {"~", "∼～"},
            {"~n", "≁"},
            {"~~", "≈"},
            {"~~n", "≉"},
            {"~~~", "≋"},
            {":~", "∻"},
            {"~-", "≃"},
            {"~-n", "≄"},
            {"-~", "≂"},
            {"~=", "≅"},
            {"~=n", "≇"},
            {"~~-", "≊"},
            {"==", "≡"},
            {"==n", "≢"},
            {"===", "≣"},
            {"=", "＝"},
            {".=", "≐"},
            {".=.", "≑"},
            {":=", "≔"},
            {"=:", "≕"},
            {"=o", "≗"},
            {"(=", "≘"},
            {"and=", "≙"},
            {"or=", "≚"},
            {"*=", "≛"},
            {"t=", "≜"},
            {"def=", "≝"},
            {"m=", "≞"},
            {"?=", "≟"},
            {"leq", "<≪⋘≤≦≲ ≶≺≼≾⊂⊆ ⋐⊏⊑ ⊰⊲⊴⋖⋚⋜⋞＜"},
            {"leqn", "≮  ≰≨≴⋦≸⊀ ⋨⊄⊈⊊  ⋢⋤ ⋪⋬   ⋠"},
            {"geq", ">≫⋙≥≧≳ ≷≻≽≿⊃⊇ ⋑⊐⊒ ⊱⊳⊵⋗⋛⋝⋟＞"},
            {"geqn", "≯  ≱≩≵⋧≹⊁ ⋩⊅⊉⊋  ⋣⋥ ⋫⋭   ⋡"},
            {"<=", "⇐"},
            {">=", "≥"},
            {"<=n", "≰"},
            {">=n", "≱"},
            {"len", "≰"},
            {"gen", "≱"},
            {"<n", "≮"},
            {">n", "≯"},
            {"<~", "≲"},
            {">~", "≳"},
            {"<~n", "⋦"},
            {">~n", "⋧"},
            {"<~nn", "≴"},
            {">~nn", "≵"},
            {"sub", "⊂"},
            {"sup", "⊃"},
            {"subn", "⊄"},
            {"supn", "⊅"},
            {"sub=", "⊆"},
            {"sup=", "⊇"},
            {"sub=n", "⊈"},
            {"sup=n", "⊉"},
            {"squb", "⊏"},
            {"squp", "⊐"},
            {"squb=", "⊑"},
            {"squp=", "⊒"},
            {"squb=n", "⋢"},
            {"squp=n", "⋣"},
            {"member", "∈∉∊∋∌∍⋲⋳⋴⋵⋶⋷⋸⋹⋺⋻⋼⋽⋾⋿"},
            {"inn", "∉"},
            {"nin", "∌"},
            {"intersection", "∩⋂∧⋀⋏⨇⊓⨅⋒∏ ⊼      ⨉"},
            {"union", "∪⋃∨⋁⋎⨈⊔⨆⋓∐⨿⊽⊻⊍⨃⊎⨄⊌∑⅀"},
            {"and", "∧"},
            {"or", "∨"},
            {"And", "⋀"},
            {"Or", "⋁"},
            {"i", "∩"},
            {"un", "∪"},
            {"u+", "⊎"},
            {"u.", "⊍"},
            {"I", "⋂"},
            {"Un", "⋃"},
            {"U+", "⨄"},
            {"U.", "⨃"},
            {"glb", "⊓"},
            {"lub", "⊔"},
            {"Glb", "⨅"},
            {"Lub", "⨆"},
            {"entails", "⊢⊣⊤⊥⊦⊧⊨⊩⊪⊫⊬⊭⊮⊯"},
            {"|-", "⊢"},
            {"|-n", "⊬"},
            {"-|", "⊣"},
            {"|=", "⊨"},
            {"|=n", "⊭"},
            {"||-", "⊩"},
            {"||-n", "⊮"},
            {"||=", "⊫"},
            {"||=n", "⊯"},
            {"|||-", "⊪"},
            {"|", "∣"},
            {"|n", "∤"},
            {"||", "∥"},
            {"||n", "∦"},
            {"all", "∀"},
            {"ex", "∃"},
            {"exn", "∄"},
            {"0", "∅"},
            {"C", "∁"},
            {"c", "⌜⌝⌞⌟⌈⌉⌊⌋"},
            {"cu", "⌜⌝  ⌈⌉  "},
            {"cl", "  ⌞⌟  ⌊⌋"},
            {"cul", "⌜"},
            {"cuL", "⌈"},
            {"cur", "⌝"},
            {"cuR", "⌉"},
            {"cll", "⌞"},
            {"clL", "⌊"},
            {"clr", "⌟"},
            {"clR", "⌋"},
            {"qed", "∎"},
            {"x", "×"},
            {"o", "∘"},
            {"comp", "∘"},
            {".", "∙．"},
            {"*", "＊"},
            {".+", "∔"},
            {".-", "∸"},
            {":", "∶⦂ː꞉˸፥፦：﹕︓"},
            {",", "ʻ،⸲⸴⹁⹉、︐︑﹐﹑，､"},
            {";", "⨾⨟⁏፤꛶；︔﹔⍮⸵;"},
            {"::", "∷"},
            {"::-", "∺"},
            {"-:", "∹"},
            {"+ ", "⊹"},
            {"+", "＋"},
            {"sqrt", "√"},
            {"surd3", "∛"},
            {"surd4", "∜"},
            {"increment", "∆"},
            {"inf", "∞"},
            {"&", "＆"},
            {"z;", "⨟⨾"},
            {"z:", "⦂"},
            {"o+", "⊕"},
            {"o--", "⊖"},
            {"ox", "⊗"},
            {"o/", "⊘"},
            {"o.", "⊙"},
            {"oo", "⊚"},
            {"o*", "⊛"},
            {"o=", "⊜"},
            {"o-", "⊝"},
            {"O+", "⨁"},
            {"Ox", "⨂"},
            {"O.", "⨀"},
            {"O*", "⍟"},
            {"b+", "⊞"},
            {"b-", "⊟"},
            {"bx", "𝕩"},
            {"b.", "⊡"},
            {"box=", "⌸"},
            {"box?", "⍰"},
            {"box'", "⍞"},
            {"box:", "⍠"},
            {"box/", "⍁"},
            {"box\\", "⍂"},
            {"box<", "⍃"},
            {"box>", "⍄"},
            {"boxo", "⌻"},
            {"boxO", "⌼"},
            {"boxcomp", "⌻"},
            {"boxcircle", "⌼"},
            {"boxeq", "⌸"},
            {"boxneq", "⍯"},
            {"boxeqn", "⍯"},
            {"boxl", "⍇"},
            {"boxr", "⍈"},
            {"boxu", "⍐"},
            {"boxd", "⍗"},
            {"boxdi", "⌺"},
            {"boxdiv", "⌹"},
            {"boxwedge", "⍓"},
            {"boxvee", "⍌"},
            {"boxdelta", "⍍"},
            {"boxnabla", "⍔"},
            {"integral", "∫∬∭∮∯∰∱∲∳"},
            {"angle", "∟∡∢⊾⊿"},
            {"join", "⋈⋉⋊⋋⋌⨝⟕⟖⟗"},
            {"l", "←⇐⇚⭅⇇⇆↤⇦↞↼↽⇠⇺↜⇽⟵⟸↚⇍⇷ ↹     ↢↩↫⇋⇜⇤⟻⟽⤆↶↺⟲                                     "},
            {"r", "→⇒⇛⭆⇉⇄↦⇨↠⇀⇁⇢⇻↝⇾⟶⟹↛⇏⇸⇶ ↴    ↣↪↬⇌⇝⇥⟼⟾⤇↷↻⟳⇰⇴⟴⟿ ➵➸➙➔➛➜➝➞➟➠➡➢➣➤➧➨➩➪➫➬➭➮➯➱➲➳➺➻➼➽➾⊸"},
            {"u", "↑⇑⤊⟰⇈⇅↥⇧↟↿↾⇡⇞          ↰↱➦ ⇪⇫⇬⇭⇮⇯                                           "},
            {"d", "↓⇓⤋⟱⇊⇵↧⇩↡⇃⇂⇣⇟         ↵↲↳➥ ↯                                                "},
            {"ud", "↕⇕   ↨⇳                                                                    "},
            {"lr", "↔⇔         ⇼↭⇿⟷⟺↮⇎⇹                                                        "},
            {"ul", "↖⇖                        ⇱↸                                               "},
            {"ur", "↗⇗                                         ➶➹➚                             "},
            {"dr", "↘⇘                        ⇲                ➴➷➘                             "},
            {"dl", "↙⇙                                                                         "},
            {"l-", "←"},
            {"<-", "←"},
            {"l=", "⇐"},
            {"r-", "→"},
            {"->", "→"},
            {"r=", "⇒"},
            {"=>", "⇒"},
            {"u-", "↑"},
            {"u=", "⇑"},
            {"d-", "↓"},
            {"d=", "⇓"},
            {"ud-", "↕"},
            {"ud=", "⇕"},
            {"lr-", "↔"},
            {"<->", "↔"},
            {"lr=", "⇔"},
            {"<=>", "⇔"},
            {"ul-", "↖"},
            {"ul=", "⇖"},
            {"ur-", "↗"},
            {"ur=", "⇗"},
            {"dr-", "↘"},
            {"dr=", "⇘"},
            {"dl-", "↙"},
            {"dl=", "⇙"},
            {"l==", "⇚"},
            {"l-2", "⇇"},
            {"l-r-", "⇆"},
            {"r==", "⇛"},
            {"r-2", "⇉"},
            {"r-3", "⇶"},
            {"r-l-", "⇄"},
            {"u==", "⟰"},
            {"u-2", "⇈"},
            {"u-d-", "⇅"},
            {"d==", "⟱"},
            {"d-2", "⇊"},
            {"d-u-", "⇵"},
            {"l--", "⟵"},
            {"<--", "⟵"},
            {"l~", "↜"},
            {"r--", "⟶"},
            {"-->", "⟶"},
            {"r~", "↝"},
            {"⇝", "⟿"},
            {"lr--", "⟷"},
            {"<-->", "⟷"},
            {"lr~", "↭"},
            {"l-n", "↚"},
            {"<-n", "↚"},
            {"l=n", "⇍"},
            {"r-n", "↛"},
            {"->n", "↛"},
            {"r=n", "⇏"},
            {"=>n", "⇏"},
            {"lr-n", "↮"},
            {"<->n", "↮"},
            {"lr=n", "⇎"},
            {"<=>n", "⇎"},
            {"l-|", "↤"},
            {"ll-", "↞"},
            {"r-|", "↦"},
            {"rr-", "↠"},
            {"u-|", "↥"},
            {"uu-", "↟"},
            {"d-|", "↧"},
            {"dd-", "↡"},
            {"ud-|", "↨"},
            {"l->", "↢"},
            {"r->", "↣"},
            {"r-o", "⊸"},
            {"-o", "⊸"},
            {"dz", "↯"},
            {"...", "⋯⋮⋰⋱"},
            {"---", "─│┌┐└┘├┤┬┼┴╴╵╶╷╭╮╯╰╱╲╳"},
            {"--=", "═║╔╗╚╝╠╣╦╬╩     ╒╕╘╛╞╡╤╪╧ ╓╖╙╜╟╢╥╫╨"},
            {"t", "◂◃◄◅▸▹►▻▴▵▾▿◢◿◣◺◤◸◥◹"},
            {"T", "◀◁▶▷▲△▼▽◬◭◮"},
            {"tb", "◂▸▴▾◄►◢◣◤◥"},
            {"tw", "◃▹▵▿◅▻◿◺◸◹"},
            {"Tb", "◀▶▲▼"},
            {"Tw", "◁▷△▽"},
            {"sq", "■□◼◻◾◽▣▢▤▥▦▧▨▩◧◨◩◪◫◰◱◲◳"},
            {"sqb", "■◼◾"},
            {"sqw", "□◻◽"},
            {"sq.", "▣"},
            {"sqo", "▢"},
            {"re", "▬▭▮▯"},
            {"reb", "▬▮"},
            {"rew", "▭▯"},
            {"pa", "▰▱"},
            {"pab", "▰"},
            {"paw", "▱"},
            {"di", "◆◇◈"},
            {"dib", "◆"},
            {"diw", "◇"},
            {"di.", "◈"},
            {"ci", "●○◎◌◯◍◐◑◒◓◔◕◖◗◠◡◴◵◶◷⚆⚇⚈⚉"},
            {"cib", "●"},
            {"ciw", "○"},
            {"ci.", "◎"},
            {"ci..", "◌"},
            {"ciO", "◯"},
            {"st", "⋆✦✧✶✴✹ ★☆✪✫✯✰✵✷✸"},
            {"st4", "✦✧"},
            {"st6", "✶"},
            {"st8", "✴"},
            {"st12", "✹"},
            {"bA", "𝔸"},
            {"bB", "𝔹"},
            {"bC", "ℂ"},
            {"bD", "𝔻"},
            {"bE", "𝔼"},
            {"bF", "𝔽"},
            {"bG", "𝔾"},
            {"bH", "ℍ"},
            {"bI", "𝕀"},
            {"bJ", "𝕁"},
            {"bK", "𝕂"},
            {"bL", "𝕃"},
            {"bM", "𝕄"},
            {"bN", "ℕ"},
            {"bO", "𝕆"},
            {"bP", "ℙ"},
            {"bQ", "ℚ"},
            {"bR", "ℝ"},
            {"bS", "𝕊"},
            {"bT", "𝕋"},
            {"bU", "𝕌"},
            {"bV", "𝕍"},
            {"bW", "𝕎"},
            {"bX", "𝕏"},
            {"bY", "𝕐"},
            {"bZ", "ℤ"},
            {"bGG", "ℾ"},
            {"bGP", "ℿ"},
            {"bGS", "⅀"},
            {"ba", "𝕒"},
            {"bb", "𝕓"},
            {"bc", "𝕔"},
            {"bd", "𝕕"},
            {"be", "𝕖"},
            {"bf", "𝕗"},
            {"bg", "𝕘"},
            {"bh", "𝕙"},
            {"bi", "𝕚"},
            {"bj", "𝕛"},
            {"bk", "𝕜"},
            {"bl", "𝕝"},
            {"bm", "𝕞"},
            {"bn", "𝕟"},
            {"bo", "𝕠"},
            {"bp", "𝕡"},
            {"bq", "𝕢"},
            {"br", "𝕣"},
            {"bs", "𝕤"},
            {"bt", "𝕥"},
            {"bu", "•◦‣⁌⁍"},
            {"bv", "𝕧"},
            {"bw", "𝕨"},
            {"by", "𝕪"},
            {"bz", "𝕫"},
            {"bGg", "ℽ"},
            {"bGp", "ℼ"},
            {"b0", "𝟘"},
            {"b1", "𝟙"},
            {"b2", "𝟚"},
            {"b3", "𝟛"},
            {"b4", "𝟜"},
            {"b5", "𝟝"},
            {"b6", "𝟞"},
            {"b7", "𝟟"},
            {"b8", "𝟠"},
            {"b9", "𝟡"},
            {"BA", "𝐀"},
            {"BB", "𝐁"},
            {"BC", "𝐂"},
            {"BD", "𝐃"},
            {"BE", "𝐄"},
            {"BF", "𝐅"},
            {"BG", "𝐆"},
            {"BH", "𝐇"},
            {"BI", "𝐈"},
            {"BJ", "𝐉"},
            {"BK", "𝐊"},
            {"BL", "𝐋"},
            {"BM", "𝐌"},
            {"BN", "𝐍"},
            {"BO", "𝐎"},
            {"BP", "𝐏"},
            {"BQ", "𝐐"},
            {"BR", "𝐑"},
            {"BS", "𝐒"},
            {"BT", "𝐓"},
            {"BU", "𝐔"},
            {"BV", "𝐕"},
            {"BW", "𝐖"},
            {"BX", "𝐗"},
            {"BY", "𝐘"},
            {"BZ", "𝐙"},
            {"Ba", "𝐚"},
            {"Bb", "𝐛"},
            {"Bc", "𝐜"},
            {"Bd", "𝐝"},
            {"Be", "𝐞"},
            {"Bf", "𝐟"},
            {"Bg", "𝐠"},
            {"Bh", "𝐡"},
            {"Bi", "𝐢"},
            {"Bj", "𝐣"},
            {"Bk", "𝐤"},
            {"Bl", "𝐥"},
            {"Bm", "𝐦"},
            {"Bn", "𝐧"},
            {"Bo", "𝐨"},
            {"Bp", "𝐩"},
            {"Bq", "𝐪"},
            {"Br", "𝐫"},
            {"Bs", "𝐬"},
            {"Bt", "𝐭"},
            {"Bu", "𝐮"},
            {"Bv", "𝐯"},
            {"Bw", "𝐰"},
            {"Bx", "𝐱"},
            {"By", "𝐲"},
            {"Bz", "𝐳"},
            {"BGA", "𝚨"},
            {"BGB", "𝚩"},
            {"BGC", "𝚾"},
            {"BGD", "𝚫"},
            {"BGE", "𝚬"},
            {"BGG", "𝚪"},
            {"BGH", "𝚮"},
            {"BGI", "𝚰"},
            {"BGK", "𝚱"},
            {"BGL", "𝚲"},
            {"BGM", "𝚳"},
            {"BGN", "𝚴"},
            {"BGO", "𝛀"},
            {"BOmicron", "𝚶"},
            {"BGF", "𝚽"},
            {"BPi", "𝚷"},
            {"BGP", "𝚿"},
            {"BGR", "𝚸"},
            {"BGS", "𝚺"},
            {"BGT", "𝚻"},
            {"BGTH", "𝚯"},
            {"BGU", "𝚼"},
            {"BGX", "𝚵"},
            {"BGZ", "𝚭"},
            {"BGa", "𝛂"},
            {"BGb", "𝛃"},
            {"BGc", "𝛘"},
            {"BGd", "𝛅"},
            {"BGe", "𝛆"},
            {"BGg", "𝛄"},
            {"BGh", "𝛈"},
            {"BGi", "𝛊"},
            {"BGk", "𝛋"},
            {"BGl", "𝛌"},
            {"BGm", "𝛍"},
            {"BGn", "𝛎"},
            {"BGo", "𝛚"},
            {"Bomicron", "𝛐"},
            {"BGf", "𝛗"},
            {"Bpi", "𝛑"},
            {"BGp", "𝛙"},
            {"BGr", "𝛒"},
            {"BGs", "𝛔"},
            {"BGt", "𝛕"},
            {"BGth", "𝛉"},
            {"BGu", "𝛖"},
            {"BGx", "𝛏"},
            {"BGz", "𝛇"},
            {"B0", "𝟎"},
            {"B1", "𝟏"},
            {"B2", "𝟐"},
            {"B3", "𝟑"},
            {"B4", "𝟒"},
            {"B5", "𝟓"},
            {"B6", "𝟔"},
            {"B7", "𝟕"},
            {"B8", "𝟖"},
            {"B9", "𝟗"},
            {"FA", "Ａ"},
            {"FB", "Ｂ"},
            {"FC", "Ｃ"},
            {"FD", "Ｄ"},
            {"FE", "Ｅ"},
            {"FF", "Ｆ"},
            {"FG", "Ｇ"},
            {"FH", "Ｈ"},
            {"FI", "Ｉ"},
            {"FJ", "Ｊ"},
            {"FK", "Ｋ"},
            {"FL", "Ｌ"},
            {"FM", "Ｍ"},
            {"FN", "Ｎ"},
            {"FO", "Ｏ"},
            {"FP", "Ｐ"},
            {"FQ", "Ｑ"},
            {"FR", "Ｒ"},
            {"FS", "Ｓ"},
            {"FT", "Ｔ"},
            {"FU", "Ｕ"},
            {"FV", "Ｖ"},
            {"FW", "Ｗ"},
            {"FX", "Ｘ"},
            {"FY", "Ｙ"},
            {"FZ", "Ｚ"},
            {"Fa", "ａ"},
            {"Fb", "ｂ"},
            {"Fc", "ｃ"},
            {"Fd", "ｄ"},
            {"Fe", "ｅ"},
            {"Ff", "ｆ"},
            {"Fg", "ｇ"},
            {"Fh", "ｈ"},
            {"Fi", "ｉ"},
            {"Fj", "ｊ"},
            {"Fk", "ｋ"},
            {"Fl", "ｌ"},
            {"Fm", "ｍ"},
            {"Fn", "ｎ"},
            {"Fo", "ｏ"},
            {"Fp", "ｐ"},
            {"Fq", "ｑ"},
            {"Fr", "ｒ"},
            {"Fs", "ｓ"},
            {"Ft", "ｔ"},
            {"Fu", "ｕ"},
            {"Fv", "ｖ"},
            {"Fw", "ｗ"},
            {"Fx", "ｘ"},
            {"Fy", "ｙ"},
            {"Fz", "ｚ"},
            {"F0", "０"},
            {"F1", "１"},
            {"F2", "２"},
            {"F3", "３"},
            {"F4", "４"},
            {"F5", "５"},
            {"F6", "６"},
            {"F7", "７"},
            {"F8", "８"},
            {"F9", "９"},
            {"(", "([{⁅⁽₍〈⎴⟅⟦⟨⟪⦃〈《「『【〔〖〚︵︷︹︻︽︿﹁﹃﹙﹛﹝（［｛｢❪❬❰❲❴⟮⦅⦗⧼⸨❮⦇⦉"},
            {")", ")]}⁆⁾₎〉⎵⟆⟧⟩⟫⦄〉》」』】〕〗〛︶︸︺︼︾﹀﹂﹄﹚﹜﹞）］｝｣❫❭❱❳❵⟯⦆⦘⧽⸩❯⦈⦊"},
            {"[[", "⟦"},
            {"]]", "⟧"},
            {"<", "⟨<≪⋘≺⊂⋐⊏⊰⊲⋖＜"},
            {">", "⟩>≫⋙≻⊃⋑⊐⊱⊳⋗＞"},
            {"<<", "⟪"},
            {">>", "⟫"},
            {"{{", "⦃"},
            {"}}", "⦄"},
            {"(b", "⟅"},
            {")b", "⟆"},
            {"lbag", "⟅"},
            {"rbag", "⟆"},
            {"<|", "⦉"},
            {"|>", "⦊"},
            {"(|", "⦇"},
            {"|)", "⦈"},
            {"((", "⦅｟"},
            {"))", "⦆｠"},
            {"'", "′″‴⁗＇"},
            {"`", "‵‶‷｀"},
            {"frac", "¼½¾⅓⅔⅕⅖⅗⅘⅙⅚⅛⅜⅝⅞⅟"},
            {"bub", "•"},
            {"buw", "◦"},
            {"but", "‣"},
            {"note", "♩♪♫♬"},
            {"b", "♭"},
            {"#", "＃"},
            {"\\", "         . ("},
            {"en", "–"},
            {"em", "—"},
            {"!", "¡"},
            {"!!", "‼"},
            {"?", "¿"},
            {"??", "⁇"},
            {"?!", "‽"},
            {"!?", "⁉"},
            {"die", "⚀⚁⚂⚃⚄⚅"},
            {"asterisk", "⁎⁑⁂✢✣✤✥✱✲✳✺✻✼✽❃❉❊❋＊"},
            {"8<", "✂"},
            {"tie", "⁀"},
            {"undertie", "‿"},
            {"%", "％"},
            {"/", "／＼"},
            {"@", "＠"},
            {"__", "＿"},
            {"^--", "̅̿"},
            {"_--", "̲̳"},
            {"^~", "̃͌"},
            {"_~", "̰"},
            {"^.", "̇̈⃛⃜"},
            {"_.", "̣̤"},
            {"^l", "ˡ"},
            {"^l-", "⃖"},
            {"^r", "ʳ"},
            {"^r-", "⃗"},
            {"^lr", "⃡"},
            {"_lr", "͍"},
            {"^^", "̂̑͆"},
            {"_^", "̭̯̪"},
            {"^v", "ᵛ"},
            {"_v", "ᵥ"},
            {"Ga", "α"},
            {"GA", "Α"},
            {"Gb", "β"},
            {"GB", "Β"},
            {"Gg", "γ"},
            {"GG", "Γ"},
            {"Gd", "δ"},
            {"GD", "Δ"},
            {"Ge", "ε"},
            {"GE", "Ε"},
            {"Gz", "ζ"},
            {"GZ", "Ζ"},
            {"Gh", "η"},
            {"GH", "Η"},
            {"Gth", "θ"},
            {"GTH", "Θ"},
            {"Gi", "ι"},
            {"GI", "Ι"},
            {"Gk", "κ"},
            {"GK", "Κ"},
            {"Gl", "λ"},
            {"GL", "Λ"},
            {"Gl-", "ƛ"},
            {"Gm", "μ"},
            {"GM", "Μ"},
            {"Gn", "ν"},
            {"GN", "Ν"},
            {"Gx", "ξ"},
            {"GX", "Ξ"},
            {"Gr", "ρ"},
            {"GR", "Ρ"},
            {"Gs", "σ"},
            {"GS", "Σ"},
            {"Gt", "τ"},
            {"GT", "Τ"},
            {"Gu", "υ"},
            {"GU", "Υ"},
            {"Gf", "φ"},
            {"GF", "Φ"},
            {"Gc", "χ"},
            {"GC", "Χ"},
            {"Gp", "ψ"},
            {"GP", "Ψ"},
            {"Go", "ω"},
            {"GO", "Ω"},
            {"MiA", "𝐴"},
            {"MiB", "𝐵"},
            {"MiC", "𝐶"},
            {"MiD", "𝐷"},
            {"MiE", "𝐸"},
            {"MiF", "𝐹"},
            {"MiG", "𝐺"},
            {"MiH", "𝐻"},
            {"MiI", "𝐼"},
            {"MiJ", "𝐽"},
            {"MiK", "𝐾"},
            {"MiL", "𝐿"},
            {"MiM", "𝑀"},
            {"MiN", "𝑁"},
            {"MiO", "𝑂"},
            {"MiP", "𝑃"},
            {"MiQ", "𝑄"},
            {"MiR", "𝑅"},
            {"MiS", "𝑆"},
            {"MiT", "𝑇"},
            {"MiU", "𝑈"},
            {"MiV", "𝑉"},
            {"MiW", "𝑊"},
            {"MiX", "𝑋"},
            {"MiY", "𝑌"},
            {"MiZ", "𝑍"},
            {"Mia", "𝑎"},
            {"Mib", "𝑏"},
            {"Mic", "𝑐"},
            {"Mid", "𝑑"},
            {"Mie", "𝑒"},
            {"Mif", "𝑓"},
            {"Mig", "𝑔"},
            {"Mih", "ℎ"},
            {"Mii", "𝑖"},
            {"Mij", "𝑗"},
            {"Mik", "𝑘"},
            {"Mil", "𝑙"},
            {"Mim", "𝑚"},
            {"Min", "𝑛"},
            {"Mio", "𝑜"},
            {"Mip", "𝑝"},
            {"Miq", "𝑞"},
            {"Mir", "𝑟"},
            {"Mis", "𝑠"},
            {"Mit", "𝑡"},
            {"Miu", "𝑢"},
            {"Miv", "𝑣"},
            {"Miw", "𝑤"},
            {"Mix", "𝑥"},
            {"Miy", "𝑦"},
            {"Miz", "𝑧"},
            {"MIA", "𝑨"},
            {"MIB", "𝑩"},
            {"MIC", "𝑪"},
            {"MID", "𝑫"},
            {"MIE", "𝑬"},
            {"MIF", "𝑭"},
            {"MIG", "𝑮"},
            {"MIH", "𝑯"},
            {"MII", "𝑰"},
            {"MIJ", "𝑱"},
            {"MIK", "𝑲"},
            {"MIL", "𝑳"},
            {"MIM", "𝑴"},
            {"MIN", "𝑵"},
            {"MIO", "𝑶"},
            {"MIP", "𝑷"},
            {"MIQ", "𝑸"},
            {"MIR", "𝑹"},
            {"MIS", "𝑺"},
            {"MIT", "𝑻"},
            {"MIU", "𝑼"},
            {"MIV", "𝑽"},
            {"MIW", "𝑾"},
            {"MIX", "𝑿"},
            {"MIY", "𝒀"},
            {"MIZ", "𝒁"},
            {"MIa", "𝒂"},
            {"MIb", "𝒃"},
            {"MIc", "𝒄"},
            {"MId", "𝒅"},
            {"MIe", "𝒆"},
            {"MIf", "𝒇"},
            {"MIg", "𝒈"},
            {"MIh", "𝒉"},
            {"MIi", "𝒊"},
            {"MIj", "𝒋"},
            {"MIk", "𝒌"},
            {"MIl", "𝒍"},
            {"MIm", "𝒎"},
            {"MIn", "𝒏"},
            {"MIo", "𝒐"},
            {"MIp", "𝒑"},
            {"MIq", "𝒒"},
            {"MIr", "𝒓"},
            {"MIs", "𝒔"},
            {"MIt", "𝒕"},
            {"MIu", "𝒖"},
            {"MIv", "𝒗"},
            {"MIw", "𝒘"},
            {"MIx", "𝒙"},
            {"MIy", "𝒚"},
            {"MIz", "𝒛"},
            {"McA", "𝒜"},
            {"McB", "ℬ"},
            {"McC", "𝒞"},
            {"McD", "𝒟"},
            {"McE", "ℰ"},
            {"McF", "ℱ"},
            {"McG", "𝒢"},
            {"McH", "ℋ"},
            {"McI", "ℐ"},
            {"McJ", "𝒥"},
            {"McK", "𝒦"},
            {"McL", "ℒ"},
            {"McM", "ℳ"},
            {"McN", "𝒩"},
            {"McO", "𝒪"},
            {"McP", "𝒫"},
            {"McQ", "𝒬"},
            {"McR", "ℛ"},
            {"McS", "𝒮"},
            {"McT", "𝒯"},
            {"McU", "𝒰"},
            {"McV", "𝒱"},
            {"McW", "𝒲"},
            {"McX", "𝒳"},
            {"McY", "𝒴"},
            {"McZ", "𝒵"},
            {"Mca", "𝒶"},
            {"Mcb", "𝒷"},
            {"Mcc", "𝒸"},
            {"Mcd", "𝒹"},
            {"Mce", "ℯ"},
            {"Mcf", "𝒻"},
            {"Mcg", "ℊ"},
            {"Mch", "𝒽"},
            {"Mci", "𝒾"},
            {"Mcj", "𝒿"},
            {"Mck", "𝓀"},
            {"Mcl", "𝓁"},
            {"Mcm", "𝓂"},
            {"Mcn", "𝓃"},
            {"Mco", "ℴ"},
            {"Mcp", "𝓅"},
            {"Mcq", "𝓆"},
            {"Mcr", "𝓇"},
            {"Mcs", "𝓈"},
            {"Mct", "𝓉"},
            {"Mcu", "𝓊"},
            {"Mcv", "𝓋"},
            {"Mcw", "𝓌"},
            {"Mcx", "𝓍"},
            {"Mcy", "𝓎"},
            {"Mcz", "𝓏"},
            {"MCA", "𝓐"},
            {"MCB", "𝓑"},
            {"MCC", "𝓒"},
            {"MCD", "𝓓"},
            {"MCE", "𝓔"},
            {"MCF", "𝓕"},
            {"MCG", "𝓖"},
            {"MCH", "𝓗"},
            {"MCI", "𝓘"},
            {"MCJ", "𝓙"},
            {"MCK", "𝓚"},
            {"MCL", "𝓛"},
            {"MCM", "𝓜"},
            {"MCN", "𝓝"},
            {"MCO", "𝓞"},
            {"MCP", "𝓟"},
            {"MCQ", "𝓠"},
            {"MCR", "𝓡"},
            {"MCS", "𝓢"},
            {"MCT", "𝓣"},
            {"MCU", "𝓤"},
            {"MCV", "𝓥"},
            {"MCW", "𝓦"},
            {"MCX", "𝓧"},
            {"MCY", "𝓨"},
            {"MCZ", "𝓩"},
            {"MCa", "𝓪"},
            {"MCb", "𝓫"},
            {"MCc", "𝓬"},
            {"MCd", "𝓭"},
            {"MCe", "𝓮"},
            {"MCf", "𝓯"},
            {"MCg", "𝓰"},
            {"MCh", "𝓱"},
            {"MCi", "𝓲"},
            {"MCj", "𝓳"},
            {"MCk", "𝓴"},
            {"MCl", "𝓵"},
            {"MCm", "𝓶"},
            {"MCn", "𝓷"},
            {"MCo", "𝓸"},
            {"MCp", "𝓹"},
            {"MCq", "𝓺"},
            {"MCr", "𝓻"},
            {"MCs", "𝓼"},
            {"MCt", "𝓽"},
            {"MCu", "𝓾"},
            {"MCv", "𝓿"},
            {"MCw", "𝔀"},
            {"MCx", "𝔁"},
            {"MCy", "𝔂"},
            {"MCz", "𝔃"},
            {"MfA", "𝔄"},
            {"MfB", "𝔅"},
            {"MfC", "ℭ"},
            {"MfD", "𝔇"},
            {"MfE", "𝔈"},
            {"MfF", "𝔉"},
            {"MfG", "𝔊"},
            {"MfH", "ℌ"},
            {"MfI", "ℑ"},
            {"MfJ", "𝔍"},
            {"MfK", "𝔎"},
            {"MfL", "𝔏"},
            {"MfM", "𝔐"},
            {"MfN", "𝔑"},
            {"MfO", "𝔒"},
            {"MfP", "𝔓"},
            {"MfQ", "𝔔"},
            {"MfR", "ℜ"},
            {"MfS", "𝔖"},
            {"MfT", "𝔗"},
            {"MfU", "𝔘"},
            {"MfV", "𝔙"},
            {"MfW", "𝔚"},
            {"MfX", "𝔛"},
            {"MfY", "𝔜"},
            {"MfZ", "ℨ"},
            {"Mfa", "𝔞"},
            {"Mfb", "𝔟"},
            {"Mfc", "𝔠"},
            {"Mfd", "𝔡"},
            {"Mfe", "𝔢"},
            {"Mff", "𝔣"},
            {"Mfg", "𝔤"},
            {"Mfh", "𝔥"},
            {"Mfi", "𝔦"},
            {"Mfj", "𝔧"},
            {"Mfk", "𝔨"},
            {"Mfl", "𝔩"},
            {"Mfm", "𝔪"},
            {"Mfn", "𝔫"},
            {"Mfo", "𝔬"},
            {"Mfp", "𝔭"},
            {"Mfq", "𝔮"},
            {"Mfr", "𝔯"},
            {"Mfs", "𝔰"},
            {"Mft", "𝔱"},
            {"Mfu", "𝔲"},
            {"Mfv", "𝔳"},
            {"Mfw", "𝔴"},
            {"Mfx", "𝔵"},
            {"Mfy", "𝔶"},
            {"Mfz", "𝔷"},
            {"_a", "ₐ"},
            {"_e", "ₑ"},
            {"_h", "ₕ"},
            {"_i", "ᵢ"},
            {"_j", "ⱼ"},
            {"_k", "ₖ"},
            {"_l", "ₗ"},
            {"_m", "ₘ"},
            {"_n", "ₙ"},
            {"_o", "ₒ"},
            {"_p", "ₚ"},
            {"_r", "ᵣ"},
            {"_s", "ₛ"},
            {"_t", "ₜ"},
            {"_u", "ᵤ"},
            {"_x", "ₓ"},
            {"_Gb", "ᵦ"},
            {"_Gg", "ᵧ"},
            {"_Gr", "ᵨ"},
            {"_Gf", "ᵩ"},
            {"_Gc", "ᵪ"},
            {"^a", "ᵃ"},
            {"^b", "ᵇ"},
            {"^c", "ᶜ"},
            {"^d", "ᵈ"},
            {"^e", "ᵉ"},
            {"^f", "ᶠ"},
            {"^g", "ᵍ"},
            {"^h", "ʰ"},
            {"^i", "ⁱ"},
            {"^j", "ʲ"},
            {"^k", "ᵏ"},
            {"^m", "ᵐ"},
            {"^n", "ⁿ"},
            {"^o", "ᵒ"},
            {"^p", "ᵖ"},
            {"^s", "ˢ"},
            {"^t", "ᵗ"},
            {"^u", "ᵘ"},
            {"^w", "ʷ"},
            {"^x", "ˣ"},
            {"^y", "ʸ"},
            {"^z", "ᶻ"},
            {"^A", "ᴬ"},
            {"^B", "ᴮ"},
            {"^D", "ᴰ"},
            {"^E", "ᴱ"},
            {"^G", "ᴳ"},
            {"^H", "ᴴ"},
            {"^I", "ᴵ"},
            {"^J", "ᴶ"},
            {"^K", "ᴷ"},
            {"^L", "ᴸ"},
            {"^M", "ᴹ"},
            {"^N", "ᴺ"},
            {"^O", "ᴼ"},
            {"^P", "ᴾ"},
            {"^R", "ᴿ"},
            {"^T", "ᵀ"},
            {"^U", "ᵁ"},
            {"^V", "ⱽ"},
            {"^W", "ᵂ"},
            {"^Gb", "ᵝ"},
            {"^Gg", "ᵞ"},
            {"^Gd", "ᵟ"},
            {"^Ge", "ᵋ"},
            {"^Gth", "ᶿ"},
            {"^Gf", "ᵠ"},
            {"^Gc", "ᵡ"},
            {" ", " "},
            {"cent", "¢"},
            {"brokenbar", "¦"},
            {"degree", "°"},
            {"^a_", "ª"},
            {"^o_", "º"},
            {"(0)", " ⓪🄀⓿🄋🄌"},
            {"(1)", "⑴①⒈❶➀➊"},
            {"(2)", "⑵②⒉❷➁➋"},
            {"(3)", "⑶③⒊❸➂➌"},
            {"(4)", "⑷④⒋❹➃➍"},
            {"(5)", "⑸⑤⒌❺➄➎"},
            {"(6)", "⑹⑥⒍❻➅➏"},
            {"(7)", "⑺⑦⒎❼➆➐"},
            {"(8)", "⑻⑧⒏❽➇➑"},
            {"(9)", "⑼⑨⒐❾➈➒"},
            {"(10)", "⑽⑩⒑❿➉➓"},
            {"(11)", "⑾⑪⒒⓫"},
            {"(12)", "⑿⑫⒓⓬"},
            {"(13)", "⒀⑬⒔⓭"},
            {"(14)", "⒁⑭⒕⓮"},
            {"(15)", "⒂⑮⒖⓯"},
            {"(16)", "⒃⑯⒗⓰"},
            {"(17)", "⒄⑰⒘⓱"},
            {"(18)", "⒅⑱⒙⓲"},
            {"(19)", "⒆⑲⒚⓳"},
            {"(20)", "⒇⑳⒛⓴"},
            {"(a)", "⒜Ⓐⓐ🅐🄰🅰"},
            {"(b)", "⒝Ⓑⓑ🅑🄱🅱"},
            {"(c)", "⒞Ⓒⓒ🅒🄲🅲"},
            {"(d)", "⒟Ⓓⓓ🅓🄳🅳"},
            {"(e)", "⒠Ⓔⓔ🅔🄴🅴"},
            {"(f)", "⒡Ⓕⓕ🅕🄵🅵"},
            {"(g)", "⒢Ⓖⓖ🅖🄶🅶"},
            {"(h)", "⒣Ⓗⓗ🅗🄷🅷"},
            {"(i)", "⒤Ⓘⓘ🅘🄸🅸"},
            {"(j)", "⒥Ⓙⓙ🅙🄹🅹"},
            {"(k)", "⒦Ⓚⓚ🅚🄺🅺"},
            {"(l)", "⒧Ⓛⓛ🅛🄻🅻"},
            {"(m)", "⒨Ⓜⓜ🅜🄼🅼"},
            {"(n)", "⒩Ⓝⓝ🅝🄽🅽"},
            {"(o)", "⒪Ⓞⓞ🅞🄾🅾"},
            {"(p)", "⒫Ⓟⓟ🅟🄿🅿"},
            {"(q)", "⒬Ⓠⓠ🅠🅀🆀"},
            {"(r)", "⒭Ⓡⓡ🅡🅁🆁"},
            {"(s)", "⒮Ⓢⓢ🅢🅂🆂"},
            {"(t)", "⒯Ⓣⓣ🅣🅃🆃"},
            {"(u)", "⒰Ⓤⓤ🅤🅄🆄"},
            {"(v)", "⒱Ⓥⓥ🅥🅅🆅"},
            {"(w)", "⒲Ⓦⓦ🅦🅆🆆"},
            {"(x)", "⒳Ⓧⓧ🅧🅇🆇"},
            {"(y)", "⒴Ⓨⓨ🅨🅈🆈"},
            {"(z)", "⒵Ⓩⓩ🅩🅉🆉"}
        };
    };
}