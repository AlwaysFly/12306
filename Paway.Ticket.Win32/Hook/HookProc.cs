using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Paway.Ticket.Win32
{
    /// <summary>
    /// ����ί������
    /// </summary>
    /// <param name="nCode"></param>
    /// <param name="wParam"></param>
    /// <param name="lParam"></param>
    /// <returns></returns>
    public delegate int HookProc(int nCode, Int32 wParam, IntPtr lParam);

    /// <summary>
    /// �������¼�ί������
    /// </summary>
    /// <param name="x">x����</param>
    /// <param name="y">y����</param>
    public delegate void MouseUpdateEventHandler(int x, int y);

}

