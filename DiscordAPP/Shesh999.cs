using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordAPP
{
    public partial class Shesh999 : DevExpress.XtraEditors.XtraForm
    {
        public Shesh999()
        {
            InitializeComponent();
        }
        public static void GetMP3(string url, string name)
        {
            var dir = Path.Combine(Directory.GetCurrentDirectory(), "999EPsesh");
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            new WebClient().DownloadFile(url, Path.Combine(dir, name + ".mp3"));
        }
        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //GetMP3("https://mega.nz/329c3046-1052-49ac-8267-7b6253b42f1f", "JUICE");
        }

        private void comboBoxEdit2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit2.SelectedIndex == 0)
            {
                GetMP3("https://www.dropbox.com/s/z6vqwbo3e5nvnsx/2MININHELL.mp3?dl=1", "2MININHELL");
            }
            if(comboBoxEdit2.SelectedIndex == 1)
            {
                GetMP3("https://www.dropbox.com/s/0ll5hojgzmbbypg/5AM.mp3?dl=1", "5AM");
            }
            if (comboBoxEdit2.SelectedIndex == 2)
            {
                GetMP3("https://www.dropbox.com/s/izwdt8edr6s69ku/2023-01-19%20-%2030%20Hrs%20Freestyle.mp3?dl=1", "30 Hrs Freestyle");
            }
            if (comboBoxEdit2.SelectedIndex == 3)
            {
                GetMP3("https://www.dropbox.com/s/geew8pma6pwjy5c/2017%20Freestyle%20%28Buckle%20My%20Shoe%29.mp3?dl=1", "2017 Freestyle (Buckle My Shoe)");
            }
            if (comboBoxEdit2.SelectedIndex == 4)
            {
                GetMP3("https://www.dropbox.com/s/wmapw5yogaoznk8/2023-01-19%20-%20Act%20Right%20%28feat.%20GDo%29.mp3?dl=1", "Act Right (feat. GDo)");
            }
            if (comboBoxEdit2.SelectedIndex == 5)
            {
                GetMP3("https://www.dropbox.com/s/zddf6mid38ttda6/2023-01-19%20-%20All%20Burnt%20Up.mp3?dl=1", "All Burnt Up");
            }
            if (comboBoxEdit2.SelectedIndex == 6)
            {
                GetMP3("https://www.dropbox.com/s/ne57yhcoj3blai2/2023-01-19%20-%20Autograph%20%28v1%29.mp3?dl=1", "Autograph (v1)");
            }
            if (comboBoxEdit2.SelectedIndex == 7)
            {
                GetMP3("https://www.dropbox.com/s/ik0n7mrrcvifuri/2023-01-19%20-%20Blurred%20Vision.mp3?dl=1", "Blurred Vision");
            }
            if (comboBoxEdit2.SelectedIndex == 8)
            {
                GetMP3("https://www.dropbox.com/s/azw5oxusufyg6fp/2023-01-19%20-%20Can%27t%20Feel%20My%20Face.mp3?dl=1", "Can't Feel My Face");
            }
            if (comboBoxEdit2.SelectedIndex == 9)
            {
                GetMP3("https://www.dropbox.com/s/l3rcd2it5dtf9fz/2023-01-19%20-%20Chop%20A%20Brick%20%28v2%29.mp3?dl=1", "Chop A Brick (v2)");
            }
            if (comboBoxEdit2.SelectedIndex == 10)
            {
                GetMP3("https://www.dropbox.com/s/xorp620wjw59ofr/2023-01-19%20-%20Comin%20Over.mp3?dl=1", "Comin Over");
            }
            if (comboBoxEdit2.SelectedIndex == 11)
            {
                GetMP3("https://www.dropbox.com/s/81jxs5fouepujsi/2023-01-19%20-%20Coupe.mp3?dl=1", "Coupe");
            }
            if (comboBoxEdit2.SelectedIndex == 12)
            {
                GetMP3("https://www.dropbox.com/s/bzic1z203bs8fjg/2023-01-19%20-%20Cruisin.mp3?dl=1", "Cruisin");
            }
            if (comboBoxEdit2.SelectedIndex == 13)
            {
                GetMP3("https://www.dropbox.com/s/lou3v9dz63b138x/2023-01-19%20-%20Don%27t%20Know%20What%20I%27m%20On%20%28v1%29.mp3?dl=1", "Don't Know What I'm On (v1)");
            }
            if (comboBoxEdit2.SelectedIndex == 14)
            {
                GetMP3("https://www.dropbox.com/s/k8gf7rg276qpt3j/2023-01-19%20-%20Don%27t%20Know%20What%20I%27m%20On%20%28v2%29.mp3?dl=1", "Don't Know What I'm On (v2)");
            }
            if (comboBoxEdit2.SelectedIndex == 15)
            {
                GetMP3("https://www.dropbox.com/s/r64iw2iwvcv4cop/2023-01-19%20-%20Dreams.mp3?dl=1", "Dreams");
            }
            if (comboBoxEdit2.SelectedIndex == 16)
            {
                GetMP3("https://www.dropbox.com/s/eywba1ms9u8i5hi/2023-01-19%20-%20Drunk%20%28Pt.%202%29.mp3?dl=1", "Drunk (Pt. 2)");
            }
            if (comboBoxEdit2.SelectedIndex == 17)
            {
                GetMP3("https://www.dropbox.com/s/by7g3lbrt6zoxab/2023-01-19%20-%20Fallback.mp3?dl=1", "Fallback");
            }
            if (comboBoxEdit2.SelectedIndex == 18)
            {
                GetMP3("https://www.dropbox.com/s/0mvscvjbbyp28i7/2023-01-19%20-%20Forever%20PT.%202%20%28feat.%20JBucks%29%202.mp3?dl=1", "Forever PT. 2 (feat. JBucks) 2");
            }
            if (comboBoxEdit2.SelectedIndex == 19)
            {
                GetMP3("https://www.dropbox.com/s/k1nej4r6j08odfh/2023-01-19%20-%20Go%20Home.mp3?dl=1", "Go Home");
            }
            if (comboBoxEdit2.SelectedIndex == 20)
            {
                GetMP3("https://www.dropbox.com/s/6o3p2338ugzjyqr/2023-01-19%20-%20Go.mp3?dl=1", "Go");
            }
            if (comboBoxEdit2.SelectedIndex == 21)
            {
                GetMP3("https://www.dropbox.com/s/qjuxsxz8oq9sasq/2023-01-19%20-%20Going%20Crazy.mp3?dl=1", "Going Crazy");
            }
            if (comboBoxEdit2.SelectedIndex == 22)
            {
                GetMP3("https://www.dropbox.com/s/d4z29pquxwhy3dt/2023-01-19%20-%20Hell.mp3?dl=1", "Hell");
            }
            if (comboBoxEdit2.SelectedIndex == 23)
            {
                GetMP3("https://www.dropbox.com/s/rx9ye5tvkmprtj4/2023-01-19%20-%20Hollywood%20Dreams.mp3?dl=1", "Hollywood Dreams");
            }
            if (comboBoxEdit2.SelectedIndex == 24)
            {
                GetMP3("https://www.dropbox.com/s/nh3woo3tojljvdq/How%20Dat%20Go.mp3?dl=1", "How Dat Go");
            }
            if (comboBoxEdit2.SelectedIndex == 25)
            {
                GetMP3("https://www.dropbox.com/s/ax2m9x4h9zw7cfz/2023-01-19%20-%20I%20Know%20One%20Thing.mp3?dl=1", "I Know One Thing");
            }
            if (comboBoxEdit2.SelectedIndex == 26)
            {
                GetMP3("https://www.dropbox.com/s/pzo5uj5xbvajto5/2023-01-19%20-%20I%20Love%20It.mp3?dl=1", "I Love It");
            }
            if (comboBoxEdit2.SelectedIndex == 27)
            {
                GetMP3("https://www.dropbox.com/s/n5o8ff9m0is5hnd/2023-01-19%20-%20Im%20Da%20Shixx.mp3?dl=1", "Im Da Shixx");
            }
            if (comboBoxEdit2.SelectedIndex == 28)
            {
                GetMP3("https://www.dropbox.com/s/l1ujbqi1nbf2p46/2023-01-19%20-%20Juice%20Never%20Have%20To%20Flex.mp3?dl=1", "Juice Never Have To Flex");
            }
            if (comboBoxEdit2.SelectedIndex == 29)
            {
                GetMP3("https://www.dropbox.com/s/yw7ddmvze2cmmh5/2023-01-19%20-%20Just%20Letting%20You%20Know.mp3?dl=1", "Just Letting You Know");
            }
            if (comboBoxEdit2.SelectedIndex == 30)
            {
                GetMP3("https://www.dropbox.com/s/9sm48yd6jlyi19b/2023-01-19%20-%20Let%20Em%20Know.mp3?dl=1", "Let Em Know");
            }
            if (comboBoxEdit2.SelectedIndex == 31)
            {
                GetMP3("https://www.dropbox.com/s/4jvy1epp6fskohe/2023-01-19%20-%20Let%20Me%20Know%20%28v1%29.mp3?dl=1", "Let Me Know (v1)");
            }
            if (comboBoxEdit2.SelectedIndex == 32)
            {
                GetMP3("https://www.dropbox.com/s/zxnp6i6f0ulyget/2023-01-19%20-%20Let%20Me%20Know%20%28v2%29.mp3?dl=1", "Let Me Know (v2)");
            }
            if (comboBoxEdit2.SelectedIndex == 33)
            {
                GetMP3("https://www.dropbox.com/s/6uxv46spxoambf3/2023-01-19%20-%20Lets%20Get%20It.mp3?dl=1", "Lets Get It");
            }
            if (comboBoxEdit2.SelectedIndex == 34)
            {
                GetMP3("https://www.dropbox.com/s/2c3kitbbywag6kv/2023-01-19%20-%20Lost%20Her%20%28v1%29.mp3?dl=1", "Lost Her (v1)");
            }
            if (comboBoxEdit2.SelectedIndex == 35)
            {
                GetMP3("https://www.dropbox.com/s/emrq23d0mnb6tqa/2023-01-19%20-%20Lost%20My%20Mind%20%28Freestyle%29%20%28v1%29.mp3?dl=1", "Lost My Mind (Freestyle) (v1)");
            }
            if (comboBoxEdit2.SelectedIndex == 36)
            {
                GetMP3("https://www.dropbox.com/s/f0qbtm4nhe1ux2m/2023-01-19%20-%20Love%20No%20Hoe.mp3?dl=1", "Love No Hoe");
            }
            if (comboBoxEdit2.SelectedIndex == 37)
            {
                GetMP3("https://www.dropbox.com/s/ylob7fmc3yodzcc/2023-01-19%20-%20Make%20It%20Sell.mp3?dl=1", "Make It Sell");
            }
            if (comboBoxEdit2.SelectedIndex == 38)
            {
                GetMP3("https://www.dropbox.com/s/1qmfqihnlytihv8/2023-01-19%20-%20Man%20Man.mp3?dl=1", "Man Man");
            }
            if (comboBoxEdit2.SelectedIndex == 39)
            {
                GetMP3("https://www.dropbox.com/s/gqacrzkvnhqe72a/2023-01-19%20-%20Matrix.mp3?dl=1", "Matrix");
            }
            if (comboBoxEdit2.SelectedIndex == 40)
            {
                GetMP3("https://www.dropbox.com/s/5hifx30650jdipv/2023-01-19%20-%20Me%20%28v1%29.mp3?dl=1", "Me (v1)");
            }
            if (comboBoxEdit2.SelectedIndex == 41)
            {
                GetMP3("https://www.dropbox.com/s/actpa2pymsi3rn9/2023-01-19%20-%20Midnight.mp3?dl=1", "Midnight");
            }
            if (comboBoxEdit2.SelectedIndex == 42)
            {
                GetMP3("https://www.dropbox.com/s/xrd31vmynepfgb9/2023-01-19%20-%20mmmmm.mp3?dl=1", "mmmmm");
            }
            if (comboBoxEdit2.SelectedIndex == 43)
            {
                GetMP3("https://www.dropbox.com/s/090lvi88cz2pu6e/2023-01-19%20-%20Money%20Hunt.mp3?dl=1", "Money Hunt");
            }
            if (comboBoxEdit2.SelectedIndex == 44)
            {
                GetMP3("https://www.dropbox.com/s/4warkrbhej6mkpt/2023-01-19%20-%20Moonlight%20%28v1%29.mp3?dl=1", "Moonlight (v1)");
            }
            if (comboBoxEdit2.SelectedIndex == 45)
            {
                GetMP3("https://www.dropbox.com/s/5oxdttrx0nt62c0/2023-01-19%20-%20Moves.mp3?dl=1", "Moves");
            }
            if (comboBoxEdit2.SelectedIndex == 46)
            {
                GetMP3("https://www.dropbox.com/s/ckemh54mkbnazrr/2023-01-19%20-%20My%20Zone.mp3?dl=1", "My Zone");
            }
            if (comboBoxEdit2.SelectedIndex == 47)
            {
                GetMP3("https://www.dropbox.com/s/g84d2qw8lw7wn6v/2023-01-19%20-%20New%20Finesse%20%28feat.%20Zay%20Loco%29.mp3?dl=1", "New Finesse (feat. Zay Loco)");
            }
            if (comboBoxEdit2.SelectedIndex == 48)
            {
                GetMP3("https://www.dropbox.com/s/fth0nnkkvjlc1ty/2023-01-19%20-%20No%20Love%20No%20Trust%20999.mp3?dl=1", "No Love No Trust 999");
            }
            if (comboBoxEdit2.SelectedIndex == 49)
            {
                GetMP3("https://www.dropbox.com/s/wbyq67dnkqyh75i/2023-01-19%20-%20No%20Promo.mp3?dl=1", "No Promo");
            }
            if (comboBoxEdit2.SelectedIndex == 50)
            {
                GetMP3("https://www.dropbox.com/s/b69813mbatwrodj/2023-01-19%20-%20No%20Reason.mp3?dl=1", "No Reason");
            }
            if (comboBoxEdit2.SelectedIndex == 51)
            {
                GetMP3("https://www.dropbox.com/s/kj1wbk8mw5jpcvm/2023-01-19%20-%20No%20Vanity.mp3?dl=1", "No Vanity");
            }
            if (comboBoxEdit2.SelectedIndex == 51)
            {
                GetMP3("https://www.dropbox.com/s/w7mptu2mskfo3w4/2023-01-19%20-%20Oh%20No.mp3?dl=1", "Oh No");
            }
            if (comboBoxEdit2.SelectedIndex == 52)
            {
                GetMP3("https://www.dropbox.com/s/269zr006b2196ci/2023-01-19%20-%20Ohh%20My%20Ohh%20My.mp3?dl=1", "Ohh My Ohh My");
            }
            if (comboBoxEdit2.SelectedIndex == 53)
            {
                GetMP3("https://www.dropbox.com/s/269zr006b2196ci/2023-01-19%20-%20Ohh%20My%20Ohh%20My.mp3?dl=1", "OK");
            }
            if (comboBoxEdit2.SelectedIndex == 53)
            {
                GetMP3("https://www.dropbox.com/s/ew4gmo95wuhywdb/2023-01-19%20-%20Old%20Me%20%28v1%29.mp3?dl=1", "Old Me (v1)");
            }
            if (comboBoxEdit2.SelectedIndex == 54)
            {
                GetMP3("https://www.dropbox.com/s/ioeo7kxq9iaw8bq/2023-01-19%20-%20Pesos.mp3?dl=1", "Pesos");
            }
            if (comboBoxEdit2.SelectedIndex == 55)
            {
                GetMP3("https://www.dropbox.com/s/4ju4a531fxekel0/2023-01-19%20-%20Prime.mp3?dl=1", "Prime");
            }
            if (comboBoxEdit2.SelectedIndex == 56)
            {
                GetMP3("https://www.dropbox.com/s/p3b9n7d0h3g6it4/2023-01-19%20-%20Realize.mp3?dl=1", "Realize");
            }
            if (comboBoxEdit2.SelectedIndex == 57)
            {
                GetMP3("https://www.dropbox.com/s/pro2zhedhu15c82/2023-01-19%20-%20Rock.mp3?dl=1", "Rock");
            }
            if (comboBoxEdit2.SelectedIndex == 58)
            {
                GetMP3("https://www.dropbox.com/s/3ligq95og9t8q63/2023-01-19%20-%20Slowly.mp3?dl=1", "Slowly");
            }
            if (comboBoxEdit2.SelectedIndex == 59)
            {
                GetMP3("https://www.dropbox.com/s/71bxl99vsbnhdp6/2023-01-19%20-%20Somethin%20New.mp3?dl=0", "Somethin New");
            }
            if (comboBoxEdit2.SelectedIndex == 60)
            {
                GetMP3("https://www.dropbox.com/s/z227d9z697dzgte/2023-01-19%20-%20Take%20No%20Chance.mp3?dl=1", "Take No Chance");
            }
            if (comboBoxEdit2.SelectedIndex == 61)
            {
                GetMP3("https://www.dropbox.com/s/61s2rhzh5lqyw4g/2023-01-19%20-%20Taste%20The%20Rainbow.mp3?dl=1", "Taste The Rainbow");
            }
            if (comboBoxEdit2.SelectedIndex == 62)
            {
                GetMP3("https://www.dropbox.com/s/kn4cioyt35ms8ca/2023-01-19%20-%20Telepathy%20%28Pt.%202%29.mp3?dl=1", "Telepathy (Pt. 2)");
            }
            if (comboBoxEdit2.SelectedIndex == 63)
            {
                GetMP3("https://www.dropbox.com/s/3ha1x2i5wywgv4k/2023-01-19%20-%20Telepathy%20Freestyle%20%28Pt.%201%29.mp3?dl=1", "Telepathy Freestyle (Pt. 1)");
            }
            if (comboBoxEdit2.SelectedIndex == 64)
            {
                GetMP3("https://www.dropbox.com/s/nic8qcibtjcqo0u/2023-01-19%20-%20This%20Can%27t%20Be%20Happening.mp3?dl=1", "This Can't Be Happening");
            }
            if (comboBoxEdit2.SelectedIndex == 65)
            {
                GetMP3("https://www.dropbox.com/s/745t3n5g9yl6oq5/2023-01-19%20-%20Till%20It%27s%20Over.mp3?dl=1", "Till It's Over");
            }
            if (comboBoxEdit2.SelectedIndex == 66)
            {
                GetMP3("https://www.dropbox.com/s/iwvun5cxfyq6d7m/2023-01-19%20-%20Too%20Much%20Cash.mp3?dl=1", "Too Much Cash");
            }
            if (comboBoxEdit2.SelectedIndex == 67)
            {
                GetMP3("https://www.dropbox.com/s/nic8qcibtjcqo0u/2023-01-19%20-%20This%20Can%27t%20Be%20Happening.mp3?dl=1", "Too Smooth");
            }
            if (comboBoxEdit2.SelectedIndex == 68)
            {
                GetMP3("https://www.dropbox.com/s/v9s8m0bgpuiizh2/2023-01-19%20-%20Tuff%20Talk.mp3?dl=1", "Tuff Talk");
            }
            if (comboBoxEdit2.SelectedIndex == 69)
            {
                GetMP3("https://www.dropbox.com/s/z60qp9z6di7m2z5/2023-01-19%20-%20TWO%20CUPS.mp3?dl=1", "TWO CUPS");
            }
            if (comboBoxEdit2.SelectedIndex == 70)
            {
                GetMP3("https://www.dropbox.com/s/umgd5ap5azuzw80/2023-01-19%20-%20Your%20Man%20%28feat.%207DSVN%29.mp3?dl=1", "Your Man (feat. 7DSVN)");
            }
        }


        private void pictureEdit1_EditValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
