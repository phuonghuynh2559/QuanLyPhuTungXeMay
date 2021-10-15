using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoanCNPM.DAL;

namespace DoanCNPM
{
    class codexuly
    {

       public static DataClassesTestDataContext db = new DataClassesTestDataContext();

        public static bool kiemtraSDTKH(string sdt)
        {
            KHACHHANG kh = db.KHACHHANGs.SingleOrDefault(k => k.SDT.Equals(sdt));
            if (kh != null)
                return true;
            return false;

        }

        public static bool kTRDoiMK(string userName, string Phanquyen)
        {
            var q = from p in db.NHANVIENs
                    where p.SDT == userName
                    && p.MAPQ == Phanquyen
                    select p;
            if (q.Any())
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public static bool DoiMK(string userName, string Phanquyen,string password )
        {
            if (kTRDoiMK(userName, Phanquyen) == true)
            {
                NHANVIEN tb = db.NHANVIENs.SingleOrDefault(s => s.SDT == userName && s.MAPQ == Phanquyen);
                tb.MatKhau = password;
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }

       

        public static bool checkgiamgia(string ma)
        {
            var ggs = db.GIAMGIAs.Where(x => x.MAGIAMGIA == ma.ToUpper() && x.NGAYBATDAU <= DateTime.Now && x.NGAYKETTHUC >= DateTime.Now);

            if (ggs.Any())
            {
               
                return true;
            }
            else
            {
                return false;
            }

        }
        //Load hình ảnh 
        public static void LoadHinhTabPage()
        {
            ImageList im = new ImageList();
            im.ImageSize = new Size(100, 100);
            #region Load giá trị hình
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\day-ga-thai.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\coga-domino.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\cum-ga-tang-domino-2-day-ga.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\xinhan-spirit-beast-l27.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\kinh-chan-gio-zhipat-v2.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\dia-kingspeed.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\kinh-h2c-tron-1482.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\kinh-gu-motogadget-tron.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\che-ket-nuoc-cnc-titan-cho-yamaha-exciter-155.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\bao-tay-driven-sbk-chinh-hang.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\bao-tay-driven-supermoto.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\op-mat-na-carbon-limited-cho-exciter-155.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\ro-giua-cho-exciter-155.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\bo-co-son-carboncho-ex135.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\kinh-titan-kieu-dang-suzuki.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\binh-dau-inox-salaya.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\van-voi-inox-salaya.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\cot-banh-truoc-inox-salaya-cho-honda-winner.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\gu-inox-salaya-3-canh.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\baga-inox-10-ly-mau-titan-cho-exciter-135.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\phuoc-yss-z-sport-chinh-hang-cho-honda-vario.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\loc-gio-luoi-thep-do-danh-cho-honda.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\bo-thang-dia-rcb-sau-cho-honda-sh.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\bo-noi-bbs-cho-vario-ab.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\sen-phot-rk-428-elo.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\loc-gio-tru-dna-hong-54-chinh-hang.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\loc-gio-tru-dna-hong.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\sen-rk-vang-den-428hsb.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\dia-recto-46t-chinh-hang-cho-exciter-155.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\nhong-mat-troi-15t-cho-honda-winner-sonic.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\mam-rcb-8-cay-chinh-hang-cho-exciter-150-155.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\can-so-2-chieu-cho-exciter-155.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\tham-cao-su-honda-vision.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\dia-recto-42t-chinh-hang-cho-honda-sonic.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\phuoc-nitron-chinh-hang-viet-nam-cho-raider-satria.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\ong-tieu-inox-honda-winner-x.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\baga-tinh-dien-cho-vespa.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\op-po-inox-300i-zhipat-cho-shvn.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\po-4road-2009-hang-chuan-full-co-pat-cho-shvn-2020.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\cuc-keu-tim-xe-honda.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\vo-michelin-city-grip-2.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\vo-metzeler.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\vo-xe-aspira-sportivo.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\vo-xe-goodride.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\vo-xe-camel-pilot.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\vo-xe-goodride-h993.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\vo-xe-camel-563.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\vo-michelin-city-grip-2-10080.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\vo-xe-camel-pilot1.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\vo-xe-aspira-sportivo1.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\chai-duong-bong-dan-ao-goracing-1459.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\nhot-liqui-moly-scooter-race-10w40-100ml.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\nhot-motul-scoote-le-10w40-08l.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\nhot-maxima-full-syn-10w40.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\nhot-repsol-mxr-platium-10w40-1l.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\gulf-western-oil-syn-m-4t-premium-scooter-10w40-08l.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\nhot-gulf-western-oil-syn-m-4t-premium-10w40-1l.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\nhot-gulf-western-oil-syn-m-4t-ester-pao-10w40.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\nuoc-lam-mat-goracing-1201.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\chai-xit-lam-sach-dan-nhua-nham-vo-xe-goracing.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\motul-300v-factory-line-10w40-1l.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\chai-xit-ve-sinh-sen-goracing-8572.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\chai-xit-sen-goracing-848.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\nuoc-lam-mat-liqui-moly-loai-khong-pha-804.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\nhot-wolver-racing-synthetic-10w40-492.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\phu-gia-pha-nhot-liqui-moly-mo-s2.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\phu-gia-tang-toc-liqui-moly-speed-additive.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\dau-suc-dong-co-liqui-moly-engine-flush.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\nhot-hop-so-liqui-moly-racing-scooter-gear-oil.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\motul-scooter-gear-plus-38.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\gang-tay-bao-ho-dai-ngon-mechanix.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\gang-tay-chong-nang-xo-ngon-han-quoc.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\giap-inox-bao-ho-pro-biker-chinh-hang.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\non-bao-hiem-exciter.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\octitanlocmaysatria2.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\octitanlocmaywave.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\octitanlocmaysirius.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\octitanlocmaywinnerx.png"));
            im.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\AnhPhuTungXe\octitanlocmayexciter150.png"));

            #endregion
            From_bán.lv.LargeImageList = im;
        }
    }
}





//mã phụ tùng nó sẽ làm khi chọn 1 mã thì nó sẽ lấy cái mã cũa nó 
/// ngày bàn lấy ngày cũa hệ thống 
/// nhập mã vào thì lấy được cái gái tiền để giảm 
/// đơn giá là khi lấy  từ phụ tùng 
/// thành tiền là khi lấy các đơn giá các món hàng mình sẽ ra là thành tiền
/// 
/// 