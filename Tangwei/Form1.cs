using System;
using System . Data;
using System . Data . SqlClient;
using System . Linq;
using System . Windows . Forms;
using StudentMgr;
using System . Collections . Generic;

namespace Tangwei
{
    public partial class Qingoudan : Form
    {
        public Qingoudan( )
        {
            InitializeComponent( );
        }

        Dictionary<string ,List<string>> strDic = new Dictionary<string ,List<string>> ( );

        private void Form1_Load( object sender, EventArgs e )
        {
            //DataTable dq = SqlHelper.ExecuteDataTable( "SELECT DISTINCT IBB001 FROM DCSIBB WHERE IBB985='1'" );
            //DataTable dw = SqlHelper.ExecuteDataTable( "SELECT DISTINCT HBB962 FROM DCSHBB" );
            //if (dq != null && dq.Rows.Count > 0)
            //{
            //    if (dw != null && dw.Rows.Count > 0)
            //    {
            //        for (int i = 0; i < dq.Rows.Count; i++)
            //        {
            //            if (dw.Select( "HBB962='" + dq.Rows[i]["IBB001"].ToString() + "'" ).Length < 1)
            //            {
            //                SqlHelper.ExecuteNonQuery( "UPDATE DCSIBB SET IBB985='0' WHERE IBB001=@IBB001", new SqlParameter( "@IBB001", dq.Rows[i]["IBB001"].ToString( ) ) );
            //            }
            //         }
            //    }
            //}

            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            dateTimePicker1.Enabled = false;

            DataTable tpadba = SqlHelper.ExecuteDataTable( "SELECT DBA001,DBA002 FROM TPADBA" );
            DataRow row = tpadba.NewRow( );
            row["DBA001"] = "0";
            row["DBA002"] = "- - 请选择 - -";
            tpadba.Rows.InsertAt( row, 0 );
            comboBox1.DataSource = tpadba;
            comboBox1.DisplayMember = "DBA002";
            comboBox1.ValueMember = "DBA001";
            
            DataTable tpadla = SqlHelper.ExecuteDataTable( "SELECT DLA001 FROM TPADLA" );
            DataRow ro = tpadla.NewRow( );
            ro["DLA001"] = "- - 请选择 - -";
            tpadla.Rows.InsertAt( ro, 0 );
            comboBox2.DataSource = tpadla;
            comboBox2.DisplayMember = "DLA001";
        }

        string HBA001 = "", HBA002 = "", HBA004 = "", HBA005 = "", HBA008 = "T";
        DateTime HBA003 = System.DateTime.Now;
        string IBA003 = "", HBB003 = "", HBB004 = "", HBB005 = "", HBB021 = "", HBB008 = "", HBB019 = "", HBB022 = "", HBB960 = "", HBB961 = "", HBB962 = "", HBB963 = "", HBB002 = "000", HBB007 = "",HBB964="";
        decimal HBB017 = 0M, HBB018 = 0M, HBB020 = 0M, HBB023 = 0M, HBB024 = 0M, HBB006 = 0M;

        //取单
        DataTable qud = new DataTable( ) ; Qudan qd = null;
        private void button4_Click( object sender, EventArgs e )
        {
            qd = new Qudan ( dateTimePicker1 . Value . ToString ( "yyyyMMdd" ) );
            if ( qd . ShowDialog ( ) == DialogResult . OK )
            {
                strDic = qd . str;
            }     
        }
        //新增
        private void button1_Click( object sender, EventArgs e )
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            dateTimePicker1.Enabled = true;
            comboBox1.Text = "";
            comboBox2.Text = "";

            HBB002 = "000";
            HBB962 = "";
            comboBox2.Text = "- - 请选择 - -";
            comboBox1.Text = "- - 请选择 - -";
        }
        //保存
        private void button2_Click( object sender, EventArgs e )
        {
            if (comboBox1.Text == "- - 请选择 - -")
            {
                MessageBox.Show( "请选择请购人" );
            }
            else
            {
                if ( strDic . Count < 1)
                {
                    MessageBox.Show( "请选择请购单" );
                }
                else
                {
                    if (comboBox2.Text != "- - 请选择 - -")
                    {
                        HBA002 = comboBox2.Text;
                    }
                    else
                    {
                        HBA002 = "";
                    }

                    HBB024 = 0;
                    HBB023 = 0;
                    HBB022 = "N";
                    HBB008 = "N";
                    
                    int cou = 0;
                    string xuNum = string . Empty;
                    foreach (var lis in strDic )
                    {
                        DataTable da = SqlHelper.ExecuteDataTable( "SELECT * FROM DCSHBA" );
                        if ( da != null && da . Rows . Count > 0 )
                        {
                            if ( da . Select ( "HBA001='" + System . DateTime . Now . ToString ( "yyyyMMdd" ) + "001'" ) . Length > 0 )
                            {
                                var query = da . AsEnumerable ( ) . Select ( t => t . Field<string> ( "HBA001" ) ) . Max ( );
                                HBA001 = ( Convert . ToInt64 ( query ) + 1 ) . ToString ( );
                            }
                            else
                                HBA001 = "" + System . DateTime . Now . ToString ( "yyyyMMdd" ) + "001";
                        }

                        foreach ( string st in strDic [ lis . Key ] )
                        {
                            if ( string . IsNullOrEmpty ( xuNum ) )
                                xuNum = "'" + st + "'";
                            else
                                xuNum = xuNum + "," + "'" + st + "'";
                        }

                        DataTable de = SqlHelper . ExecuteDataTable ( "SELECT IBB001,IBB002,IBB003,IBB004,IBB005,IBB006,IBB041,IBB013,IBB036,IBB037,IBB038,IBB039,IBB964,IBB963,IBB962,IBB961 FROM DCSIBB WHERE IBB001=@IBB001 AND IBB002 IN (" + xuNum + ")" ,new SqlParameter ( "@IBB001" ,lis . Key ) );

                        int count = SqlHelper.ExecuteNonQuery( "INSERT INTO DCSHBA (HBA001,HBA002,HBA003,HBA004,HBA005,HBA008) VALUES (@HBA001,@HBA002,@HBA003,@HBA004,@HBA005,@HBA008)", new SqlParameter( "@HBA001", HBA001 ), new SqlParameter( "@HBA002", HBA002 ), new SqlParameter( "@HBA003", System.DateTime.Now.ToString( "yyyyMMdd" ) ), new SqlParameter( "@HBA004", HBA004 ), new SqlParameter( "@HBA005", HBA005 ), new SqlParameter( "@HBA008", HBA008 ) );

                        if (count < 0)
                        {
                            MessageBox.Show( "请购单单号" + HBA001 + "失败" );
                        }
                        else
                        {

                            if (de != null && de.Rows.Count > 0)
                            {
                               
                                for (int i = 0; i < de.Rows.Count; i++)
                                {
                                    HBB002 = (Convert.ToInt32( HBB002 ) + 1).ToString( );

                                    HBB963 = de.Rows[i]["IBB961"].ToString( );
                                    HBB961 = de.Rows[i]["IBB963"].ToString( );
                                    HBB960 = de.Rows[i]["IBB964"].ToString( );
                                    if (de.Rows[i]["IBB039"].ToString( ) == "")
                                    {
                                        HBB020 = 0M;
                                    }
                                    else
                                    {
                                        HBB020 = Convert.ToDecimal( de.Rows[i]["IBB039"].ToString( ) );
                                    }
                                    HBB019 = de.Rows[i]["IBB038"].ToString( );
                                    if (de.Rows[i]["IBB037"].ToString( ) == "")
                                    {
                                        HBB018 = 0M;
                                    }
                                    else
                                    {
                                        HBB018 = Convert.ToDecimal( de.Rows[i]["IBB037"].ToString( ) );
                                    }
                                    if (de.Rows[i]["IBB036"].ToString( ) == "")
                                    {
                                        HBB017 = 0M;
                                    }
                                    else
                                    {
                                        HBB017 = Convert.ToDecimal( de.Rows[i]["IBB036"].ToString( ) );
                                    }
                                    HBB007 = de.Rows[i]["IBB013"].ToString( );
                                    HBB021 = de.Rows[i]["IBB041"].ToString( );
                                    if (de.Rows[i]["IBB006"].ToString( ) == "")
                                    {
                                        HBB006 = 0;
                                    }
                                    else
                                    {
                                        HBB006 = Convert.ToDecimal( de.Rows[i]["IBB006"].ToString( ) );
                                    }
                                    HBB005 = de.Rows[i]["IBB005"].ToString( );
                                    HBB004 = de.Rows[i]["IBB004"].ToString( );
                                    HBB003 = de.Rows[i]["IBB003"].ToString( );
                                    HBB964 = de . Rows [ i ] [ "IBB962" ] . ToString ( );

                                    cou = SqlHelper . ExecuteNonQuery ( "INSERT INTO DCSHBB (HBB003,HBB004,HBB005,HBB006,HBB021,HBB008,HBB007,HBB017,HBB018,HBB019,HBB020,HBB022,HBB023,HBB024,HBB960,HBB961,HBB962,HBB963,HBB001,HBB002,HBB964) VALUES (@HBB003,@HBB004,@HBB005,@HBB006,@HBB021,@HBB008,@HBB007,@HBB017,@HBB018,@HBB019,@HBB020,@HBB022,@HBB023,@HBB024,@HBB960,@HBB961,@HBB962,@HBB963,@HBB001,@HBB002,@HBB964)" ,new SqlParameter ( "@HBB003" ,HBB003 ) ,new SqlParameter ( "@HBB004" ,HBB004 ) ,new SqlParameter ( "@HBB005" ,HBB005 ) ,new SqlParameter ( "@HBB006" ,HBB006 ) ,new SqlParameter ( "@HBB021" ,HBB021 ) ,new SqlParameter ( "@HBB007" ,HBB007 ) ,new SqlParameter ( "@HBB008" ,HBB008 ) ,new SqlParameter ( "@HBB017" ,HBB017 ) ,new SqlParameter ( "@HBB018" ,HBB018 ) ,new SqlParameter ( "@HBB019" ,HBB019 ) ,new SqlParameter ( "@HBB020" ,HBB020 ) ,new SqlParameter ( "@HBB022" ,HBB022 ) ,new SqlParameter ( "@HBB023" ,HBB023 ) ,new SqlParameter ( "@HBB024" ,HBB024 ) ,new SqlParameter ( "@HBB960" ,HBB960 ) ,new SqlParameter ( "@HBB961" ,HBB961 ) ,new SqlParameter ( "@HBB962" ,lis . Key ) ,new SqlParameter ( "@HBB963" ,HBB963 ) ,new SqlParameter ( "@HBB001" ,HBA001 ) ,new SqlParameter ( "@HBB002" ,HBB002 ) ,new SqlParameter ( "@HBB964" ,HBB964 ) );
                                }
                                if (cou < 0)
                                {
                                    MessageBox.Show( "请购单单号" + HBA001 + "生成失败" );

                                    SqlHelper.ExecuteNonQuery( "DELETE FROM DCSHBA WHERE HBA001=@HBA001", new SqlParameter( "@HBA001", HBA001 ) );
                                }
                                else
                                {
                                    decimal IBB985 = 1;
                                    //,IBB046=IBB006
                                    SqlHelper . ExecuteNonQuery ( "UPDATE DCSIBB SET IBB985=@IBB985 WHERE IBB001=@IBB001" ,new SqlParameter ( "@IBB985" ,IBB985 ) ,new SqlParameter ( "@IBB001" ,lis . Key ) );                                   
                                }
                            }
                        }
                    }
                   
                    button1.Enabled = true;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    dateTimePicker1.Enabled = false;

                    if (cou > 0)
                    {
                        MessageBox.Show( "生成请购单成功" );
                    }
                }
            }
        }
        //取消
        private void button3_Click( object sender, EventArgs e )
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            dateTimePicker1.Enabled = false;

            comboBox1.Text = "- - 请选择 - -";
            comboBox2.Text = "- - 请选择 - -";
        }
        //请购人
        private void comboBox1_TextChanged( object sender, EventArgs e )
        {
            HBA004 = comboBox1.SelectedValue.ToString( );
            DataTable da = SqlHelper.ExecuteDataTable( "SELECT DBA001,DBA002,DAA001,DAA002 FROM TPADBA A,TPADAA B WHERE A.DBA005=B.DAA001 AND DBA001=@DBA001", new SqlParameter( "@DBA001", HBA004 ) );
            if (da != null && da.Rows.Count > 0)
            {
                HBA005 = da.Rows[0]["DAA001"].ToString( );
            }
        }

    }
}
