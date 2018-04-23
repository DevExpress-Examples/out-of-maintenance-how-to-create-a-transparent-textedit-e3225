Imports Microsoft.VisualBasic
Imports System
Imports System.Runtime.InteropServices

Imports System.Drawing


Namespace ZBobb
	''' <summary>
	''' Win32 support code.
	''' (C) 2003 Bob Bradley / ZBobb@hotmail.com
	''' </summary>
	Public Class win32

		Public Const WM_MOUSEMOVE As Integer = &H0200
		Public Const WM_LBUTTONDOWN As Integer = &H0201
		Public Const WM_LBUTTONUP As Integer = &H0202
		Public Const WM_RBUTTONDOWN As Integer = &H0204
		Public Const WM_LBUTTONDBLCLK As Integer = &H0203

		Public Const WM_MOUSELEAVE As Integer = &H02A3



		Public Const WM_PAINT As Integer = &H000F
		Public Const WM_ERASEBKGND As Integer = &H0014

		Public Const WM_PRINT As Integer = &H0317

		'const int EN_HSCROLL       =   0x0601;
		'const int EN_VSCROLL       =   0x0602;

		Public Const WM_HSCROLL As Integer = &H0114
		Public Const WM_VSCROLL As Integer = &H0115


		Public Const EM_GETSEL As Integer = &H00B0
		Public Const EM_LINEINDEX As Integer = &H00BB
		Public Const EM_LINEFROMCHAR As Integer = &H00C9

		Public Const EM_POSFROMCHAR As Integer = &H00D6



		<DllImport("USER32.DLL", EntryPoint:= "PostMessage")> _
		Public Shared Function PostMessage(ByVal hwnd As IntPtr, ByVal msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Boolean
		End Function

'        
'			BOOL PostMessage(          HWND hWnd,
'				UINT Msg,
'				WPARAM wParam,
'				LPARAM lParam
'				);
'		

		' Put this declaration in your class   //IntPtr
		<DllImport("USER32.DLL", EntryPoint:= "SendMessage")> _
		Public Shared Function SendMessage(ByVal hwnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
		End Function




		<DllImport("USER32.DLL", EntryPoint:= "GetCaretBlinkTime")> _
		Public Shared Function GetCaretBlinkTime() As UInteger
		End Function




		Private Const WM_PRINTCLIENT As Integer = &H0318

		Private Const PRF_CHECKVISIBLE As Long=&H00000001L
		Private Const PRF_NONCLIENT As Long = &H00000002L
		Private Const PRF_CLIENT As Long = &H00000004L
		Private Const PRF_ERASEBKGND As Long = &H00000008L
		Private Const PRF_CHILDREN As Long = &H00000010L
		Private Const PRF_OWNED As Long = &H00000020L

'          Will clean this up later doing something like this
'		enum  CaptureOptions : long
'		{
'			PRF_CHECKVISIBLE= 0x00000001L,
'			PRF_NONCLIENT	= 0x00000002L,
'			PRF_CLIENT		= 0x00000004L,
'			PRF_ERASEBKGND	= 0x00000008L,
'			PRF_CHILDREN	= 0x00000010L,
'			PRF_OWNED		= 0x00000020L
'		}
'		


		Public Shared Function CaptureWindow(ByVal control As System.Windows.Forms.Control, ByRef bitmap As System.Drawing.Bitmap) As Boolean
			'This function captures the contents of a window or control

			Dim g2 As Graphics = Graphics.FromImage(bitmap)

			'PRF_CHILDREN // PRF_NONCLIENT
			Dim meint As Integer = CInt(Fix(PRF_CLIENT Or PRF_ERASEBKGND)) '| PRF_OWNED ); // );
			Dim meptr As New System.IntPtr(meint)

			Dim hdc As System.IntPtr = g2.GetHdc()
			win32.SendMessage(control.Handle,win32.WM_PRINT,hdc,meptr)

			g2.ReleaseHdc(hdc)
			g2.Dispose()

			Return True

		End Function



	End Class
End Namespace
