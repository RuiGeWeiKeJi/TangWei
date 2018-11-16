using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Mulaolao.Class
{
    public class PassDataWinFormEventArgs : EventArgs
    {
        //

        private string _conOne;
        private string _conTwo;
        private string _conTre;
        private string _conFor;
        private string _conFiv;
        private string _conSix;
        private string _conSev;
        private string _conEgi;
        private string _conNin;
        private string _conTen;
        private string _conEleven;
        private string _conTwelve;
        private string _conThirteen;
        private string _conFourteen;
        public DataTable _tabOne;

        public string ConOne
        {
            get { return _conOne; }
            set { _conOne = value; }
        }
        public string ConTwo
        {
            get { return _conTwo; }
            set { _conTwo = value; }
        }
        public string ConTre
        {
            get { return _conTre; }
            set { _conTre = value; }
        }
        public string ConFor
        {
            get { return _conFor; }
            set { _conFor = value; }
        }
        public string ConFiv
        {
            get { return _conFiv; }
            set { _conFiv = value; }
        }
        public string ConSix
        {
            get
            {
                return _conSix;
            }
            set
            {
                _conSix = value;
            }
        }
        public string ConSev
        {
            get
            {
                return _conSev;
            }
            set
            {
                _conSev = value;
            }
        }
        public string ConEgi
        {
            get
            {
                return _conEgi;
            }
            set
            {
                _conEgi = value;
            }
        }
        public string ConNin
        {
            get
            {
                return _conNin;
            }
            set
            {
                _conNin = value;
            }
        }
        public string ConTen
        {
            get
            {
                return _conTen;
            }
            set
            {
                _conTen = value;
            }
        }
        public string ConEleven
        {
            get
            {
                return _conEleven;
            }
            set
            {
                _conEleven = value;
            }
        }
        public string ConTwelve
        {
            get
            {
                return _conTwelve;
            }
            set
            {
                _conTwelve = value;
            }
        }
        public string ConThirteen
        {
            get
            {
                return _conThirteen;
            }
            set
            {
                _conThirteen = value;
            }
        }
        public string ConFourteen
        {
            get
            {
                return _conFourteen;
            }
            set
            {
                _conFourteen = value;
            }
        }
        public DataTable TabOne
        {
            get
            {
                return _tabOne;
            }
            set
            {
                _tabOne = value;
            }
        }

        public PassDataWinFormEventArgs()
        {
        }
        public PassDataWinFormEventArgs(string conOne)
        {
            this._conOne = conOne;
        }
        public PassDataWinFormEventArgs( DataTable tabOne )
        {
            this._tabOne = tabOne;
        }
        public PassDataWinFormEventArgs(string conOne,string conTwo)
        {
            this._conOne = conOne;
            this._conTwo = conTwo;
        }
        public PassDataWinFormEventArgs(string conOne, string conTwo, string conTre)
        {
            this._conOne = conOne;
            this._conTwo = conTwo;
            this._conTre = conTre;
        }
        public PassDataWinFormEventArgs(string conOne, string conTwo, string conTre, string conFor)
        {
            this._conOne = conOne;
            this._conTwo = conTwo;
            this._conTre = conTre;
            this._conFor = conFor;
        }
        public PassDataWinFormEventArgs(string conOne, string conTwo, string conTre, string conFor, string conFiv)
        {
            this._conOne = conOne;
            this._conTwo = conTwo;
            this._conTre = conTre;
            this._conFor = conFor;
            this._conFiv = conFiv;
        }
        public PassDataWinFormEventArgs( string conOne, string conTwo, string conTre, string conFor, string conFiv,string conSix )
        {
            this._conOne = conOne;
            this._conTwo = conTwo;
            this._conTre = conTre;
            this._conFor = conFor;
            this._conFiv = conFiv;
            this._conSix = conSix;
        }
        public PassDataWinFormEventArgs( string conOne, string conTwo, string conTre, string conFor, string conFiv,string conSix,string conSev )
        {
            this._conOne = conOne;
            this._conTwo = conTwo;
            this._conTre = conTre;
            this._conFor = conFor;
            this._conFiv = conFiv;
            this._conSix = conSix;
            this._conSev = conSev;
        }
        public PassDataWinFormEventArgs( string conOne, string conTwo, string conTre, string conFor, string conFiv, string conSix, string conSev, string conEgi )
        {
            this._conOne = conOne;
            this._conTwo = conTwo;
            this._conTre = conTre;
            this._conFor = conFor;
            this._conFiv = conFiv;
            this._conSix = conSix;
            this._conSev = conSev;
            this._conEgi = conEgi;
        }
        public PassDataWinFormEventArgs( string conOne, string conTwo, string conTre, string conFor, string conFiv, string conSix, string conSev,string conEgi,string conNin )
        {
            this._conOne = conOne;
            this._conTwo = conTwo;
            this._conTre = conTre;
            this._conFor = conFor;
            this._conFiv = conFiv;
            this._conSix = conSix;
            this._conSev = conSev;
            this._conEgi = conEgi;
            this._conNin = conNin;
        }
        public PassDataWinFormEventArgs( string conOne, string conTwo, string conTre, string conFor, string conFiv, string conSix, string conSev, string conEgi, string conNin, string conTen, string conEleven, string conTwelve)
        {
            this._conOne = conOne;
            this._conTwo = conTwo;
            this._conTre = conTre;
            this._conFor = conFor;
            this._conFiv = conFiv;
            this._conSix = conSix;
            this._conSev = conSev;
            this._conEgi = conEgi;
            this._conNin = conNin;
            this._conTen = conTen;
            this._conEleven = conEleven;
            this._conTwelve = conTwelve;
        }
        public PassDataWinFormEventArgs( string conOne, string conTwo, string conTre, string conFor, string conFiv, string conSix, string conSev, string conEgi, string conNin, string conTen, string conEleven, string conTwelve, string conThirteen)
        {
            this._conOne = conOne;
            this._conTwo = conTwo;
            this._conTre = conTre;
            this._conFor = conFor;
            this._conFiv = conFiv;
            this._conSix = conSix;
            this._conSev = conSev;
            this._conEgi = conEgi;
            this._conNin = conNin;
            this._conTen = conTen;
            this._conEleven = conEleven;
            this._conTwelve = conTwelve;
            this._conThirteen = conThirteen;
        }
        public PassDataWinFormEventArgs( string conOne, string conTwo, string conTre, string conFor, string conFiv, string conSix, string conSev, string conEgi, string conNin,string conTen,string conEleven,string conTwelve,string conThirteen,string conFourteen )
        {
            this._conOne = conOne;
            this._conTwo = conTwo;
            this._conTre = conTre;
            this._conFor = conFor;
            this._conFiv = conFiv;
            this._conSix = conSix;
            this._conSev = conSev;
            this._conEgi = conEgi;
            this._conNin = conNin;
            this._conTen = conTen;
            this._conEleven = conEleven;
            this._conTwelve = conTwelve;
            this._conThirteen = conThirteen;
            this._conFourteen = conFourteen;
        }

    }  
}
