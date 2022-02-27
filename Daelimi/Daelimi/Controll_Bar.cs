﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daelimi
{
    public partial class DaelimiForm : Form
    {
        #region 상단바 상호작용
        private void Controll_Bar()
        {
            FormBar.MouseUp += FormBar_MouseUp;
            FormBar.MouseDown += FormBar_MouseDown;
            FormBar.MouseMove += FormBar_MouseMove;
            FormMinii.Click += Form_Minmon;
            FormClose.Click += Form_Close;
        }

        bool isMove;
        int MouseX, MouseY;


        private void FormBar_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }
        private void FormBar_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            MouseX = e.X;
            MouseY = e.Y;
        }
        private void FormBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove == true)
            {
                this.SetDesktopLocation(MousePosition.X - MouseX, MousePosition.Y - MouseY);
            }
        }
        private void Form_Close(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form_Minmon(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        // #region Form  외각 그림자 생성 코드
        //
        // [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        // private static extern IntPtr CreateRoundRectRgn
        // (
        //     int nLeftRect, // x-coordinate of upper-left corner
        //     int nTopRect, // y-coordinate of upper-left corner
        //     int nRightRect, // x-coordinate of lower-right corner
        //     int nBottomRect, // y-coordinate of lower-right corner
        //     int nWidthEllipse, // height of ellipse
        //     int nHeightEllipse // width of ellipse
        //  );
        //
        // [DllImport("dwmapi.dll")]
        // public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        //
        // [DllImport("dwmapi.dll")]
        // public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        //
        // [DllImport("dwmapi.dll")]
        // public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        //
        // private bool m_aeroEnabled;                     // variables for box shadow
        // private const int CS_DROPSHADOW = 0x00020000;
        // private const int WM_NCPAINT = 0x0085;
        // private const int WM_ACTIVATEAPP = 0x001C;
        //
        // public struct MARGINS                           // struct for box shadow
        // {
        //     public int leftWidth;
        //     public int rightWidth;
        //     public int topHeight;
        //     public int bottomHeight;
        // }
        //
        // private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        // private const int HTCLIENT = 0x1;
        // private const int HTCAPTION = 0x2;
        //
        // protected override CreateParams CreateParams
        // {
        //     get
        //     {
        //         m_aeroEnabled = CheckAeroEnabled();
        //
        //         CreateParams cp = base.CreateParams;
        //         if (!m_aeroEnabled)
        //             cp.ClassStyle |= CS_DROPSHADOW;
        //
        //         return cp;
        //     }
        // }
        //
        // private bool CheckAeroEnabled()
        // {
        //     if (Environment.OSVersion.Version.Major >= 6)
        //     {
        //         int enabled = 0;
        //         DwmIsCompositionEnabled(ref enabled);
        //         return (enabled == 1) ? true : false;
        //     }
        //     return false;
        // }
        //
        // protected override void WndProc(ref Message m)
        // {
        //     switch (m.Msg)
        //     {
        //         case WM_NCPAINT:                        // box shadow
        //             if (m_aeroEnabled)
        //             {
        //                 var v = 2;
        //                 DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
        //                 MARGINS margins = new MARGINS()
        //                 {
        //                     bottomHeight = 1,
        //                     leftWidth = 1,
        //                     rightWidth = 1,
        //                     topHeight = 1
        //                 };
        //                 DwmExtendFrameIntoClientArea(this.Handle, ref margins);
        //
        //             }
        //             break;
        //         default:
        //             break;
        //     }
        //     base.WndProc(ref m);
        //
        //     if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
        //         m.Result = (IntPtr)HTCAPTION;
        //
        // }
        //
        // #endregion
    }
}
