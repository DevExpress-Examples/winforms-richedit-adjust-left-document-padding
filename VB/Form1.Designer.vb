Namespace RichEditLeftPadding

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RichEditLeftPadding.Form1))
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.documentViewsBar1 = New DevExpress.XtraRichEdit.UI.DocumentViewsBar()
            Me.switchToSimpleViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem()
            Me.switchToDraftViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem()
            Me.switchToPrintLayoutViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl1.Location = New System.Drawing.Point(0, 26)
            Me.richEditControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.richEditControl1.MenuManager = Me.barManager1
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Size = New System.Drawing.Size(734, 300)
            Me.richEditControl1.TabIndex = 0
            Me.richEditControl1.Text = "richEditControl1"
            AddHandler Me.richEditControl1.DocumentLoaded, New System.EventHandler(AddressOf Me.richEditControl1_DocumentLoaded)
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.documentViewsBar1})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.switchToSimpleViewItem1, Me.switchToDraftViewItem1, Me.switchToPrintLayoutViewItem1, Me.barButtonItem1})
            Me.barManager1.MaxItemId = 13
            ' 
            ' documentViewsBar1
            ' 
            Me.documentViewsBar1.DockCol = 0
            Me.documentViewsBar1.DockRow = 0
            Me.documentViewsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.documentViewsBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.switchToSimpleViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.switchToDraftViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.switchToPrintLayoutViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1)})
            ' 
            ' switchToSimpleViewItem1
            ' 
            Me.switchToSimpleViewItem1.Glyph = CType((resources.GetObject("switchToSimpleViewItem1.Glyph")), System.Drawing.Image)
            Me.switchToSimpleViewItem1.Id = 9
            Me.switchToSimpleViewItem1.LargeGlyph = CType((resources.GetObject("switchToSimpleViewItem1.LargeGlyph")), System.Drawing.Image)
            Me.switchToSimpleViewItem1.Name = "switchToSimpleViewItem1"
            ' 
            ' switchToDraftViewItem1
            ' 
            Me.switchToDraftViewItem1.Glyph = CType((resources.GetObject("switchToDraftViewItem1.Glyph")), System.Drawing.Image)
            Me.switchToDraftViewItem1.Id = 10
            Me.switchToDraftViewItem1.LargeGlyph = CType((resources.GetObject("switchToDraftViewItem1.LargeGlyph")), System.Drawing.Image)
            Me.switchToDraftViewItem1.Name = "switchToDraftViewItem1"
            ' 
            ' switchToPrintLayoutViewItem1
            ' 
            Me.switchToPrintLayoutViewItem1.Glyph = CType((resources.GetObject("switchToPrintLayoutViewItem1.Glyph")), System.Drawing.Image)
            Me.switchToPrintLayoutViewItem1.Id = 11
            Me.switchToPrintLayoutViewItem1.LargeGlyph = CType((resources.GetObject("switchToPrintLayoutViewItem1.LargeGlyph")), System.Drawing.Image)
            Me.switchToPrintLayoutViewItem1.Name = "switchToPrintLayoutViewItem1"
            ' 
            ' richEditBarController1
            ' 
            Me.richEditBarController1.BarItems.Add(Me.switchToSimpleViewItem1)
            Me.richEditBarController1.BarItems.Add(Me.switchToDraftViewItem1)
            Me.richEditBarController1.BarItems.Add(Me.switchToPrintLayoutViewItem1)
            Me.richEditBarController1.RichEditControl = Me.richEditControl1
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "Set paragraph indent"
            Me.barButtonItem1.Id = 12
            Me.barButtonItem1.Name = "barButtonItem1"
            AddHandler Me.barButtonItem1.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.barButtonItem1_ItemClick)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(734, 326)
            Me.Controls.Add(Me.richEditControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.richEditBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl

        Private barManager1 As DevExpress.XtraBars.BarManager

        Private barDockControlTop As DevExpress.XtraBars.BarDockControl

        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl

        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl

        Private barDockControlRight As DevExpress.XtraBars.BarDockControl

        Private documentViewsBar1 As DevExpress.XtraRichEdit.UI.DocumentViewsBar

        Private switchToSimpleViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem

        Private switchToDraftViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem

        Private switchToPrintLayoutViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem

        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController

        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace
