using System;
using System . Collections . Generic;
using System . Windows . Forms;
using Mulaolao . Class;
using System . Data;
using StudentMgr;
using System . Data . SqlClient;

namespace Tangwei
{
    public partial class Qudan : Form
    {
        string date; DataTable qud = new DataTable( );
        public Qudan( string date )
        {
            InitializeComponent( );

            this . date = date;
        }

        public delegate void PassDataBetweenFormHandler( object sender, PassDataWinFormEventArgs e );
        public event PassDataBetweenFormHandler PassDataBetweenForm;

        private void Form2_Load( object sender, EventArgs e )
        {
            GridViewMoHuSelect.SetFilter( gridView1 );
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;

            if ( date . Equals ( DateTime . Now . ToString ( "yyyyMMdd" ) ) )
            {
                qud = SqlHelper . ExecuteDataTable ( "SELECT IBB001,IBB002,IBB003,IBB004,IBB005,IBB006,IBB041,IBB013,IBB036,IBB037,IBB038,IBB039,IBB964,IBB963,IBA003 FROM DCSIBB A, TPADEA B, DCSIBA E WHERE A.IBB003 = B.DEA001 AND A.IBB001 = E.IBA001 AND IBB015 = 'N' AND DEA009 = 'P' AND IBB985 = '0' AND IBA003 > '20160125' AND IBB023 = 'T'" );
            }
            else
            {
                qud = SqlHelper . ExecuteDataTable ( "SELECT IBB001,IBB002,IBB003,IBB004,IBB005,IBB006,IBB041,IBB013,IBB036,IBB037,IBB038,IBB039,IBB964,IBB963,IBA003 FROM DCSIBB A, TPADEA B, DCSIBA E WHERE A.IBB003 = B.DEA001 AND A.IBB001 = E.IBA001 AND IBB015 = 'N' AND DEA009 = 'P' AND IBB985 = '0' AND  IBA003 > '20160125' AND IBB023 = 'T' AND IBA003=@IBA003 " ,new SqlParameter ( "@IBA003" ,date ) );
            }
            qud . Columns . Add ( "check" ,System . Type . GetType ( "System.Boolean" ) );
            gridControl1 . DataSource = qud;
            this. StartPosition = FormStartPosition . CenterScreen;
        }

        //确定
        public Dictionary<string, List<string>> str = new Dictionary<string,  List<string>>( );
        private void button2_Click ( object sender ,EventArgs e )
        {
            List<string> strList = null;
            string valu = string . Empty, val = string . Empty, vals = string . Empty;
            for ( int i = 0 ; i < gridView1 . RowCount ; i++ )
            {
                if ( gridView1 . GetDataRow ( i ) [ "check" ] . ToString ( ) == "True" )
                {
                     valu = gridView1 . GetRowCellValue ( i ,"IBA003" ) . ToString ( );
                     val = gridView1 . GetRowCellValue ( i ,"IBB001" ) . ToString ( );
                     vals = gridView1 . GetRowCellValue ( i ,"IBB002" ) . ToString ( );
                    if ( str . ContainsKey ( val ) == false )
                    {
                        strList = new List<string> ( );
                        strList . Add ( vals );
                        str . Add ( val ,strList );
                    }
                    else
                    {
                        strList . Add ( vals );
                        str [ val ] = strList;
                    }
                }
            }

            this . DialogResult = DialogResult . OK;
        }
        //取消
        private void button3_Click( object sender, EventArgs e )
        {
            this . DialogResult = DialogResult . Cancel;
        }
        //取消全选
        private void button1_Click( object sender, EventArgs e )
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.GetDataRow( i )["check"].ToString()=="True")
                {
                    gridView1.GetDataRow( i )["check"] = false;
                }
            }
        }
        //全选
        private void button4_Click( object sender, EventArgs e )
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                gridView1.GetDataRow( i )["check"] = true;
            }
        }
    }
}
