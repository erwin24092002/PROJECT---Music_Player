using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Music_Player
{

    public class MySongs
    {
        public DataTable Songs;
        
        public MySongs()
        {
            Songs = new DataTable();
            Songs.Columns.Add("id", typeof(int));
            Songs.Columns.Add("name", typeof(string));
            Songs.Columns.Add("singer", typeof(string));
            Songs.Columns.Add("author", typeof(string));
            Songs.Columns.Add("type", typeof(string));
            Songs.Columns.Add("star", typeof(int));
            Songs.Columns.Add("date", typeof(string));

            Songs.Rows.Add(1, "Waiting For You", "MONO", "Nguyễn Việt Hoàng", "VPop", 4, "18/08/2022");
            Songs.Rows.Add(2, "Waiting For Love", "Sten Elfstrom, Ingrid Wallin", "Sebastian Ringler", "USUK", 4, "26/06/2015");
            Songs.Rows.Add(3, "Hào Khí Việt Nam", "Phan Đinh Tùng", "Phan Đinh Tùng", "VPop", 5, "07/08/2021");
            Songs.Rows.Add(4, "Only Love", "Ben Howard", "Ben Howard", "USUK", 3, "1/8/2016");
            Songs.Rows.Add(5, "Way Back Home", "SHAUN", "SHAUN", "KPop", 3, "04/01/2019");
            Songs.Rows.Add(6, "Home", "Michael Bublé", "Michael Bublé", "USUK", 2, "27/08/2009");
            Songs.Rows.Add(7, "Easy On Me", "Adele", "Adele", "USUK", 2, "19/11/2021");
            Songs.Rows.Add(8, "Hãy Trao Cho Anh", "Sơn Tùng MTP", "Sơn Tùng MTP", "VPop", 4, "01/07/2019");
            Songs.Rows.Add(9, "Như Ngày Hôm Qua", "Sơn Tùng MTP", "Sơn Tùng MTP", "VPop", 5, "09/07/2022");
            Songs.Rows.Add(10, "Lối Nhỏ", "Đen Vâu, Phương Anh Đào", "Đen Vâu", "VPop", 5, "21/08/2019");
            Songs.Rows.Add(11, "Deja Vu", "Olivia Rodrigo", "Olivia Rodrigo", "USUK", 2, "01/04/2021");
            Songs.Rows.Add(12, "Look What You Make Me Do", "Taylor Swift", "Taylor Swift", "USUK", 3, "28/08/2017");
            Songs.Rows.Add(13, "We Don't Talk Anymore", "Charlie Puth", "Charlie Puth", "USUK", 3, "03/08/2016");
            Songs.Rows.Add(14, "How Long", "Charlie Puth", "Charlie Puth", "USUK", 2, "19/08/2017");
            Songs.Rows.Add(15, "Pink Venom", "BlackPink", "BlackPink", "KPop", 3, "19/08/2022");
            Songs.Rows.Add(16, "Sóng Gió", "K-ICM, JACK", "JACK", "VPop", 4, "12/07/2019");
            Songs.Rows.Add(17, "Đi Về Nhà", "Đen Vâu, JustaTee", "Hứa Kim Tuyền, Xuân Ty, Đen", "VPop", 5, "18/12/2020");
            Songs.Rows.Add(18, "Đom Đóm", "JACK", "JACK", "VPop", 4, "26/12/2020");
            Songs.Rows.Add(19, "Bạc Phận", "K-ICM, JACK", "JACK", "VPop", 4, "16/04/2019");
            Songs.Rows.Add(20, "Say You Won't Let Go", "James Arthur", "James Arthur", "USUK", 3, "09/09/2016");
            Songs.Rows.Add(21, "Một Triệu Khả Năng", "Christine Welch", "Christine Welch", "CPop", 2, "10/08/2018");
            Songs.Rows.Add(22, "Ai Khổ Vì Ai", "Như Quỳnh", "Thương Linh", "VPop", 3, "29/06/2015");
            Songs.Rows.Add(23, "Renai Circulation", "Namirin", "Namirin", "JPop", 2, "06/07/2017");
            Songs.Rows.Add(24, "Despair", "Leo", "Leo", "CPop", 1, "15/09/2020");
            Songs.Rows.Add(25, "Lấy Chồng Sớm Làm Gì", "HuyR, Tuấn Cry", "Huy R", "VPop", 2, "10/01/2020");
            Songs.Rows.Add(26, "Sài Gòn Đâu Có Lạnh", "Changg, LeWiuy, Ruby V", "Naicon", "VPop", 3, "25/12/2020");
            Songs.Rows.Add(27, "Ái Nộ", "Masew, Khoi Vu", "Masew", "VPop", 3, "30/08/2021");
            Songs.Rows.Add(28, "Là Ai Từ Bỏ, Là Ai Vô Tình", "Nguyễn Hương Ly", "Phúc Chinh", "VPop", 2, "19/11/2021");
            Songs.Rows.Add(29, "Thế Thái", "Nguyễn Hương Ly", "Huỳnh Văn", "VPop", 3, "12/08/2020");
            Songs.Rows.Add(30, "Khuê Mộc Lan", "Nguyễn Hương Ly, Jombie", "Jombie", "VPop", 4, "20/08/2021");
        
        }
    }
}
