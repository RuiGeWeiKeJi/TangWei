using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mulaolao.Class
{
    public static class Ergodic
    {
        public static void FormEvery( Form fm )
        {
            foreach (Control ct in fm.Controls)
            {
                if (ct.GetType( ) == typeof( System.Windows.Forms.Panel ))
                {
                    Panel sc = ct as Panel;
                    foreach (Control cto in sc.Controls)
                    {
                        if (cto.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                        {
                            TextBox tb = cto as TextBox;
                            tb.Text = "";
                            continue;
                        }
                        if (cto.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                        {
                            ComboBox cb = cto as ComboBox;
                            cb.Text = "";
                            continue;
                        }
                    }
                }

                if (ct.GetType( ).ToString( ) == "System.Windows.Forms.GroupBox")
                {
                    #region  一层
                    GroupBox gb = ct as GroupBox;
                    foreach (Control cn in gb.Controls)
                    {
                        if (cn.GetType( ).ToString( ) == "System.Windows.Forms.TableLayoutPanel")
                        {
                            #region  四层
                            TableLayoutPanel lp = cn as TableLayoutPanel;
                            foreach (Control rl in lp.Controls)
                            {
                                if (rl.GetType( ).ToString( ) == "System.Windows.Forms.TextBox")
                                {
                                    TextBox tb = rl as TextBox;
                                    tb.Text = "";
                                    continue;
                                }
                                if (rl.GetType( ).ToString( ) == "System.Windows.Forms.ComboBox")
                                {
                                    ComboBox cb = rl as ComboBox;
                                    cb.Text = "";
                                    continue;
                                }
                                if (rl.GetType( ).ToString( ) == "System.Windows.Forms.RadioButton")
                                {
                                    RadioButton rb = rl as RadioButton;
                                    rb.Checked = false;
                                    continue;
                                }
                                if (rl.GetType( ).ToString( ) == "System.Windows.Forms.CheckBox")
                                {
                                    CheckBox cb = rl as CheckBox;
                                    cb.Checked = false;
                                    continue;
                                }
                                if (rl.GetType( ).ToString( ) == "System.Windows.Forms.PictureBox")
                                {
                                    PictureBox pb = rl as PictureBox;
                                    pb.Image = null;
                                    continue;
                                }
                                if (rl.GetType( ).ToString( ) == "System.Windows.Forms.DateTimePicker")
                                {
                                    DateTimePicker tp = rl as DateTimePicker;
                                    tp.Value = System.DateTime.Now;
                                    continue;
                                }
                                if (rl.GetType( ).ToString( ) == "System.Windows.Forms.TableLayoutPanel")
                                {
                                    #region 五层
                                    TableLayoutPanel pn = rl as TableLayoutPanel;
                                    foreach (Control nn in pn.Controls)
                                    {
                                        if (nn.GetType( ).ToString( ) == "System.Windows.Forms.TextBox")
                                        {
                                            TextBox tb = nn as TextBox;
                                            tb.Text = "";
                                            continue;
                                        }
                                        if (nn.GetType( ).ToString( ) == "System.Windows.Forms.ComboBox")
                                        {
                                            ComboBox cb = nn as ComboBox;
                                            cb.Text = "";
                                            continue;
                                        }
                                        if (nn.GetType( ).ToString( ) == "System.Windows.Forms.RadioButton")
                                        {
                                            RadioButton rb = nn as RadioButton;
                                            rb.Checked = false;
                                            continue;
                                        }
                                        if (nn.GetType( ).ToString( ) == "System.Windows.Forms.CheckBox")
                                        {
                                            CheckBox cb = nn as CheckBox;
                                            cb.Checked = false;
                                            continue;
                                        }
                                        if (nn.GetType( ).ToString( ) == "System.Windows.Forms.PictureBox")
                                        {
                                            PictureBox pb = nn as PictureBox;
                                            pb.Image = null;
                                            continue;
                                        }
                                        if (nn.GetType( ).ToString( ) == "System.Windows.Forms.DateTimePicker")
                                        {
                                            DateTimePicker tp = nn as DateTimePicker;
                                            tp.Value = System.DateTime.Now;
                                            continue;
                                        }
                                        if (nn.GetType( ).ToString( ) == "System.Windows.Forms.TableLayoutPanel")
                                        {
                                            #region
                                            TableLayoutPanel no = nn as TableLayoutPanel;
                                            foreach (Control io in no.Controls)
                                            {
                                                if (io.GetType( ).ToString( ) == "System.Windows.Forms.TextBox")
                                                {
                                                    TextBox tb = io as TextBox;
                                                    tb.Text = "";
                                                    continue;
                                                }
                                                if (io.GetType( ).ToString( ) == "System.Windows.Forms.ComboBox")
                                                {
                                                    ComboBox cb = io as ComboBox;
                                                    cb.Text = "";
                                                    continue;
                                                }
                                                if (io.GetType( ).ToString( ) == "System.Windows.Forms.RadioButton")
                                                {
                                                    RadioButton rb = io as RadioButton;
                                                    rb.Checked = false;
                                                    continue;
                                                }
                                                if (io.GetType( ).ToString( ) == "System.Windows.Forms.CheckBox")
                                                {
                                                    CheckBox cb = io as CheckBox;
                                                    cb.Checked = false;
                                                    continue;
                                                }
                                                if (io.GetType( ).ToString( ) == "System.Windows.Forms.PictureBox")
                                                {
                                                    PictureBox pb = io as PictureBox;
                                                    pb.Image = null;
                                                    continue;
                                                }
                                                if (io.GetType( ).ToString( ) == "System.Windows.Forms.DateTimePicker")
                                                {
                                                    DateTimePicker tp = io as DateTimePicker;
                                                    tp.Value = System.DateTime.Now;
                                                    continue;
                                                }
                                            }
                                            #endregion
                                        }
                                    }
                                    #endregion
                                }
                            }
                            #endregion
                        }
                        if (cn.GetType( ).ToString( ) == "System.Windows.Forms.GroupBox")
                        {
                            #region 二层
                            GroupBox bx = cn as GroupBox;
                            foreach (Control cx in bx.Controls)
                            {
                                if (cx.GetType( ).ToString( ) == "System.Windows.Forms.GroupBox")
                                {
                                    #region  三层
                                    GroupBox ox = cx as GroupBox;
                                    foreach (Control lx in ox.Controls)
                                    {
                                        if (lx.GetType( ).ToString( ) == "System.Windows.Forms.TableLayoutPanel")
                                        {
                                            #region  四层
                                            TableLayoutPanel lp = lx as TableLayoutPanel;
                                            foreach (Control rl in lp.Controls)
                                            {
                                                if (rl.GetType( ).ToString( ) == "System.Windows.Forms.TextBox")
                                                {
                                                    TextBox tb = rl as TextBox;
                                                    tb.Text = "";
                                                    continue;
                                                }
                                                if (rl.GetType( ).ToString( ) == "System.Windows.Forms.ComboBox")
                                                {
                                                    ComboBox cb = rl as ComboBox;
                                                    cb.Text = "";
                                                    continue;
                                                }
                                                if (rl.GetType( ).ToString( ) == "System.Windows.Forms.RadioButton")
                                                {
                                                    RadioButton rb = rl as RadioButton;
                                                    rb.Checked = false;
                                                    continue;
                                                }
                                                if (rl.GetType( ).ToString( ) == "System.Windows.Forms.CheckBox")
                                                {
                                                    CheckBox cb = rl as CheckBox;
                                                    cb.Checked = false;
                                                    continue;
                                                }
                                                if (rl.GetType( ).ToString( ) == "System.Windows.Forms.PictureBox")
                                                {
                                                    PictureBox pb = rl as PictureBox;
                                                    pb.Image = null;
                                                    continue;
                                                }
                                                if (rl.GetType( ).ToString( ) == "System.Windows.Forms.DateTimePicker")
                                                {
                                                    DateTimePicker tp = rl as DateTimePicker;
                                                    tp.Value = System.DateTime.Now;
                                                    continue;
                                                }
                                                if (rl.GetType( ).ToString( ) == "System.Windows.Forms.TableLayoutPanel")
                                                {
                                                    #region 五层
                                                    TableLayoutPanel pn = rl as TableLayoutPanel;
                                                    foreach (Control nn in pn.Controls)
                                                    {
                                                        if (nn.GetType( ).ToString( ) == "System.Windows.Forms.TextBox")
                                                        {
                                                            TextBox tb = nn as TextBox;
                                                            tb.Text = "";
                                                            continue;
                                                        }
                                                        if (nn.GetType( ).ToString( ) == "System.Windows.Forms.ComboBox")
                                                        {
                                                            ComboBox cb = nn as ComboBox;
                                                            cb.Text = "";
                                                            continue;
                                                        }
                                                        if (nn.GetType( ).ToString( ) == "System.Windows.Forms.RadioButton")
                                                        {
                                                            RadioButton rb = nn as RadioButton;
                                                            rb.Checked = false;
                                                            continue;
                                                        }
                                                        if (nn.GetType( ).ToString( ) == "System.Windows.Forms.CheckBox")
                                                        {
                                                            CheckBox cb = nn as CheckBox;
                                                            cb.Checked = false;
                                                            continue;
                                                        }
                                                        if (nn.GetType( ).ToString( ) == "System.Windows.Forms.PictureBox")
                                                        {
                                                            PictureBox pb = nn as PictureBox;
                                                            pb.Image = null;
                                                            continue;
                                                        }
                                                        if (nn.GetType( ).ToString( ) == "System.Windows.Forms.DateTimePicker")
                                                        {
                                                            DateTimePicker tp = nn as DateTimePicker;
                                                            tp.Value = System.DateTime.Now;
                                                            continue;
                                                        }
                                                        if (nn.GetType( ).ToString( ) == "System.Windows.Forms.TableLayoutPanel")
                                                        {
                                                            #region
                                                            TableLayoutPanel no = nn as TableLayoutPanel;
                                                            foreach (Control io in no.Controls)
                                                            {
                                                                if (io.GetType( ).ToString( ) == "System.Windows.Forms.TextBox")
                                                                {
                                                                    TextBox tb = io as TextBox;
                                                                    tb.Text = "";
                                                                    continue;
                                                                }
                                                                if (io.GetType( ).ToString( ) == "System.Windows.Forms.ComboBox")
                                                                {
                                                                    ComboBox cb = io as ComboBox;
                                                                    cb.Text = "";
                                                                    continue;
                                                                }
                                                                if (io.GetType( ).ToString( ) == "System.Windows.Forms.RadioButton")
                                                                {
                                                                    RadioButton rb = io as RadioButton;
                                                                    rb.Checked = false;
                                                                    continue;
                                                                }
                                                                if (io.GetType( ).ToString( ) == "System.Windows.Forms.CheckBox")
                                                                {
                                                                    CheckBox cb = io as CheckBox;
                                                                    cb.Checked = false;
                                                                    continue;
                                                                }
                                                                if (io.GetType( ).ToString( ) == "System.Windows.Forms.PictureBox")
                                                                {
                                                                    PictureBox pb = io as PictureBox;
                                                                    pb.Image = null;
                                                                    continue;
                                                                }
                                                                if (io.GetType( ).ToString( ) == "System.Windows.Forms.DateTimePicker")
                                                                {
                                                                    DateTimePicker tp = io as DateTimePicker;
                                                                    tp.Value = System.DateTime.Now;
                                                                    continue;
                                                                }
                                                            }
                                                            #endregion
                                                        }
                                                    }
                                                    #endregion
                                                }
                                            }
                                            #endregion
                                        }
                                        if (lx.GetType( ).ToString( ) == "System.Windows.Forms.TextBox")
                                        {
                                            TextBox tb = lx as TextBox;
                                            tb.Text = "";
                                            continue;
                                        }
                                        if (lx.GetType( ).ToString( ) == "System.Windows.Forms.ComboBox")
                                        {
                                            ComboBox cb = lx as ComboBox;
                                            cb.Text = "";
                                            continue;
                                        }
                                        if (lx.GetType( ).ToString( ) == "System.Windows.Forms.RadioButton")
                                        {
                                            RadioButton rb = lx as RadioButton;
                                            rb.Checked = false;
                                            continue;
                                        }
                                        if (lx.GetType( ).ToString( ) == "System.Windows.Forms.CheckBox")
                                        {
                                            CheckBox cb = lx as CheckBox;
                                            cb.Checked = false;
                                            continue;
                                        }
                                        if (lx.GetType( ).ToString( ) == "System.Windows.Forms.PictureBox")
                                        {
                                            PictureBox pb = lx as PictureBox;
                                            pb.Image = null;
                                            continue;
                                        }
                                        if (lx.GetType( ).ToString( ) == "System.Windows.Forms.DateTimePicker")
                                        {
                                            DateTimePicker tp = lx as DateTimePicker;
                                            tp.Value = System.DateTime.Now;
                                            continue;
                                        }
                                    }
                                    #endregion
                                }
                                if (cx.GetType( ).ToString( ) == "System.Windows.Forms.TextBox")
                                {
                                    TextBox tb = cx as TextBox;
                                    tb.Text = "";
                                    continue;
                                }
                                if (cx.GetType( ).ToString( ) == "System.Windows.Forms.ComboBox")
                                {
                                    ComboBox cb = cx as ComboBox;
                                    cb.Text = "";
                                    continue;
                                }
                                if (cx.GetType( ).ToString( ) == "System.Windows.Forms.RadioButton")
                                {
                                    RadioButton rb = cx as RadioButton;
                                    rb.Checked = false;
                                    continue;
                                }
                                if (cx.GetType( ).ToString( ) == "System.Windows.Forms.CheckBox")
                                {
                                    CheckBox cb = cx as CheckBox;
                                    cb.Checked = false;
                                    continue;
                                }
                                if (cx.GetType( ).ToString( ) == "System.Windows.Forms.PictureBox")
                                {
                                    PictureBox pb = cx as PictureBox;
                                    pb.Image = null;
                                    continue;
                                }
                                if (cx.GetType( ).ToString( ) == "System.Windows.Forms.DateTimePicker")
                                {
                                    DateTimePicker tp = cx as DateTimePicker;
                                    tp.Value = System.DateTime.Now;
                                    continue;
                                }
                            }
                            #endregion
                        }
                        if (cn.GetType( ).ToString( ) == "System.Windows.Forms.TextBox")
                        {
                            TextBox tb = cn as TextBox;
                            tb.Text = "";
                            continue;
                        }
                        if (cn.GetType( ).ToString( ) == "System.Windows.Forms.ComboBox")
                        {
                            ComboBox cb = cn as ComboBox;
                            cb.Text = "";
                            continue;
                        }
                        if (cn.GetType( ).ToString( ) == "System.Windows.Forms.RadioButton")
                        {
                            RadioButton rb = cn as RadioButton;
                            rb.Checked = false;
                            continue;
                        }
                        if (cn.GetType( ).ToString( ) == "System.Windows.Forms.CheckBox")
                        {
                            CheckBox cb = cn as CheckBox;
                            cb.Checked = false;
                            continue;
                        }
                        if (cn.GetType( ).ToString( ) == "System.Windows.Forms.PictureBox")
                        {
                            PictureBox pb = cn as PictureBox;
                            pb.Image = null;
                            continue;
                        }
                        if (cn.GetType( ).ToString( ) == "System.Windows.Forms.DateTimePicker")
                        {
                            DateTimePicker tp = cn as DateTimePicker;
                            tp.Value = System.DateTime.Now;
                            continue;
                        }
                    }
                    #endregion                  
                }
            }
        }
        public static void GroupboxEvery( GroupBox gb )
        {
            foreach (Control cn in gb.Controls)
            {
                if (cn.GetType( ).ToString( ) == "System.Windows.Forms.GroupBox")
                {
                    GroupBox gbx = cn as GroupBox;
                    foreach (Control con in gbx.Controls)
                    {
                        if (con.GetType( ).ToString( ) == "System.Windows.Forms.TextBox")
                        {
                            TextBox tb = con as TextBox;
                            tb.Text = "";
                            continue;
                        }
                        if (con.GetType( ).ToString( ) == "System.Windows.Forms.ComboBox")
                        {
                            ComboBox cb = con as ComboBox;
                            cb.Text = "";
                            continue;
                        }
                    }
                }
                if (cn.GetType( ).ToString( ) == "System.Windows.Forms.TextBox")
                {
                    TextBox tb = cn as TextBox;
                    tb.Text = "";
                    continue;
                }
                if (cn.GetType( ).ToString( ) == "System.Windows.Forms.ComboBox")
                {
                    ComboBox cb = cn as ComboBox;
                    cb.Text = "";
                    continue;
                }
                if (cn.GetType( ).ToString( ) == "System.Windows.Forms.RadioButton")
                {
                    RadioButton rb = cn as RadioButton;
                    rb.Checked = false;
                    continue;
                }
                if (cn.GetType( ).ToString( ) == "System.Windows.Forms.CheckBox")
                {
                    CheckBox cb = cn as CheckBox;
                    cb.Checked = false;
                    continue;
                }
                if (cn.GetType( ).ToString( ) == "System.Windows.Forms.PictureBox")
                {
                    PictureBox pb = cn as PictureBox;
                    pb.Image = null;
                    continue;
                }
            }
        }
        public static void PanelEvery( Panel sct )
        {
            foreach (Control cto in sct.Controls)
            {
                if (cto.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                {
                    TextBox tb = cto as TextBox;
                    tb.Text = "";
                    continue;
                }
                if (cto.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                {
                    ComboBox cb = cto as ComboBox;
                    cb.Text = "";
                    continue;
                }
            }
        }
        public static void GroupboxEvery( GroupBox[] gb )
        {
            foreach (GroupBox gbs in gb)
            {
                foreach (Control cn in gbs.Controls)
                {
                    if (cn.GetType( ).ToString( ) == "System.Windows.Forms.TextBox")
                    {
                        TextBox tb = cn as TextBox;
                        tb.Text = "";
                        continue;
                    }
                    if (cn.GetType( ).ToString( ) == "System.Windows.Forms.ComboBox")
                    {
                        ComboBox cb = cn as ComboBox;
                        cb.Text = "";
                        continue;
                    }
                    if (cn.GetType( ).ToString( ) == "System.Windows.Forms.RadioButton")
                    {
                        RadioButton rb = cn as RadioButton;
                        rb.Checked = false;
                        continue;
                    }
                    if (cn.GetType( ).ToString( ) == "System.Windows.Forms.CheckBox")
                    {
                        CheckBox cb = cn as CheckBox;
                        cb.Checked = false;
                        continue;
                    }
                    if (cn.GetType( ).ToString( ) == "System.Windows.Forms.PictureBox")
                    {
                        PictureBox pb = cn as PictureBox;
                        pb.Image = null;
                        continue;
                    }
                }
            }
        }
        public static void CbtbEvery<T>( List<T> ct )
        {
            foreach (var cb in ct)
            {
                if (cb.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                {
                    ComboBox cbx = cb as ComboBox;
                    cbx.Text = "";
                    continue;
                }
                if (cb.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                {
                    TextBox tb = cb as TextBox;
                    tb.Text = "";
                    continue;
                }
            }
        }
        public static void GroupboxEveryEnableFalse( GroupBox gb )
        {
            foreach (Control cn in gb.Controls)
            {
                if (cn.GetType( ) == typeof( System.Windows.Forms.GroupBox ))
                {
                    GroupBox gbs = cn as GroupBox;
                    foreach (Control con in gbs.Controls)
                    {

                        if (con.GetType( ) == typeof( System.Windows.Forms.GroupBox ))
                        {
                            GroupBox gbsx = con as GroupBox;
                            foreach (Control cont in gbsx.Controls)
                            {
                                if (cont.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                {
                                    TextBox tb = cont as TextBox;
                                    tb.Enabled = false;
                                    continue;
                                }
                                if (cont.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                {
                                    ComboBox cb = cont as ComboBox;
                                    cb.Enabled = false;
                                    continue;
                                }
                                if (cont.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                {
                                    CheckBox ck = cont as CheckBox;
                                    ck.Enabled = false;
                                    continue;
                                }
                                if (cont.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                {
                                    RadioButton rb = cont as RadioButton;
                                    rb.Enabled = false;
                                    continue;
                                }
                                if (cont.GetType( ) == typeof( System.Windows.Forms.Button ))
                                {
                                    Button bt = cont as Button;
                                    bt.Enabled = false;
                                    continue;
                                }
                                if (cont.GetType( ) == typeof( System.Windows.Forms.DateTimePicker ))
                                {
                                    DateTimePicker dp = cont as DateTimePicker;
                                    dp.Enabled = false;
                                    continue;
                                }
                                if (cont.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                                {
                                    TableLayoutPanel tl = cont as TableLayoutPanel;
                                    tl.Enabled = false;

                                    foreach (Control ct in tl.Controls)
                                    {
                                        if (ct.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                        {
                                            TextBox tb = ct as TextBox;
                                            tb.Enabled = false;
                                            continue;
                                        }
                                        if (ct.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                        {
                                            ComboBox cb = ct as ComboBox;
                                            cb.Enabled = false;
                                            continue;
                                        }
                                        if (ct.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                        {
                                            CheckBox cbx = ct as CheckBox;
                                            cbx.Enabled = false;
                                            continue;
                                        }
                                        if (ct.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                        {
                                            RadioButton rb = ct as RadioButton;
                                            rb.Enabled = false;
                                            continue;
                                        }
                                        if (ct.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                                        {
                                            TableLayoutPanel tp = ct as TableLayoutPanel;
                                            tp.Enabled = false;
                                            foreach (Control cx in tp.Controls)
                                            {
                                                if (cx.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                                {
                                                    TextBox tb = cx as TextBox;
                                                    tb.Enabled = false;
                                                    continue;
                                                }
                                                if (cx.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                                {
                                                    ComboBox cb = cx as ComboBox;
                                                    cb.Enabled = false;
                                                    continue;
                                                }
                                                if (cx.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                                {
                                                    CheckBox cbx = cx as CheckBox;
                                                    cbx.Enabled = false;
                                                    continue;
                                                }
                                                if (cx.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                                {
                                                    RadioButton rb = cx as RadioButton;
                                                    rb.Enabled = false;
                                                    continue;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (con.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                        {
                            TextBox tb = con as TextBox;
                            tb.Enabled = false;
                            continue;
                        }
                        if (con.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                        {
                            ComboBox cb = con as ComboBox;
                            cb.Enabled = false;
                            continue;
                        }
                        if (con.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                        {
                            CheckBox ck = con as CheckBox;
                            ck.Enabled = false;
                            continue;
                        }
                        if (con.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                        {
                            RadioButton rb = con as RadioButton;
                            rb.Enabled = false;
                            continue;
                        }
                        if (con.GetType( ) == typeof( System.Windows.Forms.Button ))
                        {
                            Button bt = con as Button;
                            bt.Enabled = false;
                            continue;
                        }
                        if (con.GetType( ) == typeof( System.Windows.Forms.DateTimePicker ))
                        {
                            DateTimePicker dp = con as DateTimePicker;
                            dp.Enabled = false;
                            continue;
                        }
                        if (con.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                        {
                            TableLayoutPanel tl = con as TableLayoutPanel;
                            tl.Enabled = false;

                            foreach (Control ct in tl.Controls)
                            {
                                if (ct.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                {
                                    TextBox tb = ct as TextBox;
                                    tb.Enabled = false;
                                    continue;
                                }
                                if (ct.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                {
                                    ComboBox cb = ct as ComboBox;
                                    cb.Enabled = false;
                                    continue;
                                }
                                if (ct.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                {
                                    CheckBox cbx = ct as CheckBox;
                                    cbx.Enabled = false;
                                    continue;
                                }
                                if (ct.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                {
                                    RadioButton rb = ct as RadioButton;
                                    rb.Enabled = false;
                                    continue;
                                }
                                if (ct.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                                {
                                    TableLayoutPanel tp = ct as TableLayoutPanel;
                                    tp.Enabled = false;
                                    foreach (Control cx in tp.Controls)
                                    {
                                        if (cx.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                        {
                                            TextBox tb = cx as TextBox;
                                            tb.Enabled = false;
                                            continue;
                                        }
                                        if (cx.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                        {
                                            ComboBox cb = cx as ComboBox;
                                            cb.Enabled = false;
                                            continue;
                                        }
                                        if (cx.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                        {
                                            CheckBox cbx = cx as CheckBox;
                                            cbx.Enabled = false;
                                            continue;
                                        }
                                        if (cx.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                        {
                                            RadioButton rb = cx as RadioButton;
                                            rb.Enabled = false;
                                            continue;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (cn.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                {
                    TextBox tb = cn as TextBox;
                    tb.Enabled = false;
                    continue;
                }
                if (cn.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                {
                    ComboBox cb = cn as ComboBox;
                    cb.Enabled = false;
                    continue;
                }
                if (cn.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                {
                    CheckBox ck = cn as CheckBox;
                    ck.Enabled = false;
                    continue;
                }
                if (cn.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                {
                    RadioButton rb = cn as RadioButton;
                    rb.Enabled = false;
                    continue;
                }
                if (cn.GetType( ) == typeof( System.Windows.Forms.Button ))
                {
                    Button bt = cn as Button;
                    bt.Enabled = false;
                    continue;
                }
                if (cn.GetType( ) == typeof( System.Windows.Forms.DateTimePicker ))
                {
                    DateTimePicker dp = cn as DateTimePicker;
                    dp.Enabled = false;
                    continue;
                }
                if (cn.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                {
                    TableLayoutPanel tl = cn as TableLayoutPanel;
                    tl.Enabled = false;

                    foreach (Control ct in tl.Controls)
                    {
                        if (ct.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                        {
                            TextBox tb = ct as TextBox;
                            tb.Enabled = false;
                            continue;
                        }
                        if (ct.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                        {
                            ComboBox cb = ct as ComboBox;
                            cb.Enabled = false;
                            continue;
                        }
                        if (ct.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                        {
                            CheckBox cbx = ct as CheckBox;
                            cbx.Enabled = false;
                            continue;
                        }
                        if (ct.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                        {
                            RadioButton rb = ct as RadioButton;
                            rb.Enabled = false;
                            continue;
                        }
                        if (ct.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                        {
                            TableLayoutPanel tp = ct as TableLayoutPanel;
                            tp.Enabled = false;
                            foreach (Control cx in tp.Controls)
                            {
                                if (cx.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                {
                                    TextBox tb = cx as TextBox;
                                    tb.Enabled = false;
                                    continue;
                                }
                                if (cx.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                {
                                    ComboBox cb = cx as ComboBox;
                                    cb.Enabled = false;
                                    continue;
                                }
                                if (cx.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                {
                                    CheckBox cbx = cx as CheckBox;
                                    cbx.Enabled = false;
                                    continue;
                                }
                                if (cx.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                {
                                    RadioButton rb = cx as RadioButton;
                                    rb.Enabled = false;
                                    continue;
                                }
                            }
                        }
                    }
                }
            }
        }
        public static void PanelEnableFalse( Panel spl )
        {
            foreach (Control cto in spl.Controls)
            {
                if (cto.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                {
                    TextBox tb = cto as TextBox;
                    tb.Enabled = false;
                    continue;
                }
                if (cto.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                {
                    ComboBox cb = cto as ComboBox;
                    cb.Enabled = false;
                    continue;
                }
                if (cto.GetType( ) == typeof( System.Windows.Forms.DateTimePicker ))
                {
                    DateTimePicker dt = cto as DateTimePicker;
                    dt.Enabled = false;
                    continue;
                }
            }
        }
        public static void GroupboxEveryEnableTrue( GroupBox gb )
        {
            foreach (Control cn in gb.Controls)
            {
                if (cn.GetType( ) == typeof( System.Windows.Forms.GroupBox ))
                {
                    GroupBox gbs = cn as GroupBox;
                    foreach (Control con in gbs.Controls)
                    {
                        if (con.GetType( ) == typeof( System.Windows.Forms.GroupBox ))
                        {
                            GroupBox gbsx = con as GroupBox;
                            foreach (Control cont in gbsx.Controls)
                            {
                                if (cont.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                {
                                    TextBox tb = cont as TextBox;
                                    tb.Enabled = true;
                                    continue;
                                }
                                if (cont.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                {
                                    ComboBox cb = cont as ComboBox;
                                    cb.Enabled = true;
                                    continue;
                                }
                                if (cont.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                {
                                    CheckBox ck = cont as CheckBox;
                                    ck.Enabled = true;
                                    continue;
                                }
                                if (cont.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                {
                                    RadioButton rb = cont as RadioButton;
                                    rb.Enabled = true;
                                    continue;
                                }
                                if (cont.GetType( ) == typeof( System.Windows.Forms.Button ))
                                {
                                    Button bt = cont as Button;
                                    bt.Enabled = true;
                                    continue;
                                }
                                if (cont.GetType( ) == typeof( System.Windows.Forms.DateTimePicker ))
                                {
                                    DateTimePicker dp = cont as DateTimePicker;
                                    dp.Enabled = true;
                                    continue;
                                }
                                if (cont.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                                {
                                    TableLayoutPanel tl = cont as TableLayoutPanel;
                                    tl.Enabled = true;

                                    foreach (Control ct in tl.Controls)
                                    {
                                        if (ct.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                        {
                                            TextBox tb = ct as TextBox;
                                            tb.Enabled = true;
                                            continue;
                                        }
                                        if (ct.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                        {
                                            ComboBox cb = ct as ComboBox;
                                            cb.Enabled = true;
                                            continue;
                                        }
                                        if (ct.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                        {
                                            CheckBox cbx = ct as CheckBox;
                                            cbx.Enabled = true;
                                            continue;
                                        }
                                        if (ct.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                        {
                                            RadioButton rb = ct as RadioButton;
                                            rb.Enabled = true;
                                            continue;
                                        }
                                        if (ct.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                                        {
                                            TableLayoutPanel tp = ct as TableLayoutPanel;
                                            tp.Enabled = true;
                                            foreach (Control cx in tp.Controls)
                                            {
                                                if (cx.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                                {
                                                    TextBox tb = cx as TextBox;
                                                    tb.Enabled = true;
                                                    continue;
                                                }
                                                if (cx.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                                {
                                                    ComboBox cb = cx as ComboBox;
                                                    cb.Enabled = true;
                                                    continue;
                                                }
                                                if (cx.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                                {
                                                    CheckBox cbx = cx as CheckBox;
                                                    cbx.Enabled = true;
                                                    continue;
                                                }
                                                if (cx.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                                {
                                                    RadioButton rb = cx as RadioButton;
                                                    rb.Enabled = true;
                                                    continue;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (con.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                        {
                            TextBox tb = con as TextBox;
                            tb.Enabled = true;
                            continue;
                        }
                        if (con.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                        {
                            ComboBox cb = con as ComboBox;
                            cb.Enabled = true;
                            continue;
                        }
                        if (con.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                        {
                            CheckBox ck = con as CheckBox;
                            ck.Enabled = true;
                            continue;
                        }
                        if (con.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                        {
                            RadioButton rb = con as RadioButton;
                            rb.Enabled = true;
                            continue;
                        }
                        if (con.GetType( ) == typeof( System.Windows.Forms.Button ))
                        {
                            Button bt = con as Button;
                            bt.Enabled = true;
                            continue;
                        }
                        if (con.GetType( ) == typeof( System.Windows.Forms.DateTimePicker ))
                        {
                            DateTimePicker dp = con as DateTimePicker;
                            dp.Enabled = true;
                            continue;
                        }
                        if (con.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                        {
                            TableLayoutPanel tl = con as TableLayoutPanel;
                            tl.Enabled = true;

                            foreach (Control ct in tl.Controls)
                            {
                                if (ct.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                {
                                    TextBox tb = ct as TextBox;
                                    tb.Enabled = true;
                                    continue;
                                }
                                if (ct.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                {
                                    ComboBox cb = ct as ComboBox;
                                    cb.Enabled = true;
                                    continue;
                                }
                                if (ct.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                {
                                    CheckBox cbx = ct as CheckBox;
                                    cbx.Enabled = true;
                                    continue;
                                }
                                if (ct.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                {
                                    RadioButton rb = ct as RadioButton;
                                    rb.Enabled = true;
                                    continue;
                                }
                                if (ct.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                                {
                                    TableLayoutPanel tp = ct as TableLayoutPanel;
                                    tp.Enabled = true;
                                    foreach (Control cx in tp.Controls)
                                    {
                                        if (cx.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                        {
                                            TextBox tb = cx as TextBox;
                                            tb.Enabled = true;
                                            continue;
                                        }
                                        if (cx.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                        {
                                            ComboBox cb = cx as ComboBox;
                                            cb.Enabled = true;
                                            continue;
                                        }
                                        if (cx.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                        {
                                            CheckBox cbx = cx as CheckBox;
                                            cbx.Enabled = true;
                                            continue;
                                        }
                                        if (cx.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                        {
                                            RadioButton rb = cx as RadioButton;
                                            rb.Enabled = true;
                                            continue;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (cn.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                {
                    TextBox tb = cn as TextBox;
                    tb.Enabled = true;
                    continue;
                }
                if (cn.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                {
                    ComboBox cb = cn as ComboBox;
                    cb.Enabled = true;
                    continue;
                }
                if (cn.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                {
                    CheckBox ck = cn as CheckBox;
                    ck.Enabled = true;
                    continue;
                }
                if (cn.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                {
                    RadioButton rb = cn as RadioButton;
                    rb.Enabled = true;
                    continue;
                }
                if (cn.GetType( ) == typeof( System.Windows.Forms.Button ))
                {
                    Button bt = cn as Button;
                    bt.Enabled = true;
                    continue;
                }
                if (cn.GetType( ) == typeof( System.Windows.Forms.DateTimePicker ))
                {
                    DateTimePicker dp = cn as DateTimePicker;
                    dp.Enabled = true;
                    continue;
                }
                if (cn.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                {
                    TableLayoutPanel tl = cn as TableLayoutPanel;
                    tl.Enabled = false;

                    foreach (Control ct in tl.Controls)
                    {
                        if (ct.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                        {
                            TextBox tb = ct as TextBox;
                            tb.Enabled = false;
                            continue;
                        }
                        if (ct.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                        {
                            ComboBox cb = ct as ComboBox;
                            cb.Enabled = false;
                            continue;
                        }
                        if (ct.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                        {
                            CheckBox cbx = ct as CheckBox;
                            cbx.Enabled = false;
                            continue;
                        }
                        if (ct.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                        {
                            RadioButton rb = ct as RadioButton;
                            rb.Enabled = false;
                            continue;
                        }
                        if (ct.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                        {
                            TableLayoutPanel tp = ct as TableLayoutPanel;
                            tp.Enabled = false;
                            foreach (Control cx in tp.Controls)
                            {
                                if (cx.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                {
                                    TextBox tb = cx as TextBox;
                                    tb.Enabled = false;
                                    continue;
                                }
                                if (cx.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                {
                                    ComboBox cb = cx as ComboBox;
                                    cb.Enabled = false;
                                    continue;
                                }
                                if (cx.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                {
                                    CheckBox cbx = cx as CheckBox;
                                    cbx.Enabled = false;
                                    continue;
                                }
                                if (cx.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                {
                                    RadioButton rb = cx as RadioButton;
                                    rb.Enabled = false;
                                    continue;
                                }
                            }
                        }
                    }
                }
            }
        }
        public static void PanelEnableTrue( Panel spl )
        {
            foreach (Control cto in spl.Controls)
            {
                if (cto.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                {
                    TextBox tb = cto as TextBox;
                    tb.Enabled = true;
                    continue;
                }
                if (cto.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                {
                    ComboBox cb = cto as ComboBox;
                    cb.Enabled = true;
                    continue;
                }
                if (cto.GetType( ) == typeof( System.Windows.Forms.DateTimePicker ))
                {
                    DateTimePicker dt = cto as DateTimePicker;
                    dt.Enabled = true;
                    continue;
                }
            }
        }
        public static void FormGroupboxEnableFalse( Form fm, GroupBox[] gb )
        {
            foreach (GroupBox gbx in gb)
            {
                foreach (Control cn in gbx.Controls)
                {
                    if (cn.GetType( ) == typeof( System.Windows.Forms.GroupBox ))
                    {
                        GroupBox gbs = cn as GroupBox;
                        foreach (Control con in gbs.Controls)
                        {
                            if (con.GetType( ) == typeof( System.Windows.Forms.GroupBox ))
                            {
                                GroupBox gbsx = con as GroupBox;
                                foreach (Control cont in gbsx.Controls)
                                {
                                    if (cont.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                    {
                                        TextBox tb = cont as TextBox;
                                        tb.Enabled = false;
                                        continue;
                                    }
                                    if (cont.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                    {
                                        ComboBox cb = cont as ComboBox;
                                        cb.Enabled = false;
                                        continue;
                                    }
                                    if (cont.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                    {
                                        CheckBox ck = cont as CheckBox;
                                        ck.Enabled = false;
                                        continue;
                                    }
                                    if (cont.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                    {
                                        RadioButton rb = cont as RadioButton;
                                        rb.Enabled = false;
                                        continue;
                                    }
                                    if (cont.GetType( ) == typeof( System.Windows.Forms.Button ))
                                    {
                                        Button bt = cont as Button;
                                        bt.Enabled = false;
                                        continue;
                                    }
                                    if (cont.GetType( ) == typeof( System.Windows.Forms.DateTimePicker ))
                                    {
                                        DateTimePicker dp = cont as DateTimePicker;
                                        dp.Enabled = false;
                                        continue;
                                    }
                                    if (cont.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                                    {
                                        TableLayoutPanel tl = cont as TableLayoutPanel;
                                        tl.Enabled = false;

                                        foreach (Control ct in tl.Controls)
                                        {
                                            if (ct.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                            {
                                                TextBox tb = ct as TextBox;
                                                tb.Enabled = false;
                                                continue;
                                            }
                                            if (ct.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                            {
                                                ComboBox cb = ct as ComboBox;
                                                cb.Enabled = false;
                                                continue;
                                            }
                                            if (ct.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                            {
                                                CheckBox cbx = ct as CheckBox;
                                                cbx.Enabled = false;
                                                continue;
                                            }
                                            if (ct.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                            {
                                                RadioButton rb = ct as RadioButton;
                                                rb.Enabled = false;
                                                continue;
                                            }
                                            if (ct.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                                            {
                                                TableLayoutPanel tp = ct as TableLayoutPanel;
                                                tp.Enabled = false;
                                                foreach (Control cx in tp.Controls)
                                                {
                                                    if (cx.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                                    {
                                                        TextBox tb = cx as TextBox;
                                                        tb.Enabled = false;
                                                        continue;
                                                    }
                                                    if (cx.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                                    {
                                                        ComboBox cb = cx as ComboBox;
                                                        cb.Enabled = false;
                                                        continue;
                                                    }
                                                    if (cx.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                                    {
                                                        CheckBox cbx = cx as CheckBox;
                                                        cbx.Enabled = false;
                                                        continue;
                                                    }
                                                    if (cx.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                                    {
                                                        RadioButton rb = cx as RadioButton;
                                                        rb.Enabled = false;
                                                        continue;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            if (con.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                            {
                                TextBox tb = con as TextBox;
                                tb.Enabled = false;
                                continue;
                            }
                            if (con.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                            {
                                ComboBox cb = con as ComboBox;
                                cb.Enabled = false;
                                continue;
                            }
                            if (con.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                            {
                                CheckBox ck = con as CheckBox;
                                ck.Enabled = false;
                                continue;
                            }
                            if (con.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                            {
                                RadioButton rb = con as RadioButton;
                                rb.Enabled = false;
                                continue;
                            }
                            if (con.GetType( ) == typeof( System.Windows.Forms.Button ))
                            {
                                Button bt = con as Button;
                                bt.Enabled = false;
                                continue;
                            }
                            if (con.GetType( ) == typeof( System.Windows.Forms.DateTimePicker ))
                            {
                                DateTimePicker dp = con as DateTimePicker;
                                dp.Enabled = false;
                                continue;
                            }
                            if (con.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                            {
                                TableLayoutPanel tl = con as TableLayoutPanel;
                                tl.Enabled = false;

                                foreach (Control ct in tl.Controls)
                                {
                                    if (ct.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                    {
                                        TextBox tb = ct as TextBox;
                                        tb.Enabled = false;
                                        continue;
                                    }
                                    if (ct.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                    {
                                        ComboBox cb = ct as ComboBox;
                                        cb.Enabled = false;
                                        continue;
                                    }
                                    if (ct.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                    {
                                        CheckBox cbx = ct as CheckBox;
                                        cbx.Enabled = false;
                                        continue;
                                    }
                                    if (ct.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                    {
                                        RadioButton rb = ct as RadioButton;
                                        rb.Enabled = false;
                                        continue;
                                    }
                                    if (ct.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                                    {
                                        TableLayoutPanel tp = ct as TableLayoutPanel;
                                        tp.Enabled = false;
                                        foreach (Control cx in tp.Controls)
                                        {
                                            if (cx.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                            {
                                                TextBox tb = cx as TextBox;
                                                tb.Enabled = false;
                                                continue;
                                            }
                                            if (cx.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                            {
                                                ComboBox cb = cx as ComboBox;
                                                cb.Enabled = false;
                                                continue;
                                            }
                                            if (cx.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                            {
                                                CheckBox cbx = cx as CheckBox;
                                                cbx.Enabled = false;
                                                continue;
                                            }
                                            if (cx.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                            {
                                                RadioButton rb = cx as RadioButton;
                                                rb.Enabled = false;
                                                continue;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (cn.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                    {
                        TextBox tb = cn as TextBox;
                        tb.Enabled = false;
                        continue;
                    }
                    if (cn.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                    {
                        ComboBox cb = cn as ComboBox;
                        cb.Enabled = false;
                        continue;
                    }
                    if (cn.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                    {
                        CheckBox ck = cn as CheckBox;
                        ck.Enabled = false;
                        continue;
                    }
                    if (cn.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                    {
                        RadioButton rb = cn as RadioButton;
                        rb.Enabled = false;
                        continue;
                    }
                    if (cn.GetType( ) == typeof( System.Windows.Forms.Button ))
                    {
                        Button bt = cn as Button;
                        bt.Enabled = false;
                        continue;
                    }
                    if (cn.GetType( ) == typeof( System.Windows.Forms.DateTimePicker ))
                    {
                        DateTimePicker dp = cn as DateTimePicker;
                        dp.Enabled = false;
                        continue;
                    }
                    if (cn.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                    {
                        TableLayoutPanel tl = cn as TableLayoutPanel;
                        tl.Enabled = false;

                        foreach (Control ct in tl.Controls)
                        {
                            if (ct.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                            {
                                TextBox tb = ct as TextBox;
                                tb.Enabled = false;
                                continue;
                            }
                            if (ct.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                            {
                                ComboBox cb = ct as ComboBox;
                                cb.Enabled = false;
                                continue;
                            }
                            if (ct.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                            {
                                CheckBox cbx = ct as CheckBox;
                                cbx.Enabled = false;
                                continue;
                            }
                            if (ct.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                            {
                                RadioButton rb = ct as RadioButton;
                                rb.Enabled = false;
                                continue;
                            }
                            if (ct.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                            {
                                TableLayoutPanel tp = ct as TableLayoutPanel;
                                tp.Enabled = false;
                                foreach (Control cx in tp.Controls)
                                {
                                    if (cx.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                    {
                                        TextBox tb = cx as TextBox;
                                        tb.Enabled = false;
                                        continue;
                                    }
                                    if (cx.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                    {
                                        ComboBox cb = cx as ComboBox;
                                        cb.Enabled = false;
                                        continue;
                                    }
                                    if (cx.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                    {
                                        CheckBox cbx = cx as CheckBox;
                                        cbx.Enabled = false;
                                        continue;
                                    }
                                    if (cx.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                    {
                                        RadioButton rb = cx as RadioButton;
                                        rb.Enabled = false;
                                        continue;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public static void FormGroupboxEnableTrue( Form fm, GroupBox[] gb )
        {
            foreach (GroupBox gbx in gb)
            {
                foreach (Control cn in gbx.Controls)
                {
                    if (cn.GetType( ) == typeof( System.Windows.Forms.GroupBox ))
                    {
                        GroupBox gbs = cn as GroupBox;
                        foreach (Control con in gbs.Controls)
                        {
                            if (con.GetType( ) == typeof( System.Windows.Forms.GroupBox ))
                            {
                                GroupBox gbsx = con as GroupBox;
                                foreach (Control cont in gbsx.Controls)
                                {
                                    if (cont.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                    {
                                        TextBox tb = cont as TextBox;
                                        tb.Enabled = true;
                                        continue;
                                    }
                                    if (cont.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                    {
                                        ComboBox cb = cont as ComboBox;
                                        cb.Enabled = true;
                                        continue;
                                    }
                                    if (cont.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                    {
                                        CheckBox ck = cont as CheckBox;
                                        ck.Enabled = true;
                                        continue;
                                    }
                                    if (cont.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                    {
                                        RadioButton rb = cont as RadioButton;
                                        rb.Enabled = true;
                                        continue;
                                    }
                                    if (cont.GetType( ) == typeof( System.Windows.Forms.Button ))
                                    {
                                        Button bt = cont as Button;
                                        bt.Enabled = true;
                                        continue;
                                    }
                                    if (cont.GetType( ) == typeof( System.Windows.Forms.DateTimePicker ))
                                    {
                                        DateTimePicker dp = cont as DateTimePicker;
                                        dp.Enabled = true;
                                        continue;
                                    }
                                    if (cont.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                                    {
                                        TableLayoutPanel tl = cont as TableLayoutPanel;
                                        tl.Enabled = true;

                                        foreach (Control ct in tl.Controls)
                                        {
                                            if (ct.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                            {
                                                TextBox tb = ct as TextBox;
                                                tb.Enabled = true;
                                                continue;
                                            }
                                            if (ct.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                            {
                                                ComboBox cb = ct as ComboBox;
                                                cb.Enabled = true;
                                                continue;
                                            }
                                            if (ct.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                            {
                                                CheckBox cbx = ct as CheckBox;
                                                cbx.Enabled = true;
                                                continue;
                                            }
                                            if (ct.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                            {
                                                RadioButton rb = ct as RadioButton;
                                                rb.Enabled = true;
                                                continue;
                                            }
                                            if (ct.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                                            {
                                                TableLayoutPanel tp = ct as TableLayoutPanel;
                                                tp.Enabled = true;
                                                foreach (Control cx in tp.Controls)
                                                {
                                                    if (cx.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                                    {
                                                        TextBox tb = cx as TextBox;
                                                        tb.Enabled = true;
                                                        continue;
                                                    }
                                                    if (cx.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                                    {
                                                        ComboBox cb = cx as ComboBox;
                                                        cb.Enabled = true;
                                                        continue;
                                                    }
                                                    if (cx.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                                    {
                                                        CheckBox cbx = cx as CheckBox;
                                                        cbx.Enabled = true;
                                                        continue;
                                                    }
                                                    if (cx.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                                    {
                                                        RadioButton rb = cx as RadioButton;
                                                        rb.Enabled = true;
                                                        continue;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            if (con.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                            {
                                TextBox tb = con as TextBox;
                                tb.Enabled = true;
                                continue;
                            }
                            if (con.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                            {
                                ComboBox cb = con as ComboBox;
                                cb.Enabled = true;
                                continue;
                            }
                            if (con.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                            {
                                CheckBox ck = con as CheckBox;
                                ck.Enabled = true;
                                continue;
                            }
                            if (con.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                            {
                                RadioButton rb = con as RadioButton;
                                rb.Enabled = true;
                                continue;
                            }
                            if (con.GetType( ) == typeof( System.Windows.Forms.Button ))
                            {
                                Button bt = con as Button;
                                bt.Enabled = true;
                                continue;
                            }
                            if (con.GetType( ) == typeof( System.Windows.Forms.DateTimePicker ))
                            {
                                DateTimePicker dp = con as DateTimePicker;
                                dp.Enabled = true;
                                continue;
                            }
                            if (con.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                            {
                                TableLayoutPanel tl = con as TableLayoutPanel;
                                tl.Enabled = true;

                                foreach (Control ct in tl.Controls)
                                {
                                    if (ct.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                    {
                                        TextBox tb = ct as TextBox;
                                        tb.Enabled = true;
                                        continue;
                                    }
                                    if (ct.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                    {
                                        ComboBox cb = ct as ComboBox;
                                        cb.Enabled = true;
                                        continue;
                                    }
                                    if (ct.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                    {
                                        CheckBox cbx = ct as CheckBox;
                                        cbx.Enabled = true;
                                        continue;
                                    }
                                    if (ct.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                    {
                                        RadioButton rb = ct as RadioButton;
                                        rb.Enabled = true;
                                        continue;
                                    }
                                    if (ct.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                                    {
                                        TableLayoutPanel tp = ct as TableLayoutPanel;
                                        tp.Enabled = true;
                                        foreach (Control cx in tp.Controls)
                                        {
                                            if (cx.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                            {
                                                TextBox tb = cx as TextBox;
                                                tb.Enabled = true;
                                                continue;
                                            }
                                            if (cx.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                            {
                                                ComboBox cb = cx as ComboBox;
                                                cb.Enabled = true;
                                                continue;
                                            }
                                            if (cx.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                            {
                                                CheckBox cbx = cx as CheckBox;
                                                cbx.Enabled = true;
                                                continue;
                                            }
                                            if (cx.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                            {
                                                RadioButton rb = cx as RadioButton;
                                                rb.Enabled = true;
                                                continue;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (cn.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                    {
                        TextBox tb = cn as TextBox;
                        tb.Enabled = true;
                        continue;
                    }
                    if (cn.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                    {
                        ComboBox cb = cn as ComboBox;
                        cb.Enabled = true;
                        continue;
                    }
                    if (cn.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                    {
                        CheckBox ck = cn as CheckBox;
                        ck.Enabled = true;
                        continue;
                    }
                    if (cn.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                    {
                        RadioButton rb = cn as RadioButton;
                        rb.Enabled = true;
                        continue;
                    }
                    if (cn.GetType( ) == typeof( System.Windows.Forms.Button ))
                    {
                        Button bt = cn as Button;
                        bt.Enabled = true;
                        continue;
                    }
                    if (cn.GetType( ) == typeof( System.Windows.Forms.DateTimePicker ))
                    {
                        DateTimePicker dp = cn as DateTimePicker;
                        dp.Enabled = true;
                        continue;
                    }
                    if (cn.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                    {
                        TableLayoutPanel tl = cn as TableLayoutPanel;
                        tl.Enabled = true;

                        foreach (Control ct in tl.Controls)
                        {
                            if (ct.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                            {
                                TextBox tb = ct as TextBox;
                                tb.Enabled = true;
                                continue;
                            }
                            if (ct.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                            {
                                ComboBox cb = ct as ComboBox;
                                cb.Enabled = true;
                                continue;
                            }
                            if (ct.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                            {
                                CheckBox cbx = ct as CheckBox;
                                cbx.Enabled = true;
                                continue;
                            }
                            if (ct.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                            {
                                RadioButton rb = ct as RadioButton;
                                rb.Enabled = true;
                                continue;
                            }
                            if (ct.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                            {
                                TableLayoutPanel tp = ct as TableLayoutPanel;
                                tp.Enabled = true;
                                foreach (Control cx in tp.Controls)
                                {
                                    if (cx.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                    {
                                        TextBox tb = cx as TextBox;
                                        tb.Enabled = true;
                                        continue;
                                    }
                                    if (cx.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                    {
                                        ComboBox cb = cx as ComboBox;
                                        cb.Enabled = true;
                                        continue;
                                    }
                                    if (cx.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                    {
                                        CheckBox cbx = cx as CheckBox;
                                        cbx.Enabled = true;
                                        continue;
                                    }
                                    if (cx.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                    {
                                        RadioButton rb = cx as RadioButton;
                                        rb.Enabled = true;
                                        continue;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public static void FormControlEnableTrue( Form fm, Control[] gb )
        {
            foreach (Control cn in gb)
            {
                if (cn.GetType( ) == typeof( System.Windows.Forms.GroupBox ))
                {
                    GroupBox gbs = cn as GroupBox;
                    foreach (Control con in gbs.Controls)
                    {
                        if (con.GetType( ) == typeof( System.Windows.Forms.GroupBox ))
                        {
                            GroupBox gbsx = con as GroupBox;
                            foreach (Control cont in gbsx.Controls)
                            {
                                if (cont.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                {
                                    TextBox tb = cont as TextBox;
                                    tb.Enabled = true;
                                    continue;
                                }
                                if (cont.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                {
                                    ComboBox cb = cont as ComboBox;
                                    cb.Enabled = true;
                                    continue;
                                }
                                if (cont.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                {
                                    CheckBox ck = cont as CheckBox;
                                    ck.Enabled = true;
                                    continue;
                                }
                                if (cont.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                {
                                    RadioButton rb = cont as RadioButton;
                                    rb.Enabled = true;
                                    continue;
                                }
                                if (cont.GetType( ) == typeof( System.Windows.Forms.Button ))
                                {
                                    Button bt = cont as Button;
                                    bt.Enabled = true;
                                    continue;
                                }
                                if (cont.GetType( ) == typeof( System.Windows.Forms.DateTimePicker ))
                                {
                                    DateTimePicker dp = cont as DateTimePicker;
                                    dp.Enabled = true;
                                    continue;
                                }
                                if (cont.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                                {
                                    TableLayoutPanel tl = cont as TableLayoutPanel;
                                    tl.Enabled = true;

                                    foreach (Control ct in tl.Controls)
                                    {
                                        if (ct.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                        {
                                            TextBox tb = ct as TextBox;
                                            tb.Enabled = true;
                                            continue;
                                        }
                                        if (ct.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                        {
                                            ComboBox cb = ct as ComboBox;
                                            cb.Enabled = true;
                                            continue;
                                        }
                                        if (ct.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                        {
                                            CheckBox cbx = ct as CheckBox;
                                            cbx.Enabled = true;
                                            continue;
                                        }
                                        if (ct.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                        {
                                            RadioButton rb = ct as RadioButton;
                                            rb.Enabled = true;
                                            continue;
                                        }
                                        if (ct.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                                        {
                                            TableLayoutPanel tp = ct as TableLayoutPanel;
                                            tp.Enabled = true;
                                            foreach (Control cx in tp.Controls)
                                            {
                                                if (cx.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                                {
                                                    TextBox tb = cx as TextBox;
                                                    tb.Enabled = true;
                                                    continue;
                                                }
                                                if (cx.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                                {
                                                    ComboBox cb = cx as ComboBox;
                                                    cb.Enabled = true;
                                                    continue;
                                                }
                                                if (cx.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                                {
                                                    CheckBox cbx = cx as CheckBox;
                                                    cbx.Enabled = true;
                                                    continue;
                                                }
                                                if (cx.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                                {
                                                    RadioButton rb = cx as RadioButton;
                                                    rb.Enabled = true;
                                                    continue;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (con.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                        {
                            TextBox tb = con as TextBox;
                            tb.Enabled = true;
                            continue;
                        }
                        if (con.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                        {
                            ComboBox cb = con as ComboBox;
                            cb.Enabled = true;
                            continue;
                        }
                        if (con.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                        {
                            CheckBox ck = con as CheckBox;
                            ck.Enabled = true;
                            continue;
                        }
                        if (con.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                        {
                            RadioButton rb = con as RadioButton;
                            rb.Enabled = true;
                            continue;
                        }
                        if (con.GetType( ) == typeof( System.Windows.Forms.Button ))
                        {
                            Button bt = con as Button;
                            bt.Enabled = true;
                            continue;
                        }
                        if (con.GetType( ) == typeof( System.Windows.Forms.DateTimePicker ))
                        {
                            DateTimePicker dp = con as DateTimePicker;
                            dp.Enabled = true;
                            continue;
                        }
                        if (con.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                        {
                            TableLayoutPanel tl = con as TableLayoutPanel;
                            tl.Enabled = true;

                            foreach (Control ct in tl.Controls)
                            {
                                if (ct.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                {
                                    TextBox tb = ct as TextBox;
                                    tb.Enabled = true;
                                    continue;
                                }
                                if (ct.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                {
                                    ComboBox cb = ct as ComboBox;
                                    cb.Enabled = true;
                                    continue;
                                }
                                if (ct.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                {
                                    CheckBox cbx = ct as CheckBox;
                                    cbx.Enabled = true;
                                    continue;
                                }
                                if (ct.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                {
                                    RadioButton rb = ct as RadioButton;
                                    rb.Enabled = true;
                                    continue;
                                }
                                if (ct.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                                {
                                    TableLayoutPanel tp = ct as TableLayoutPanel;
                                    tp.Enabled = true;
                                    foreach (Control cx in tp.Controls)
                                    {
                                        if (cx.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                        {
                                            TextBox tb = cx as TextBox;
                                            tb.Enabled = true;
                                            continue;
                                        }
                                        if (cx.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                        {
                                            ComboBox cb = cx as ComboBox;
                                            cb.Enabled = true;
                                            continue;
                                        }
                                        if (cx.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                        {
                                            CheckBox cbx = cx as CheckBox;
                                            cbx.Enabled = true;
                                            continue;
                                        }
                                        if (cx.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                        {
                                            RadioButton rb = cx as RadioButton;
                                            rb.Enabled = true;
                                            continue;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (cn.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                {
                    TextBox tb = cn as TextBox;
                    tb.Enabled = true;
                    continue;
                }
                if (cn.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                {
                    ComboBox cb = cn as ComboBox;
                    cb.Enabled = true;
                    continue;
                }
                if (cn.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                {
                    CheckBox ck = cn as CheckBox;
                    ck.Enabled = true;
                    continue;
                }
                if (cn.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                {
                    RadioButton rb = cn as RadioButton;
                    rb.Enabled = true;
                    continue;
                }
                if (cn.GetType( ) == typeof( System.Windows.Forms.Button ))
                {
                    Button bt = cn as Button;
                    bt.Enabled = true;
                    continue;
                }
                if (cn.GetType( ) == typeof( System.Windows.Forms.DateTimePicker ))
                {
                    DateTimePicker dp = cn as DateTimePicker;
                    dp.Enabled = true;
                    continue;
                }
                if (cn.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                {
                    TableLayoutPanel tl = cn as TableLayoutPanel;
                    tl.Enabled = true;

                    foreach (Control ct in tl.Controls)
                    {
                        if (ct.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                        {
                            TextBox tb = ct as TextBox;
                            tb.Enabled = true;
                            continue;
                        }
                        if (ct.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                        {
                            ComboBox cb = ct as ComboBox;
                            cb.Enabled = true;
                            continue;
                        }
                        if (ct.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                        {
                            CheckBox cbx = ct as CheckBox;
                            cbx.Enabled = true;
                            continue;
                        }
                        if (ct.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                        {
                            RadioButton rb = ct as RadioButton;
                            rb.Enabled = true;
                            continue;
                        }
                        if (ct.GetType( ) == typeof( System.Windows.Forms.TableLayoutPanel ))
                        {
                            TableLayoutPanel tp = ct as TableLayoutPanel;
                            tp.Enabled = true;
                            foreach (Control cx in tp.Controls)
                            {
                                if (cx.GetType( ) == typeof( System.Windows.Forms.TextBox ))
                                {
                                    TextBox tb = cx as TextBox;
                                    tb.Enabled = true;
                                    continue;
                                }
                                if (cx.GetType( ) == typeof( System.Windows.Forms.ComboBox ))
                                {
                                    ComboBox cb = cx as ComboBox;
                                    cb.Enabled = true;
                                    continue;
                                }
                                if (cx.GetType( ) == typeof( System.Windows.Forms.CheckBox ))
                                {
                                    CheckBox cbx = cx as CheckBox;
                                    cbx.Enabled = true;
                                    continue;
                                }
                                if (cx.GetType( ) == typeof( System.Windows.Forms.RadioButton ))
                                {
                                    RadioButton rb = cx as RadioButton;
                                    rb.Enabled = true;
                                    continue;
                                }
                            }
                        }
                    }
                }
            }
        }
    }

}
