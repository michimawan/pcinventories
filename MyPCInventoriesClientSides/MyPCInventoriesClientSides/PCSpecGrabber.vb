Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Management

Public Class PCSpecGrabber
    Function getProcessor() As String
        Dim s As New ManagementObjectSearcher("SELECT * FROM Win32_Processor")
        Dim strs = ""
        For Each obj In s.Get
            strs = strs + "<PROC>" + obj("name").ToString() + "<PROC>" + vbCr
        Next
        Return strs
    End Function

    Function getHardDrive() As String
        Dim s As New ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive")
        Dim stringss = ""
        For Each obj In s.Get
            stringss = stringss + "<HDD>" + obj("caption").ToString() + ", " + CInt(obj("size") / 1000000000).ToString + " GB<HDD>" + vbCr
        Next

        Return stringss
    End Function

    Function getVGA() As String
        Dim s As New ManagementObjectSearcher("SELECT * FROM Win32_VideoController")
        Dim stringss = ""
        For Each obj In s.Get
            stringss = stringss + "<VGA>" + obj("caption").ToString() + ", " + CInt(obj("adapterram") / 1000000).ToString + " MB <VGA>" + vbCr
        Next

        Return stringss
    End Function

    Function getRAM() As String
        Dim s As New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory")
        Dim total = 0
        Dim stringss = ""
        For Each obj In s.Get
            total = total + (CDbl(obj("capacity")) / 1000000)
        Next
        total = CInt(total / 1000)
        stringss = stringss + "<RAM>" + total.ToString + " GB<RAM>" + vbCr

        Return stringss
    End Function

    Function getOS() As String
        Dim s As New ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem")
        Dim Stringss = ""
        For Each obj In s.Get
            Stringss = Stringss + "<OS>" + obj("caption").ToString() + " " + obj("version").ToString() + "<OS>" + vbCr
            Stringss = Stringss + "<Owner>" + obj("csname").ToString() + "<Owner>" + vbCr
        Next

        Return Stringss
    End Function

    Function SendSpec() As String
        Dim res = ""
        res += getProcessor()
        res += getHardDrive()
        res += getVGA()
        res += getRAM()
        res += getOS()

        Return res
    End Function
End Class
