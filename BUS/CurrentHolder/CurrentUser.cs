    using DAL.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace BUS.CurrentHolder
    {
        public class CurrentUser
        {
            private static NhanVien _currentNhanvien;

            public static NhanVien CurrentNhavien
            {
                get { return _currentNhanvien; }
                private set { _currentNhanvien = value; }
            }

            public static void SetCurrentUser(NhanVien nv)
            {
                CurrentNhavien = nv;
            }

            public static void ClearCurrentUser()
            {
                CurrentNhavien = null;
            }
        }
    }
