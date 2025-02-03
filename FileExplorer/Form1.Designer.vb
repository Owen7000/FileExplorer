<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnlTopPanel = New System.Windows.Forms.Panel()
        Me.scMainAppContent = New System.Windows.Forms.SplitContainer()
        Me.gbSelectedFile = New System.Windows.Forms.GroupBox()
        Me.rtbSelectedFile = New System.Windows.Forms.RichTextBox()
        Me.tvDirectoryInfo = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.scMainAppContent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scMainAppContent.Panel1.SuspendLayout()
        Me.scMainAppContent.Panel2.SuspendLayout()
        Me.scMainAppContent.SuspendLayout()
        Me.gbSelectedFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTopPanel
        '
        Me.pnlTopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopPanel.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopPanel.Name = "pnlTopPanel"
        Me.pnlTopPanel.Size = New System.Drawing.Size(800, 94)
        Me.pnlTopPanel.TabIndex = 0
        '
        'scMainAppContent
        '
        Me.scMainAppContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scMainAppContent.Location = New System.Drawing.Point(0, 94)
        Me.scMainAppContent.Name = "scMainAppContent"
        '
        'scMainAppContent.Panel1
        '
        Me.scMainAppContent.Panel1.Controls.Add(Me.gbSelectedFile)
        '
        'scMainAppContent.Panel2
        '
        Me.scMainAppContent.Panel2.Controls.Add(Me.tvDirectoryInfo)
        Me.scMainAppContent.Size = New System.Drawing.Size(800, 481)
        Me.scMainAppContent.SplitterDistance = 266
        Me.scMainAppContent.TabIndex = 1
        '
        'gbSelectedFile
        '
        Me.gbSelectedFile.Controls.Add(Me.rtbSelectedFile)
        Me.gbSelectedFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbSelectedFile.Location = New System.Drawing.Point(0, 0)
        Me.gbSelectedFile.Name = "gbSelectedFile"
        Me.gbSelectedFile.Size = New System.Drawing.Size(266, 481)
        Me.gbSelectedFile.TabIndex = 0
        Me.gbSelectedFile.TabStop = False
        Me.gbSelectedFile.Text = "Selected File"
        '
        'rtbSelectedFile
        '
        Me.rtbSelectedFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbSelectedFile.Enabled = False
        Me.rtbSelectedFile.Location = New System.Drawing.Point(3, 22)
        Me.rtbSelectedFile.Name = "rtbSelectedFile"
        Me.rtbSelectedFile.ReadOnly = True
        Me.rtbSelectedFile.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtbSelectedFile.Size = New System.Drawing.Size(260, 456)
        Me.rtbSelectedFile.TabIndex = 0
        Me.rtbSelectedFile.Text = ""
        '
        'tvDirectoryInfo
        '
        Me.tvDirectoryInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tvDirectoryInfo.ImageIndex = 2
        Me.tvDirectoryInfo.ImageList = Me.ImageList1
        Me.tvDirectoryInfo.Location = New System.Drawing.Point(0, 0)
        Me.tvDirectoryInfo.Name = "tvDirectoryInfo"
        Me.tvDirectoryInfo.SelectedImageIndex = 1
        Me.tvDirectoryInfo.ShowNodeToolTips = True
        Me.tvDirectoryInfo.ShowPlusMinus = False
        Me.tvDirectoryInfo.Size = New System.Drawing.Size(530, 375)
        Me.tvDirectoryInfo.StateImageList = Me.ImageList1
        Me.tvDirectoryInfo.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "css.png")
        Me.ImageList1.Images.SetKeyName(1, "fo.png")
        Me.ImageList1.Images.SetKeyName(2, "f.png")
        Me.ImageList1.Images.SetKeyName(3, "default.png")
        Me.ImageList1.Images.SetKeyName(4, "cog.png")
        Me.ImageList1.Images.SetKeyName(5, "f-user.png")
        Me.ImageList1.Images.SetKeyName(6, "fo-user.png")
        Me.ImageList1.Images.SetKeyName(7, "text.png")
        Me.ImageList1.Images.SetKeyName(8, "fo-cloud.png")
        Me.ImageList1.Images.SetKeyName(9, "f-cloud.png")
        Me.ImageList1.Images.SetKeyName(10, "git.png")
        Me.ImageList1.Images.SetKeyName(11, "gitignore.png")
        Me.ImageList1.Images.SetKeyName(12, "exe.png")
        Me.ImageList1.Images.SetKeyName(13, "fo-vsc.png")
        Me.ImageList1.Images.SetKeyName(14, "f-vsc.png")
        Me.ImageList1.Images.SetKeyName(15, "f-config.png")
        Me.ImageList1.Images.SetKeyName(16, "fo-config.png")
        Me.ImageList1.Images.SetKeyName(17, "fo-app.png")
        Me.ImageList1.Images.SetKeyName(18, "f-app.png")
        Me.ImageList1.Images.SetKeyName(19, "fo-docs.png")
        Me.ImageList1.Images.SetKeyName(20, "f-docs.png")
        Me.ImageList1.Images.SetKeyName(21, "py.png")
        Me.ImageList1.Images.SetKeyName(22, "html.png")
        Me.ImageList1.Images.SetKeyName(23, "yaml.png")
        Me.ImageList1.Images.SetKeyName(24, "pdf.png")
        Me.ImageList1.Images.SetKeyName(25, "php.png")
        Me.ImageList1.Images.SetKeyName(26, "md.png")
        Me.ImageList1.Images.SetKeyName(27, "vid.png")
        Me.ImageList1.Images.SetKeyName(28, "audio.png")
        Me.ImageList1.Images.SetKeyName(29, "img.png")
        Me.ImageList1.Images.SetKeyName(30, "shell.png")
        Me.ImageList1.Images.SetKeyName(31, "ps1.png")
        Me.ImageList1.Images.SetKeyName(32, "data.png")
        Me.ImageList1.Images.SetKeyName(33, "fo-code.png")
        Me.ImageList1.Images.SetKeyName(34, "f-code.png")
        Me.ImageList1.Images.SetKeyName(35, "f-test.png")
        Me.ImageList1.Images.SetKeyName(36, "fo-test.png")
        Me.ImageList1.Images.SetKeyName(37, "f-py.png")
        Me.ImageList1.Images.SetKeyName(38, "fo-py.png")
        Me.ImageList1.Images.SetKeyName(39, "py2.png")
        Me.ImageList1.Images.SetKeyName(40, "java.png")
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 475)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 100)
        Me.Panel1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.scMainAppContent)
        Me.Controls.Add(Me.pnlTopPanel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.scMainAppContent.Panel1.ResumeLayout(False)
        Me.scMainAppContent.Panel2.ResumeLayout(False)
        CType(Me.scMainAppContent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMainAppContent.ResumeLayout(False)
        Me.gbSelectedFile.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTopPanel As Panel
    Friend WithEvents scMainAppContent As SplitContainer
    Friend WithEvents tvDirectoryInfo As TreeView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel1 As Panel
    Friend WithEvents gbSelectedFile As GroupBox
    Friend WithEvents rtbSelectedFile As RichTextBox
End Class
