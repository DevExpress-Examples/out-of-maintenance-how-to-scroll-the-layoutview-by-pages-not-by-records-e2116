Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl = New DevExpress.XtraGrid.GridControl()
			Me.layoutView = New DevExpress.XtraGrid.Views.Layout.LayoutView()
			Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			Me.imageEditor = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageEditor, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl
			' 
			Me.gridControl.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True
			Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl.Location = New System.Drawing.Point(0, 0)
			Me.gridControl.LookAndFeel.SkinName = "Office 2007 Blue"
			Me.gridControl.LookAndFeel.UseDefaultLookAndFeel = False
			Me.gridControl.MainView = Me.layoutView
			Me.gridControl.Name = "gridControl"
			Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.imageEditor})
			Me.gridControl.ServerMode = True
			Me.gridControl.Size = New System.Drawing.Size(548, 454)
			Me.gridControl.TabIndex = 5
			Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.layoutView})
			' 
			' layoutView
			' 
			Me.layoutView.CardCaptionFormat = "Card: {0}"
			Me.layoutView.GridControl = Me.gridControl
			Me.layoutView.Name = "layoutView"
			Me.layoutView.OptionsBehavior.AllowExpandCollapse = False
			Me.layoutView.OptionsBehavior.AllowPanCards = False
			Me.layoutView.OptionsBehavior.AllowRuntimeCustomization = False
			Me.layoutView.OptionsBehavior.AutoFocusCardOnScrolling = True
			Me.layoutView.OptionsBehavior.Editable = False
			Me.layoutView.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto
			Me.layoutView.OptionsCustomization.AllowFilter = False
			Me.layoutView.OptionsCustomization.AllowSort = False
			Me.layoutView.OptionsCustomization.ShowResetShrinkButtons = False
			Me.layoutView.OptionsItemText.TextToControlDistance = 0
			Me.layoutView.OptionsSelection.MultiSelect = True
			Me.layoutView.OptionsView.AllowHotTrackFields = False
			Me.layoutView.OptionsView.CardArrangeRule = DevExpress.XtraGrid.Views.Layout.LayoutCardArrangeRule.AllowPartialCards
			Me.layoutView.OptionsView.CardsAlignment = DevExpress.XtraGrid.Views.Layout.CardsAlignment.Near
			Me.layoutView.OptionsView.ContentAlignment = System.Drawing.ContentAlignment.TopLeft
			Me.layoutView.OptionsView.PartialCardWrapThreshold = 158
			Me.layoutView.OptionsView.ShowCardBorderIfCaptionHidden = False
			Me.layoutView.OptionsView.ShowCardExpandButton = False
			Me.layoutView.OptionsView.ShowCardLines = False
			Me.layoutView.OptionsView.ShowHeaderPanel = False
			Me.layoutView.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiColumn
			Me.layoutView.TemplateCard = Me.layoutViewCard1
			' 
			' layoutViewCard1
			' 
			Me.layoutViewCard1.CustomizationFormText = "TemplateCard"
			Me.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
			Me.layoutViewCard1.Name = "layoutViewCard1"
			Me.layoutViewCard1.OptionsItemText.TextToControlDistance = 0
			Me.layoutViewCard1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutViewCard1.ShowInCustomizationForm = False
			Me.layoutViewCard1.Spacing = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
			Me.layoutViewCard1.Text = "TemplateCard"
			Me.layoutViewCard1.TextLocation = DevExpress.Utils.Locations.Default
			' 
			' imageEditor
			' 
			Me.imageEditor.Name = "imageEditor"
			Me.imageEditor.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(548, 454)
			Me.Controls.Add(Me.gridControl)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageEditor, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl As DevExpress.XtraGrid.GridControl
		Private layoutView As DevExpress.XtraGrid.Views.Layout.LayoutView
		Private imageEditor As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard

	End Class
End Namespace

