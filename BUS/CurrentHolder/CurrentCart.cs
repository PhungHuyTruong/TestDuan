using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.CurrentHolder
{
    public static class CurrentCart
    {
        private static GioHang _giohang;

        public static GioHang currentcart
        {
            get { return _giohang; }
            private set { _giohang = value; }
        }

        public static void SetCurrentGH(GioHang gh)
        {
            _giohang = gh; // Ensure this updates the static cart reference
        }

        public static void DeleteCurrentGH()
        {
            _giohang = null; // Ensure this sets the cart to null
        }
    }
}
