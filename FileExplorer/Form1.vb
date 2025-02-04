Imports System.IO
Imports Microsoft.Win32

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rootNode As New TreeNode("c:/")
        addDirectoryInfoToTreeView("c:/", rootNode)
    End Sub



    Private Sub tvDirectoryInfo_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvDirectoryInfo.NodeMouseClick
        If e.Button = MouseButtons.Left Then
            If e.Node.IsExpanded Then
                e.Node.Collapse()
                e.Node.Nodes.Clear()
            Else
                e.Node.Expand()
                If e.Node.Tag = "Directory" Then
                    Try
                        addDirectoryInfoToTreeView(e.Node.FullPath.Replace("\", "/"), e.Node)
                    Catch ex As System.UnauthorizedAccessException
                        MessageBox.Show("Access to that directory is restricted and it cannot be opened.")
                    End Try
                End If
            End If

            If e.Node.Text.EndsWith(".txt") Then
                rtbSelectedFile.Text = readTextFile("c:/" + e.Node.Text)
            End If
        End If
    End Sub

    Private Sub tvDirectoryInfo_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvDirectoryInfo.NodeMouseDoubleClick
        If e.Button = MouseButtons.Left Then
            If e.Node.Tag = "File" Then
                OpenFile("c:/" + e.Node.Text)
            End If
        End If
    End Sub

    Public Function readTextFile(path As String)
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText(path)

        Return fileReader
    End Function

    Private Sub OpenFile(ByVal File As String)
        Try
            Dim myProcess As New Process
            myProcess.StartInfo.FileName = File
            myProcess.StartInfo.UseShellExecute = True
            myProcess.StartInfo.RedirectStandardOutput = False
            myProcess.Start()
            myProcess.Dispose()
        Catch ex As System.ComponentModel.Win32Exception
            MessageBox.Show("There is no application available to open this type of file.")
        End Try
    End Sub

    Private Sub addDirectoryInfoToTreeView(path As String, rootNode As TreeNode)
        rootNode.Nodes.Clear()

        Dim FileLocation As DirectoryInfo = New DirectoryInfo(path)

        Dim subDirectories = FileLocation.GetDirectories()
        Dim dri As DirectoryInfo

        For Each dri In subDirectories
            Dim childNode As New TreeNode(dri.Name)
            childNode.Tag = "Directory"

            If dri.Name.StartsWith("User") Then
                childNode.ImageIndex = 5
                childNode.SelectedImageIndex = 6
            ElseIf dri.Name.Contains("OneDrive") Then
                childNode.ImageIndex = 9
                childNode.SelectedImageIndex = 8
            ElseIf dri.Name = ".vscode" Then
                childNode.ImageIndex = 14
                childNode.SelectedImageIndex = 13
            ElseIf dri.Name = ".config" Then
                childNode.ImageIndex = 15
                childNode.SelectedImageIndex = 16
            ElseIf dri.Name.StartsWith("App") Then
                childNode.ImageIndex = 18
                childNode.SelectedImageIndex = 17
            ElseIf dri.Name.StartsWith("Doc") Or dri.Name.StartsWith("doc") Then
                childNode.ImageIndex = 19
                childNode.SelectedImageIndex = 20
            ElseIf dri.Name.Contains("src") Or dri.Name.Contains("source") Or dri.Name.Contains("code") Then
                childNode.ImageIndex = 34
                childNode.SelectedImageIndex = 33
            ElseIf dri.Name = "__pycache__" Or dri.Name = ".venv" Then
                childNode.ImageIndex = 37
                childNode.SelectedImageIndex = 38
            Else
                childNode.ImageIndex = 2
            End If

            rootNode.Nodes.Add(childNode)
        Next

        ' Get a reference to each file in that directory.
        Dim fiArr As FileInfo() = FileLocation.GetFiles()
        ' Display the names of the files.
        Dim fri As FileInfo
        For Each fri In fiArr
            Debug.WriteLine(fri.Extension)
            Dim childNode As New TreeNode(fri.Name)
            childNode.Tag = "File"

            If fri.Extension = ".dll" Or fri.Extension = ".ini" Or fri.Extension = ".cfg" Then
                childNode.ImageIndex = 4
                childNode.SelectedImageIndex = 4
            ElseIf fri.Extension = ".txt" Or fri.Extension = ".tmp" Or fri.Extension = ".log" Then
                childNode.ImageIndex = 7
                childNode.SelectedImageIndex = 7
            ElseIf fri.Extension.StartsWith(".git") Then
                childNode.ImageIndex = 10
                childNode.SelectedImageIndex = 10
            ElseIf fri.Extension = ".gitignore" Then
                childNode.ImageIndex = 11
                childNode.SelectedImageIndex = 11
            ElseIf fri.Extension = ".exe" Then
                childNode.ImageIndex = 12
                childNode.SelectedImageIndex = 12
            ElseIf fri.Extension = ".py" Then
                childNode.ImageIndex = 21
                childNode.SelectedImageIndex = 21
            ElseIf fri.Extension = ".pyc" Then
                childNode.ImageIndex = 39
                childNode.SelectedImageIndex = 39
            ElseIf fri.Extension = ".html" Then
                childNode.ImageIndex = 22
                childNode.SelectedImageIndex = 22
            ElseIf fri.Extension = ".css" Then
                childNode.ImageIndex = 0
                childNode.SelectedImageIndex = 0
            ElseIf fri.Extension = ".php" Then
                childNode.ImageIndex = 25
                childNode.SelectedImageIndex = 25
            ElseIf fri.Extension = ".md" Then
                childNode.ImageIndex = 26
                childNode.SelectedImageIndex = 26
            ElseIf fri.Extension = ".pdf" Then
                childNode.ImageIndex = 24
                childNode.SelectedImageIndex = 24
            ElseIf fri.Extension = ".yml" Then
                childNode.ImageIndex = 23
                childNode.SelectedImageIndex = 23
            ElseIf fri.Extension = ".mp3" Then
                childNode.ImageIndex = 28
                childNode.SelectedImageIndex = 28
            ElseIf fri.Extension = ".png" Or fri.Extension = ".jpg" Or fri.Extension = ".jpeg" Or fri.Extension = ".gif" Then
                childNode.ImageIndex = 29
                childNode.SelectedImageIndex = 29
            ElseIf fri.Extension = ".bash" Or fri.Extension = ".cmd" Or fri.Extension = ".bat" Then
                childNode.ImageIndex = 30
                childNode.SelectedImageIndex = 30
            ElseIf fri.Extension = ".ps1" Then
                childNode.ImageIndex = 31
                childNode.SelectedImageIndex = 31
            ElseIf fri.Extension = ".sql" Or fri.Extension = ".db" Or fri.Extension = ".sqlite" Then
                childNode.ImageIndex = 32
                childNode.SelectedImageIndex = 32
            ElseIf fri.Extension = ".java" Or fri.Extension = ".jar" Then
                childNode.ImageIndex = 40
                childNode.SelectedImageIndex = 40
            Else
                childNode.ImageIndex = 3
                childNode.SelectedImageIndex = 3
            End If

            rootNode.Nodes.Add(childNode)
        Next fri

        Try
            tvDirectoryInfo.Nodes.Add(rootNode)
        Catch ex As Exception
        End Try
    End Sub

    Public Function GetFileOpenList(fileType As String)
        Dim fileOpenOptions As New List(Of String)
        Dim registryKeyPath As String = "Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\" & fileType & "\OpenWithList"

        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey(registryKeyPath)
        If key IsNot Nothing Then
            Console.WriteLine("Applications associated with " & fileType & ":")
            For Each valueName As String In key.GetValueNames()
                Console.WriteLine(valueName & " - " & key.GetValue(valueName))
                fileOpenOptions.Add(key.GetValue(valueName))
            Next
        Else
            Console.WriteLine("No associations found for " & fileType)
        End If

        Return fileOpenOptions
    End Function
End Class
