Option Strict Off
Option Explicit On 
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Public Class PrintForm
    <StructLayout(LayoutKind.Sequential)> Structure RECT_Type
        Dim left As Integer
        Dim top As Integer
        Dim right As Integer
        Dim bottom As Integer
    End Structure
    Declare Function GetActiveWindow Lib "User32" () As Integer
    Declare Function GetDesktopWindow Lib "User32" () As Integer
    Declare Function CreateCompatibleDC Lib "Gdi32" _
            (ByVal hdc As Integer) As Integer
    Declare Function CreateCompatibleBitmap Lib "Gdi32" _
            (ByVal hdc As Integer, ByVal nWidth As Integer, _
            ByVal nHeight As Integer) As Integer
    Declare Function SelectObject Lib "Gdi32" (ByVal hdc As Integer, _
            ByVal hObject As Integer) As Integer
    Declare Function BitBlt Lib "Gdi32" (ByVal hDestDC As Integer, _
            ByVal X As Integer, ByVal Y As Integer, _
            ByVal nWidth As Integer, ByVal nHeight As Integer, _
            ByVal hSrcDC As Integer, ByVal XSrc As Integer, _
            ByVal YSrc As Integer, ByVal dwRop As Integer) As Integer
    Declare Function ReleaseDC Lib "User32" (ByVal Hwnd As Integer, _
            ByVal hdc As Integer) As Integer
    Declare Function DeleteDC Lib "Gdi32" (ByVal hdc As Integer) As Integer
    Declare Sub GetWindowRect Lib "User32" (ByVal Hwnd As Integer, _
            ByRef lpRect As RECT_Type)
    Public Declare Function CreateDC Lib "gdi32" Alias "CreateDCA" _
            (ByVal lpDriverName As String, ByVal lpDeviceName As Integer, _
            ByVal lpOutput As Integer, ByVal lpInitData As Integer) _
            As Integer
    Private WithEvents MyDoc As Printing.PrintDocument
    Private m_img As Image
    Public Sub New()
        MyDoc = New Printing.PrintDocument
    End Sub
    Protected Sub MyDoc_PrintPage(ByVal sender As Object, _
    ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
    Handles MyDoc.PrintPage
        e.Graphics.DrawImage(m_img, New PointF(0, 0))
    End Sub
    Public Function getImageFromForm(ByVal fm As Form) As Image
        Dim intWidth, intHeight As Integer
        Dim hwndForm, hwndDesktop As Integer
        Dim hdc, hdcMem, hBitmap As Integer
        Dim rect As RECT_Type
        Dim img As Image
        fm.Activate()
        'Get HWnds to the form and to the desktop
        hwndForm = GetActiveWindow()
        hwndDesktop = GetDesktopWindow()
        'Get the bounding rectangle and width and height
        GetWindowRect(hwndForm, rect)
        intWidth = rect.right - rect.left
        intHeight = rect.bottom - rect.top
        'copy the display of the form to a HBitmap
        hdc = CreateDC("DISPLAY", 0, 0, 0)
        hdcMem = CreateCompatibleDC(hdc)
        hBitmap = CreateCompatibleBitmap(hdc, intWidth, intHeight)
        SelectObject(hdcMem, hBitmap)
        BitBlt(hdcMem, 0, 0, intWidth, intHeight, hdc, _
        fm.Location.X, fm.Location.Y, &HCC0020)
        'copy the bitmap to an Image
        img = img.FromHbitmap(New IntPtr(hBitmap))
        'clean up
        DeleteDC(hdcMem)
        ReleaseDC(hwndForm, hdc)
        Return img
    End Function
    Function Print(ByVal fm As System.Windows.Forms.Form) As Boolean
        m_img = getImageFromForm(fm)
        'Use a try catch block to detect printing errors
        Try
            MyDoc.Print()
        Catch ex As Exception
            MsgBox("Exception occurred: " & ex.Message)
        End Try
    End Function
End Class

